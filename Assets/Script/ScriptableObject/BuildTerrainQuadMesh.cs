using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
 
public class BuildTerrainQuadMesh: ScriptableObject
{    
    [Required]
    public BuildMesh Mesh;
    [Required]
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


        List<Vector2> uvs = new List<Vector2>();

        uvs.Add(new Vector2(0f, 0f));
        uvs.Add(new Vector2(0f, 1f));
        uvs.Add(new Vector2(1f, 1f));
        uvs.Add(new Vector2(1f, 0f));

        data.uvs = uvs;


        return Mesh.Build(data);
    }
}
