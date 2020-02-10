using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainObjects: ScriptableObject
{
    public MapCoordinates Coords;
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
        chunkObjs = new GameObject[Coords.Array.Length];

        for (int i = 0; i < Coords.Array.Length; i++)
        {
            newTerrainPosition = TerrainPosition.Build(Coords.Array[i]);

            newTerrainObject = Instantiate(terrainChunkPrefab, newTerrainPosition, Quaternion.identity, TerrainManager);
            newTerrainObject.name = TerrainName.Build(i);
            newTerrainObject.AddComponent<MeshFilter>();
            newTerrainObject.AddComponent<MeshRenderer>();

            chunkObjs[i] = newTerrainObject;
            
        }

        return chunkObjs;
    }
}
