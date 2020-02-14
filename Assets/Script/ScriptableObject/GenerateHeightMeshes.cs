using System.Collections.Generic;
using UnityEngine;
 
public class GenerateHeightMeshes: ScriptableObject
{    
    int xStart;
    int zStart;
    int xSize;
    int zSize;    
    int currentIndex;    

    List<Vector3> meshVerts;
    Vector3 newVert;
    
    public List<Vector3> Build(TerrainDataModel TerrainData)
    {        
        meshVerts = new List<Vector3>();

        for (int i = 0; i < TerrainData.TerrainChunks.Val; i++)
        {
            xStart = TerrainData.Coords.Array[i].XCoord * TerrainData.TerrainChunkSize.Val;
            zStart = TerrainData.Coords.Array[i].ZCoord * TerrainData.TerrainChunkSize.Val;

            xSize = xStart + TerrainData.TerrainChunkSize.Val;
            zSize = zStart + TerrainData.TerrainChunkSize.Val;

            for (int y = zStart; y < zSize; y++)
            {
                for (int x = xStart; x < xSize; x++)
                {
                    newVert = new Vector3(x, TerrainData.HeightMap.Array[x, y], y);

                    meshVerts.Add(newVert);
                }
            }
        }

        return meshVerts;
    }
}
