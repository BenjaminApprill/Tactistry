using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainTexture: ScriptableObject
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunkSize;

    public NoiseColors NoiseColors;

    Texture2D terrainTexture;

    Color[] terrainColors;

    int wholeWidth;

    int xStart;
    int zStart;

    int xSize;
    int zSize;

    int currentIndex;

    public Texture2D Build(MapCoordinate coord)
    {
        wholeWidth = MapWidth.Val * TerrainChunkSize.Val;

        xStart = coord.XCoord * TerrainChunkSize.Val;
        zStart = coord.ZCoord * TerrainChunkSize.Val;

        xSize = xStart + TerrainChunkSize.Val;
        zSize = zStart + TerrainChunkSize.Val;

        for (int y = zStart; y < zSize; y++)
        {
            for (int x = xStart; x < xSize; x++)
            {
                currentIndex = x + y * wholeWidth;

                terrainColors[currentIndex] = NoiseColors.Array[currentIndex];
            }
        }

        terrainTexture = new Texture2D(TerrainChunkSize.Val, TerrainChunkSize.Val);
        terrainTexture.SetPixels(terrainColors);

        return terrainTexture;
    }
}
