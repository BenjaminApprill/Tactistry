using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainObjects: SerializedScriptableObject
{
    [InlineEditor]
    public MapCoordinates MapCoordinates;

    public Transform TerrainManager;    
    public GameObject terrainChunkPrefab;

    [InlineEditor]
    public CreateNewTerrainName TerrainName;
    [InlineEditor]
    public CreateNewTerrainPosition TerrainPosition;

    GameObject[] chunkObjs;
    GameObject newTerrainObject;
    Vector3 newTerrainPosition;    

    public GameObject[] Build()
    {
        chunkObjs = new GameObject[MapCoordinates.Array.Length];

        for (int i = 0; i < MapCoordinates.Array.Length; i++)
        {
            newTerrainPosition = TerrainPosition.Build(MapCoordinates.Array[i]);

            newTerrainObject = Instantiate(terrainChunkPrefab, Vector3.zero, Quaternion.identity, TerrainManager);
            newTerrainObject.name = TerrainName.Build(i);
            newTerrainObject.AddComponent<MeshFilter>();
            newTerrainObject.AddComponent<MeshRenderer>();

            chunkObjs[i] = newTerrainObject;
            
        }

        return chunkObjs;
    }
}
