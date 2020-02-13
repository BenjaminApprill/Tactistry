using Sirenix.OdinInspector;
using UnityEngine;
 
public class CreateNewTerrainName: ScriptableObject
{
    [Required]
    public MapCoordinates MapCoords;

    string newName;

    public string Build(int i)
    {
        newName = "Terrain: " + MapCoords.Array[i].XCoord + ", " + MapCoords.Array[i].ZCoord;

        return newName;
    }
}
