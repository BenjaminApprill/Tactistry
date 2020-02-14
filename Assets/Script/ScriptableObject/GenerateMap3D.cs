using Sirenix.OdinInspector;
using UnityEngine;

public class GenerateMap3D: ScriptableObject
{
    public void Build(TerrainDataModel TerrainData)
    {
        TerrainData.SetVariables();

        TerrainData.Coords.Array = TerrainData.GenCoords.Build();

        TerrainData.HeightMap.Array = TerrainData.GenHeightMap.Build(TerrainData);
        TerrainData.MapCellColors.Array = TerrainData.ColorTerrainCells.Build();

        TerrainData.Objects.Array = TerrainData.GenObjects.Build();
        TerrainData.Meshes.Array = TerrainData.GenMeshes.Build(TerrainData);
        TerrainData.Textures.Array = TerrainData.GenTextures.Build();

        TerrainData.Terrain.Build();
    }

}
