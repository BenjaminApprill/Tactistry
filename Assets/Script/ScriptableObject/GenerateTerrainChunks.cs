using UnityEngine;
 
public class GenerateTerrainChunks: ScriptableObject
{
    public GameObject terrainChunkPrefab;

    GameObject[] chunkObjs;

    public CreateNewTerrainName TerrainName;
    public CreateNewTerrainPosition TerrainPosition;

    GameObject newTerrainObject;
    
    Vector3 newTerrainPosition;

    public GameObject[] Build(MapCoordinate[] mapCoords, float terrainChunkSize, Transform parent)
    {
        chunkObjs = new GameObject[mapCoords.Length];

        for (int i = 0; i < mapCoords.Length; i++)
        {
            newTerrainPosition = TerrainPosition.Build(mapCoords[i], terrainChunkSize);

            newTerrainObject = Instantiate(terrainChunkPrefab, newTerrainPosition, Quaternion.identity, parent);
            newTerrainObject.name = TerrainName.Build(mapCoords[i]);

            chunkObjs[i] = newTerrainObject;
            
        }

        return chunkObjs;
    }
}
