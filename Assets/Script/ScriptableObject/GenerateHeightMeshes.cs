using System.Collections.Generic;
using UnityEngine;
 
public class GenerateHeightMeshes: ScriptableObject
{
    public IntRef TerrainChunks;
    public IntRef TerrainChunkSize;
    public MapCoordinates MapCoordinates;
    public HeightMap HeightMap;

    int xStart;
    int zStart;
    int xSize;
    int zSize;    
    int currentIndex;    

    List<Vector3> meshVerts;
    Vector3 newVert;
    
    public List<Vector3> Build()
    {        
        meshVerts = new List<Vector3>();

        for (int i = 0; i < TerrainChunks.Val; i++)
        {
            xStart = MapCoordinates.Array[i].XCoord * TerrainChunkSize.Val;
            zStart = MapCoordinates.Array[i].ZCoord * TerrainChunkSize.Val;

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
        }

        return meshVerts;
    }
}
