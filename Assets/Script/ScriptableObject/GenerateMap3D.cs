using Sirenix.OdinInspector;
using UnityEditor;
using UnityEngine;

public class GenerateMap3D : ScriptableObject, IReact
{
    [InlineEditor]
    public MapCoordinates MapCoordinates;
    [InlineEditor]
    public HeightMap HeightMap;
    [InlineEditor]
    public MeshHeightMap MeshHeightMap;
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

    public void React()
    {        
        TerrainObjects.ClearObjects();

        MapCoordinates.Generate();

        HeightMap.Generate();
        MapCellColors.Generate();
        //HeightRefiner.Refine();
        MeshHeightMap.Generate();

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
