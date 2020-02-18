using Sirenix.OdinInspector;
using UnityEngine;

public class BuildTerrain: ScriptableObject
{
    public IntRef TerrainChunks;

    [InlineEditor]
    public MapCoordinates MapCoordinates;
    [InlineEditor]
    public TerrainObjects TerrainObjects;
    [InlineEditor]
    public TerrainMeshes TerrainMeshes;
    [InlineEditor]
    public TerrainTextures TerrainTextures;

    public Material TerrainMaterial;

    Material newMaterial;

    public void Build()
    {
        for (int i = 0; i < TerrainChunks.Val; i++)
        {
            newMaterial = new Material(TerrainMaterial);

            TerrainObjects.Array[i].GetComponent<MeshFilter>().mesh = TerrainMeshes.Array[i];
            TerrainObjects.Array[i].GetComponent<MeshRenderer>().material = newMaterial;
            newMaterial.mainTexture = TerrainTextures.Array[i];
        }
    }
}
