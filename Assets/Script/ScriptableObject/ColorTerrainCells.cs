using Sirenix.OdinInspector;
using UnityEngine;

public class ColorTerrainCells : ScriptableObject
{
    [InlineEditor]
    public HeightMap HeightMap;
    [InlineEditor]
    public TerrainCells TerrainCells;

    public RiverMap RiverMap;

    int xLength;
    int zLength;

    Color[] colors;
    MapCellData currentCell;
    float currentHeight;

    Vector2 currentCoord;
    int currentX;
    int currentY;

    public Color[] Build()
    {
        xLength = HeightMap.Array.GetLength(0);
        zLength = HeightMap.Array.GetLength(1);

        colors = new Color[xLength * zLength];

        for (int y = 0; y < zLength; y++)
        {
            for (int x = 0; x < xLength; x++)
            {
                currentHeight = HeightMap.Array[x, y];

                for (int i = 0; i < TerrainCells.Array.Length; i++)
                {
                    currentCell = TerrainCells.Array[i];

                    if(currentHeight <= currentCell.heightValue)
                    {
                        colors[x + y * xLength] = currentCell.cellColor;
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < RiverMap.Map.Length; i++)
        {
            currentCoord = RiverMap.Map[i];

            colors[(int)(currentCoord.x + currentCoord.y * xLength)] = Color.blue;
        }

        return colors;
    }
}
