using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

public class GenerateMap3D: ScriptableObject
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunks;

    [InlineEditor]
    public MapCoordinates MapCoordinates;
    [InlineEditor]
    public HeightMap HeightMap;
    [InlineEditor]
    public HeightRefiner HeightRefiner;
    [InlineEditor]
    public MapCellColors MapCellColors;
    [InlineEditor]
    public TerrainObjects TerrainObjects;
    [InlineEditor]
    public TerrainMeshes TerrainMeshes;
    [InlineEditor]
    public TerrainTextures TerrainTextures;
    [InlineEditor]
    public BuildTerrain BuildTerrain;    


    public void Build()
    {
        Debug.Log("Test");
        TerrainObjects.ClearObjects();

        TerrainChunks.Val = MapWidth.Val * MapHeight.Val;

        MapCoordinates.Generate();

        HeightMap.Generate();
        HeightRefiner.Refine();
        MapCellColors.Generate();

        TerrainObjects.Generate();
        TerrainMeshes.Generate();
        TerrainTextures.Generate();

        BuildTerrain.Build();
    }

    //void Open()
    //{
    //    string objPath = "Assets/Script/ScriptableObject/" + obj.name + ".asset";
    //    var ScriptObj = (MonoScript)AssetDatabase.LoadAssetAtPath(objPath, typeof(MonoScript));
    //    AssetDatabase.OpenAsset(ScriptObj);
    //}
}
