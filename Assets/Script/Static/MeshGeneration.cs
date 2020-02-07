using UnityEngine;

public static class MeshGeneration
{
    public static Mesh CreateMesh(Vector3[] verts, int[] tris)
    {
        Mesh mesh = new Mesh();

        mesh.vertices = verts;
        mesh.triangles = tris;

        mesh.RecalculateNormals();

        return mesh;
    }    
}
