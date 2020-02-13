using Sirenix.OdinInspector;
using UnityEngine;

public class GenerateHeightMap: ScriptableObject
{    
    float[,] heightMap;

    int mapSizeX;
    int mapSizeZ;

    float sampleX;
    float sampleY;
    float perlinValue;

    float isolation;
    float constriction;

    float noiseHeight;

    float maxNoiseHeight;
    float minNoiseHeight;

    public float[,] Build(TerrainDataModel TerrainData)
    {
        mapSizeX = TerrainData.MapWidth.Val * TerrainData.TerrainChunkSize.Val;
        mapSizeZ = TerrainData.MapHeight.Val * TerrainData.TerrainChunkSize.Val;

        heightMap = new float[mapSizeX, mapSizeZ];

        maxNoiseHeight = float.MinValue;
        minNoiseHeight = float.MaxValue;

        for (int y = 0; y < mapSizeZ; y++)
        {
            for (int x = 0; x < mapSizeX; x++)
            {
                isolation = 1f;
                constriction = 1f;
                noiseHeight = 0f;

                for (int i = 0; i < TerrainData.NoisePasses.Val; i++)
                {
                    sampleX = (x + TerrainData.offsetX ) / TerrainData.NoiseScale.Val * isolation;
                    sampleY = (y + TerrainData.offsetZ) / TerrainData.NoiseScale.Val * isolation ;

                    perlinValue = Mathf.PerlinNoise(sampleX, sampleY) * 2 - 1;
                    noiseHeight += perlinValue * constriction;

                    isolation *= TerrainData.Isolation.Val;
                    constriction *= TerrainData.Constriction.Val;
                }

                if(noiseHeight > maxNoiseHeight)
                {
                    maxNoiseHeight = noiseHeight;
                }else if(noiseHeight < minNoiseHeight)
                {
                    minNoiseHeight = noiseHeight;
                }

                heightMap[x, y] = noiseHeight;
            }
        }

        for (int y = 0; y < mapSizeZ; y++)
        {
            for (int x = 0; x < mapSizeX; x++)
            {
                heightMap[x, y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, heightMap[x, y]);
            }
        }

        return heightMap;
    }
}
