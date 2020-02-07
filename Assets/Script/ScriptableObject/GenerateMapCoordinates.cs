using UnityEngine;

public class GenerateMapCoordinates : ScriptableObject
{
    MapCoordinate[] coords;
    MapCoordinate newCoord;

    public MapCoordinate[] Build(int xDim, int zDim)
    {
        coords = new MapCoordinate[xDim * zDim];

        for (int z = 0; z < zDim; z++)
        {
            for (int x = 0; x < xDim; x++)
            {
                newCoord = new MapCoordinate(x, z);
                coords[x + z * xDim] = newCoord;
            }
        }

        return coords;
    }
}
