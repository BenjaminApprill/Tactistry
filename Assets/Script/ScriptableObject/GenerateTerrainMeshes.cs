using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
 
public class GenerateTerrainMeshes: ScriptableObject
{    
    public IntRef TerrainChunks;

    [InlineEditor]
    public BuildTerrainQuadMesh BuildTerrainQuadMesh;

    Mesh[] meshes;

    public Mesh[] Build()
    {
        meshes = new Mesh[TerrainChunks.Val];

        for (int i = 0; i < TerrainChunks.Val; i++)
        {            
            meshes[i] = BuildTerrainQuadMesh.Build(i);
        }

        return meshes;
    }
}
