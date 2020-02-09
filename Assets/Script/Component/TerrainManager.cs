using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunks;

    public MapCoordinates Coords;
    public TerrainObjects Objects;
    public TerrainMeshes Meshes;
    public TerrainTextures Textures;
    
    [InlineEditor]
    public GenerateMapCoordinates GenCoords;
    [InlineEditor]
    public GenerateTerrainObjects GenObjects;
    [InlineEditor]
    public GenerateTerrainMeshes GenMeshes;
    [InlineEditor]
    public GenerateTerrainTextures GenTextures;
    [InlineEditor]
    public ConnectTerrainData data;

    void Start()
    {
        TerrainChunks.Val = MapWidth.Val * MapHeight.Val;

        Coords.Array = GenCoords.Build();
        Objects.Array = GenObjects.Build();
        Meshes.Array =  GenMeshes.Build();
        Textures.Array = GenTextures.Build();



    }
}
