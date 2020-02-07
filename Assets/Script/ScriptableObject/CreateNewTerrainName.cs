using UnityEngine;
 
public class CreateNewTerrainName: ScriptableObject
{
    string newName;

    public string Build(MapCoordinate coord)
    {
        newName = "Terrain: " + coord.XCoord + ", " + coord.ZCoord;

        return newName;
    }
}
