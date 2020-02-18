using UnityEngine;
 
public class MapCoordinates: ScriptableObject
{
    public MapCoordinate[] Array;

    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunks;

    MapCoordinate newCoord;

    public void Generate()
    {
        Array = new MapCoordinate[TerrainChunks.Val];

        for (int z = 0; z < MapHeight.Val; z++)
        {
            for (int x = 0; x < MapWidth.Val; x++)
            {
                newCoord = new MapCoordinate(x, z);
                Array[x + z * MapWidth.Val] = newCoord;
            }
        }
    }
}
