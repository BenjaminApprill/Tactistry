using Sirenix.OdinInspector;
using UnityEngine;
 
public class UpdateMap3D: ScriptableObject
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunks;

    [InlineEditor]
    public MapCoordinates MapCoordinates;
    [InlineEditor]
    public HeightMap HeightMap;
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

    public void MapUpdate()
    {
        TerrainObjects.ClearObjects();

        TerrainChunks.Val = MapWidth.Val * MapHeight.Val;

        MapCoordinates.Generate();

        HeightMap.Generate();
        MapCellColors.Generate();

        TerrainObjects.Generate();
        TerrainMeshes.Generate();
        TerrainTextures.Generate();

        BuildTerrain.Build();
    }
}
