using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainTexture: ScriptableObject
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunkSize;
    public HeightMap HeightMap_Ref;

    [InlineEditor]
    public GenerateHeightMap HeightMap;
    [InlineEditor]
    public GenerateNoiseColors NoiseColors;

    Texture2D terrainTexture;

    int textureX;
    int textureY;

    Color[] terrainColors;

    public Texture2D Build()
    {
        textureX = MapWidth.Val * TerrainChunkSize.Val;
        textureY = MapHeight.Val * TerrainChunkSize.Val;

        HeightMap_Ref.Array = HeightMap.Build();
        terrainColors = NoiseColors.Build(textureX, textureY);



        terrainTexture = new Texture2D(textureX, textureY);
        terrainTexture.SetPixels(terrainColors);

        return terrainTexture;
    }
}
