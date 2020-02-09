using UnityEngine;
 
public class CreateNewTerrainName: ScriptableObject
{
    public MapCoordinates MapCoords;
    string newName;

    public string Build(int i)
    {
        newName = "Terrain: " + MapCoords.Array[i].XCoord + ", " + MapCoords.Array[i].ZCoord;

        return newName;
    }
}
