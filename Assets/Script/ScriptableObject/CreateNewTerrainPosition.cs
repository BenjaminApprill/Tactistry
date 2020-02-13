using Sirenix.OdinInspector;
using UnityEngine;
 
public class CreateNewTerrainPosition: ScriptableObject
{
    [Required]
    public IntRef MapSize;

    Vector3 newPosition;

    float newPositionX;
    float newPositionZ;

    public Vector3 Build(MapCoordinate coord)
    {
        newPositionX = coord.XCoord * MapSize.Val;
        newPositionZ = coord.ZCoord * MapSize.Val;

        newPosition = new Vector3(newPositionX, 0f, newPositionZ);

        return newPosition;
    }
}
