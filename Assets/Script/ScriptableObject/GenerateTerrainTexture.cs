using UnityEngine;
 
public class GenerateTerrainTexture: ScriptableObject
{
    public IntRef MapWidth_Ref;
    public IntRef MapHeight_Ref;
    public FloatRef TerrainChunkSize_Ref;

    public GenerateHeightMap HeightMap;
    public GenerateNoiseColors NoiseColors;

    Texture2D terrainTexture;

    int textureX;
    int textureY;

    float[,] heightMap;
    Color[] terrainColors;

    public Texture2D Build()
    {
        textureX = MapWidth_Ref.Val * (int)TerrainChunkSize_Ref.Val;
        textureY = MapHeight_Ref.Val * (int)TerrainChunkSize_Ref.Val;

        heightMap = HeightMap.Build();
        terrainColors = NoiseColors.Build(textureX, textureY, heightMap, MapWidth_Ref.Val);



        terrainTexture = new Texture2D(textureX, textureY);
        terrainTexture.SetPixels(terrainColors);

        return terrainTexture;
    }
}
