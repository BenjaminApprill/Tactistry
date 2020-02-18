using Sirenix.OdinInspector;
using UnityEngine;

public class GenerateHeightMap: ScriptableObject
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunkSize;
    public IntRef NoisePasses;
    public FloatRef NoiseScale;
    public FloatRef Isolation;
    public FloatRef Constriction;
    public FloatRef OffsetX;
    public FloatRef OffsetZ;

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

    public float[,] Build()
    {
        mapSizeX = MapWidth.Val * TerrainChunkSize.Val;
        mapSizeZ = MapHeight.Val * TerrainChunkSize.Val;

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

                for (int i = 0; i < NoisePasses.Val; i++)
                {
                    sampleX = (x + OffsetX.Val ) / NoiseScale.Val * isolation;
                    sampleY = (y + OffsetZ.Val) / NoiseScale.Val * isolation ;

                    perlinValue = Mathf.PerlinNoise(sampleX, sampleY) * 2 - 1;
                    noiseHeight += perlinValue * constriction;

                    isolation *= Isolation.Val;
                    constriction *= Constriction.Val;
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
