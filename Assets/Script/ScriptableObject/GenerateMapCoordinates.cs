using Sirenix.OdinInspector;
using UnityEngine;

public class GenerateMapCoordinates : ScriptableObject
{
    [Required]
    public IntRef MapWidth;
    [Required]
    public IntRef MapHeight;
    [Required]
    public IntRef TerrainChunks;

    MapCoordinate[] coords;
    MapCoordinate newCoord;

    public MapCoordinate[] Build()
    {
        coords = new MapCoordinate[TerrainChunks.Val];

        for (int z = 0; z < MapHeight.Val; z++)
        {
            for (int x = 0; x < MapWidth.Val; x++)
            {
                newCoord = new MapCoordinate(x, z);
                coords[x + z * MapWidth.Val] = newCoord;
            }
        }

        return coords;
    }
}
