using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
 
public class GenerateTerrainMeshes: ScriptableObject
{
    [Required]
    public IntRef TerrainChunks;

    Mesh[] meshes;
    int chunks;

    public Mesh[] Build(TerrainDataModel TerrainData)
    {
        chunks = TerrainChunks.Val;

        meshes = new Mesh[chunks];

        for (int i = 0; i < chunks; i++)
        {            
            meshes[i] = TerrainData.TerrainQuadMesh.Build(TerrainData, i);
        }

        return meshes;
    }
}
