using UnityEngine;
 
public class GenerateHeightMap: ScriptableObject
{
    public IntRef TerrainChunkSize_Ref;
    public FloatRef NoiseScale_Ref;

    float[,] heightMap;

    public float[,] Build()
    {
        heightMap = new float[TerrainChunkSize_Ref.Val, TerrainChunkSize_Ref.Val];

        for (int y = 0; y < TerrainChunkSize_Ref.Val; y++)
        {
            for (int x = 0; x < TerrainChunkSize_Ref.Val; x++)
            {
                float sampleX = x / NoiseScale_Ref.Val;
                float sampleY = y / NoiseScale_Ref.Val;

                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);

                heightMap[x, y] = perlinValue;
            }
        }

        return heightMap;
    }
}
