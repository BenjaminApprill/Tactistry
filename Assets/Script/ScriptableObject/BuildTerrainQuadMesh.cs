using System.Collections.Generic;
using UnityEngine;
 
public class BuildTerrainQuadMesh: ScriptableObject
{    
    public BuildMesh Mesh;

    public BuildTerrainOffsets TerrainOffsets;

    MeshData data;

    public Mesh Build()
    {
        data = new MeshData();

        data.vertices = TerrainOffsets.Build();

        List<int> tris = new List<int>();

        tris.Add(0);
        tris.Add(1);
        tris.Add(2);

        tris.Add(0);
        tris.Add(2);
        tris.Add(3);

        data.triangles = tris;

        return Mesh.Build(data);
    }
}
