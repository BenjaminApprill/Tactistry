using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;

public class BuildTerrainQuadMesh: ScriptableObject
{
    public IntRef TerrainChunkSize;
    
    [InlineEditor]
    public BuildMesh BuildMesh;    
    [InlineEditor]
    public BuildTerrainOffsets BuildTerrainOffsets;
    [InlineEditor]
    public BuildTerrainHeightMesh BuildTerrainHeightMesh;

    MeshData data;

    public Mesh Build(int index)
    {
        data = new MeshData();

        //data.vertices = BuildTerrainOffsets.Build();
        data.vertices = BuildTerrainHeightMesh.Build(index);

        List<int> tris = new List<int>();
        List<Vector2> uvs = new List<Vector2>();

        int vertexIndex = 0;

        for (int y = 0; y < TerrainChunkSize.Val; y++)
        {
            for (int x = 0; x < TerrainChunkSize.Val; x++)
            {
                uvs.Add(new Vector2(x / (float)TerrainChunkSize.Val, y / (float)TerrainChunkSize.Val));

                if (x < TerrainChunkSize.Val - 1 && y < TerrainChunkSize.Val - 1)
                {
                    tris.Add(vertexIndex);
                    tris.Add(vertexIndex + TerrainChunkSize.Val);
                    tris.Add(vertexIndex + TerrainChunkSize.Val + 1);

                    tris.Add(vertexIndex);
                    tris.Add(vertexIndex + TerrainChunkSize.Val + 1);
                    tris.Add(vertexIndex + 1);
                }

                vertexIndex++;
            }
        }

        //tris.Add(0);
        //tris.Add(1);
        //tris.Add(2);

        //tris.Add(0);
        //tris.Add(2);
        //tris.Add(3);

        data.triangles = tris;

        //uvs.Add(new Vector2(0f, 0f));
        //uvs.Add(new Vector2(0f, 1f));
        //uvs.Add(new Vector2(1f, 1f));
        //uvs.Add(new Vector2(1f, 0f));

        data.uvs = uvs;

        return BuildMesh.Build(data);
    }
}
