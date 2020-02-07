using UnityEngine;
 
public class CreateNewTerrainPosition: ScriptableObject
{
    Vector3 newPosition;

    float newPositionX;
    float newPositionZ;

    public Vector3 Build(MapCoordinate coord, float terrainChunkSize)
    {
        newPositionX = coord.XCoord * terrainChunkSize;
        newPositionZ = coord.ZCoord * terrainChunkSize;

        newPosition = new Vector3(newPositionX, 0f, newPositionZ);

        return newPosition;
    }
}
