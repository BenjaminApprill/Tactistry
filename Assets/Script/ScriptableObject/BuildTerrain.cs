using UnityEngine;
 
public class BuildTerrain: ScriptableObject
{
    public IntRef TerrainChunks;

    public MapCoordinates Coords;
    public TerrainObjects Objects;
    public TerrainMeshes Meshes;
    public TerrainTextures Textures;

    public Material TerrainMaterial;
    Material newMaterial;

    public void Build()
    {
        for (int i = 0; i < TerrainChunks.Val; i++)
        {
            newMaterial = new Material(TerrainMaterial);

            Objects.Array[i].GetComponent<MeshFilter>().mesh = Meshes.Array[i];
            Objects.Array[i].GetComponent<MeshRenderer>().material = newMaterial;
            newMaterial.mainTexture = Textures.Array[i];
        }
    }
}
