using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;
    public int terrainChunkSize;

    public IntRef MapWidth;    
    public IntRef MapHeight;
    public IntRef TerrainChunkSize;
    public IntRef TerrainChunks;

    public HeightMap HeightMap;
    public NoiseColors NoiseColors;

    public MapCoordinates Coords;
    public TerrainObjects Objects;
    public TerrainMeshes Meshes;
    public TerrainTextures Textures;

    [InlineEditor]
    public GenerateHeightMap GenHeightMap;
    [InlineEditor]
    public GenerateNoiseColors GenNoiseColors;

    [InlineEditor]
    public GenerateMapCoordinates GenCoords;
    [InlineEditor]
    public GenerateTerrainObjects GenObjects;
    [InlineEditor]
    public GenerateTerrainMeshes GenMeshes;
    [InlineEditor]
    public GenerateTerrainTextures GenTextures;
    [InlineEditor]
    public BuildTerrain Terrain;

    void Start()
    {
        MapWidth.Val = mapWidth;
        MapHeight.Val = mapHeight;
        TerrainChunkSize.Val = terrainChunkSize;

        TerrainChunks.Val = mapWidth * mapHeight;

        HeightMap.Array = GenHeightMap.Build();
        NoiseColors.Array = GenNoiseColors.Build();

        Coords.Array = GenCoords.Build();
        Objects.Array = GenObjects.Build();
        Meshes.Array =  GenMeshes.Build();
        Textures.Array = GenTextures.Build();

        Terrain.Build();
    }
}
