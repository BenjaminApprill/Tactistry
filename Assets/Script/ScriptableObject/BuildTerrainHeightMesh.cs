using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
 
public class BuildTerrainHeightMesh: ScriptableObject
{
    public IntRef TerrainChunkSize;

    [InlineEditor]
    public MapCoordinates MapCoordinates;
    [InlineEditor]
    public HeightMap HeightMap;

    int xStart;
    int zStart;
    int xSize;
    int zSize;
    int currentIndex;

    List<Vector3> meshVerts;
    Vector3 newVert;

    public List<Vector3> Build(int i)
    {
        meshVerts = new List<Vector3>();

        xStart = MapCoordinates.Array[i].XCoord * TerrainChunkSize.Val;
        zStart = MapCoordinates.Array[i].ZCoord * TerrainChunkSize.Val;

        xStart -= MapCoordinates.Array[i].XCoord;
        zStart -= MapCoordinates.Array[i].ZCoord;

        xSize = xStart + TerrainChunkSize.Val;
        zSize = zStart + TerrainChunkSize.Val;

        for (int y = zStart; y < zSize; y++)
        {
            for (int x = xStart; x < xSize; x++)
            {
                newVert = new Vector3(x, HeightMap.Array[x, y], y);

                meshVerts.Add(newVert);
            }
        }
        
        return meshVerts;
    }
}
