using UnityEngine;
 
public class BuildMesh: ScriptableObject
{
    Mesh mesh;

    public Mesh Build(MeshData data)
    {
        mesh = new Mesh();

        mesh.vertices = data.vertices.ToArray();
        mesh.triangles = data.triangles.ToArray();

        if(data.uvs != null)
        {
            mesh.uv = data.uvs.ToArray();
        }

        if(data.normals != null)
        {
            mesh.normals = data.normals.ToArray();
        }
        else
        {
            mesh.RecalculateNormals();
        }

        return mesh;
    }
}
