using Sirenix.OdinInspector;
using UnityEngine;

public class GenerateHeightMap: ScriptableObject
{
    public IntRef MapXSize;
    public IntRef MapZSize;
    
    public IntRef NoisePasses;
    public FloatRef NoiseScale;
    public FloatRef Isolation;
    public FloatRef Constriction;
    public FloatRef OffsetX;
    public FloatRef OffsetZ;

    float[,] heightMap;

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
        heightMap = new float[MapXSize.Val, MapZSize.Val];

        maxNoiseHeight = float.MinValue;
        minNoiseHeight = float.MaxValue;

        for (int y = 0; y < MapZSize.Val; y++)
        {
            for (int x = 0; x < MapXSize.Val; x++)
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

        for (int y = 0; y < MapZSize.Val; y++)
        {
            for (int x = 0; x < MapXSize.Val; x++)
            {
                heightMap[x, y] = Mathf.InverseLerp(minNoiseHeight, maxNoiseHeight, heightMap[x, y]);
            }
        }

        return heightMap;
    }
}
