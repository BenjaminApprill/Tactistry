using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public int mapWidth;
    public int mapHeight;

    public float terrainChunkSize;
    
    MapCoordinate[] mapCoords;
    GameObject[] terrainObjects;

    public GenerateMapCoordinates MapCoords;
    public GenerateTerrainChunks TerrainChunks;
    public GenerateTerrainMeshes TerrainMeshes;

    void Start()
    {
        mapCoords = MapCoords.Build(mapWidth, mapHeight);
        terrainObjects = TerrainChunks.Build(mapCoords, terrainChunkSize, transform);
        TerrainMeshes.Build(terrainObjects, terrainChunkSize);        
    }
}
