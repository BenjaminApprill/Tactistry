using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainTexture: ScriptableObject
{
    [Required]
    public IntRef MapWidth;
    [Required]
    public IntRef MapHeight;
    [Required]
    public IntRef TerrainChunkSize;

    [Required]
    public NoiseColors NoiseColors;
    [Required]
    public MapCellColors MapCellColors;
    
    Texture2D terrainTexture;

    Color[] terrainColors;

    int wholeWidth;

    int xStart;
    int zStart;

    int xSize;
    int zSize;

    int currentIndex;
    int localIndex;

    public Texture2D Build(MapCoordinate coord)
    {
        wholeWidth = MapWidth.Val * TerrainChunkSize.Val;

        xStart = coord.XCoord * TerrainChunkSize.Val;
        zStart = coord.ZCoord * TerrainChunkSize.Val;

        xSize = xStart + TerrainChunkSize.Val;
        zSize = zStart + TerrainChunkSize.Val;

        localIndex = 0;
        terrainColors = new Color[TerrainChunkSize.Val * TerrainChunkSize.Val];

        for (int y = zStart; y < zSize; y++)
        {
            for (int x = xStart; x < xSize; x++)
            {
                currentIndex = x + y * wholeWidth;

                terrainColors[localIndex] = MapCellColors.Array[currentIndex];

                localIndex++;
            }
        }

        terrainTexture = new Texture2D(TerrainChunkSize.Val, TerrainChunkSize.Val);
        terrainTexture.filterMode = FilterMode.Point;
        terrainTexture.wrapMode = TextureWrapMode.Clamp;
        terrainTexture.SetPixels(terrainColors);
        terrainTexture.Apply();

        return terrainTexture;
    }
}
