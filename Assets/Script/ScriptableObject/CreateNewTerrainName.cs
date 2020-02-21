using Sirenix.OdinInspector;
using UnityEngine;
 
public class CreateNewTerrainName: ScriptableObject
{    
    public MapCoordinates MapCoordinates;

    string newName;

    public string Build(int i)
    {
        newName = "Terrain: " + MapCoordinates.Array[i].XCoord + ", " + MapCoordinates.Array[i].ZCoord;

        return newName;
    }
}
