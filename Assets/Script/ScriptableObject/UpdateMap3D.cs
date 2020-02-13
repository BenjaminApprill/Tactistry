using UnityEngine;
 
public class UpdateMap3D: ScriptableObject
{
    public void MapUpdate(TerrainDataModel TerrainData)
    {
        TerrainData.SetVariables();
        TerrainData.ClearTerrainObjects();

        TerrainData.Coords.Array = TerrainData.GenCoords.Build();

        TerrainData.HeightMap.Array = TerrainData.GenHeightMap.Build(TerrainData);
        TerrainData.MapCellColors.Array = TerrainData.ColorTerrainCells.Build();

        TerrainData.Objects.Array = TerrainData.GenObjects.Build();
        TerrainData.Meshes.Array = TerrainData.GenMeshes.Build();
        TerrainData.Textures.Array = TerrainData.GenTextures.Build();

        TerrainData.Terrain.Build();
    }
}
