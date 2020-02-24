using System.Collections.Generic;
using UnityEngine;
 
public class SlopeMap: ScriptableObject
{
    public IntRef MapXSize;
    public IntRef MapZSize;

    public MeshHeightMap MeshHeightMap;

    public Dictionary<Vector2, Dictionary<Vector2, float>> Map;

    Dictionary<Vector2, float> neighborSlopes;

    Vector3 currentPoint;
    float currentHeight;
    float currentNeighborHeight;
    Vector3 currentNeighborPoint;
    Vector3 normalizedDirection;

    public void Build()
    {
        Map = new Dictionary<Vector2, Dictionary<Vector2, float>>();
        
        for (int y = 0; y < MapZSize.Val; y++)
        {
            for (int x = 0; x < MapXSize.Val; x++)
            {
                neighborSlopes = new Dictionary<Vector2, float>();

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
                        if(i >= 0 && j >= 0 && i < MapXSize.Val && j < MapZSize.Val)
                        {
                            currentNeighborHeight = MeshHeightMap.Array[i, j];
                            currentNeighborPoint = new Vector3(i, currentNeighborHeight, j);
                            normalizedDirection = (currentPoint - currentNeighborPoint).normalized;

                            neighborSlopes.Add(new Vector2(i, j), normalizedDirection.y);
                        }
                    }
                }

                Map.Add(new Vector2(x, y), neighborSlopes);
            }
        }
    }    
}
