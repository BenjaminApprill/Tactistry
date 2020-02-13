using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainObjects: ScriptableObject
{
    [Required]
    public MapCoordinates Coords;
    [Required]
    public Transform TerrainManager;
    [Required]
    public GameObject terrainChunkPrefab;

    [Required]
    public CreateNewTerrainName TerrainName;
    [Required]
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
