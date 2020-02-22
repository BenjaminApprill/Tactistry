using System.Collections.Generic;
using UnityEngine;
 
public class SlopeMap: ScriptableObject
{
    public IntRef MapXSize;
    public IntRef MapZSize;

    public MeshHeightMap MeshHeightMap;

    //public BuildNeighborSlopes BuildNeighborSlopes;

    public Dictionary<Vector3, Dictionary<Vector3, float>> Map;

    Dictionary<Vector3, float> neighborSlopes;

    Vector3 currentPoint;
    float currentHeight;
    float currentNeighborHeight;

    public void Build()
    {
        Map = new Dictionary<Vector3, Dictionary<Vector3, float>>();
        neighborSlopes = new Dictionary<Vector3, float>();

        for (int y = 0; y < MapZSize.Val; y++)
        {
            for (int x = 0; x < MapXSize.Val; x++)
            {
                currentHeight = MeshHeightMap.Array[x, y];
                currentPoint = new Vector3(x, currentHeight, y);

                for (int j = y - 1; j <= y + 1; j++)
                {
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        if(i == x && j == y)
                        {
                            continue;
                        }
                        if(i >= 0 && j >= 0 && i <= MapXSize.Val && j <= MapZSize.Val)
                        {
                            currentNeighborHeight = MeshHeightMap.Array[i, j];
                            //Vector3.Dot()
                        }
                    }
                }

                //neighborSlopes = BuildNeighborSlopes();

                Map.Add(currentPoint, neighborSlopes);
            }
        }
    }    
}
