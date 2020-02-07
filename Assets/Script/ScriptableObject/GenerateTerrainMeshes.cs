using System.Collections.Generic;
using UnityEngine;
 
public class GenerateTerrainMeshes: ScriptableObject
{
    public Material terrainMaterial;

    public BuildTerrainQuadMesh TerrainQuadMesh;

    public void Build(GameObject[] terrainObjects, float terrainChunkSize)
    {
        for (int i = 0; i < terrainObjects.Length; i++)
        {
            terrainObjects[i].AddComponent<MeshFilter>();
            terrainObjects[i].AddComponent<MeshRenderer>();

            terrainObjects[i].GetComponent<MeshFilter>().sharedMesh = TerrainQuadMesh.Build(terrainChunkSize);
            terrainObjects[i].GetComponent<MeshRenderer>().material = terrainMaterial;
        }
    }
}
