using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
 
public class GenerateTerrainMeshes: ScriptableObject
{
    public IntRef TerrainChunks;

    [InlineEditor]
    public BuildTerrainQuadMesh TerrainQuadMesh;

    Mesh[] meshes;
    int chunks;

    public Mesh[] Build()
    {
        chunks = TerrainChunks.Val;

        meshes = new Mesh[chunks];

        for (int i = 0; i < chunks; i++)
        {            
            meshes[i] = TerrainQuadMesh.Build();
        }

        return meshes;
    }
}
