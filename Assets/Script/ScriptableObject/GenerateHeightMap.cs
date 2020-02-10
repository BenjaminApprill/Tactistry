using UnityEngine;
 
public class GenerateHeightMap: ScriptableObject
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef MapChunkSize;
    public FloatRef NoiseScale;

    float[,] heightMap;

    int mapSizeX;
    int mapSizeZ;

    float sampleX;
    float sampleY;
    float perlinValue;

    public float[,] Build()
    {
        mapSizeX = MapWidth.Val * MapChunkSize.Val;
        mapSizeZ = MapHeight.Val * MapChunkSize.Val;

        heightMap = new float[mapSizeX, mapSizeZ];

        for (int y = 0; y < mapSizeZ; y++)
        {
            for (int x = 0; x < mapSizeX; x++)
            {
                sampleX = x / NoiseScale.Val;
                sampleY = y / NoiseScale.Val;

                perlinValue = Mathf.PerlinNoise(sampleX, sampleY);

                heightMap[x, y] = perlinValue;
            }
        }

        return heightMap;
    }
}
