using UnityEngine;
 
public class CreateNewTerrainPosition: ScriptableObject
{
    public IntRef TerrainChunkSize;

    Vector3 newPosition;

    float newPositionX;
    float newPositionZ;

    public Vector3 Build(MapCoordinate coord)
    {
        newPositionX = coord.XCoord * TerrainChunkSize.Val;
        newPositionZ = coord.ZCoord * TerrainChunkSize.Val;

        newPosition = new Vector3(newPositionX, 0f, newPositionZ);

        return newPosition;
    }
}
