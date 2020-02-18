using Sirenix.OdinInspector;
using UnityEngine;
 
public class MapCellColors: ScriptableObject
{
    public Color[] Array;

    [InlineEditor]
    public ColorTerrainCells ColorTerrainCells;

    public void Generate()
    {
        Array = ColorTerrainCells.Build();
    }
}
