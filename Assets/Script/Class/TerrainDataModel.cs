using Sirenix.OdinInspector;
using System;
using UnityEngine;

[Serializable]
public class TerrainDataModel
{
    [Range(1, 16)]
    public int mapWidth;
    [Range(1, 16)]
    public int mapHeight;
    [Range(1, 64)]
    public int mapSize;
    [Range(1, 512)]
    public int terrainChunkSize;

    [Range(1, 10)]
    public int noisePasses;
    [Range(0.0001f, 1000f)]
    public float noiseScale;
    [Range(1,6)]
    public float scaleMultiple;
    [Range(1f, 10f)]
    public float isolation;
    [Range(0.0001f, 0.9999f)]
    public float constriction;

    public float offsetX;
    public float offsetZ;

    [Required]
    public IntRef MapWidth;
    [Required]
    public IntRef MapHeight;
    [Required]
    public IntRef MapSize;
    [Required]
    public IntRef TerrainChunkSize;
    [Required]
    public IntRef TerrainChunks;

    [Required]
    public FloatRef NoiseScale;
    [Required]
    public IntRef NoisePasses;
    [Required]
    public FloatRef Isolation;
    [Required]
    public FloatRef Constriction;

    public void SetVariables()
    {
        MapWidth.Val = mapWidth;
        MapHeight.Val = mapHeight;
        MapSize.Val = mapSize;
        TerrainChunkSize.Val = terrainChunkSize;

        NoisePasses.Val = noisePasses;
        NoiseScale.Val = noiseScale;
        Isolation.Val = isolation;
        Constriction.Val = constriction;

        TerrainChunks.Val = mapWidth * mapHeight;
    }

    [Required]
    [InlineEditor(InlineEditorObjectFieldModes.Hidden)]
    public TerrainCells Cells;

    [Required]
    public HeightMap HeightMap;
    [Required]
    public NoiseColors NoiseColors;
    [Required]
    public MapCellColors MapCellColors;

    [Required]
    public MapCoordinates Coords;
    [Required]
    public TerrainObjects Objects;
    [Required]
    public TerrainMeshes Meshes;
    [Required]
    public TerrainTextures Textures;

    public void ClearTerrainObjects()
    {        
        for (int i = 0; i < Objects.Array.Length; i++)
        {            
            GameObject.DestroyImmediate(Objects.Array[i].gameObject);
        }
    }

    [Required]
    public GenerateHeightMap GenHeightMap;
    [Required]
    public GenerateNoiseColors GenNoiseColors;
    [Required]
    public ColorTerrainCells ColorTerrainCells;

    [Required]
    public GenerateMapCoordinates GenCoords;
    [Required]
    public GenerateTerrainObjects GenObjects;
    [Required]
    public GenerateTerrainMeshes GenMeshes;
    [Required]
    public GenerateHeightMeshes GenHeightMeshes;
    [Required]
    public BuildTerrainQuadMesh TerrainQuadMesh;
    [Required]
    public BuildTerrainHeightMesh BuildTerrainHeightMesh;
    [Required]
    public GenerateTerrainTextures GenTextures;

    [Required]
    public BuildTerrain Terrain;
}
