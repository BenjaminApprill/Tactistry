using Sirenix.OdinInspector;
using UnityEngine;

public class BuildTerrain: ScriptableObject
{
    [Required]
    public IntRef TerrainChunks;

    [Required]
    public MapCoordinates Coords;
    [Required]
    public TerrainObjects Objects;
    [Required]
    public TerrainMeshes Meshes;
    [Required]
    public TerrainTextures Textures;

    [Required]
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
