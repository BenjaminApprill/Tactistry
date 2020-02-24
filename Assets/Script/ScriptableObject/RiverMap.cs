using Sirenix.OdinInspector;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RiverMap: ScriptableObject
{
    public Vector2[] Map;
    
    public SlopeMap SlopeMap;

    public Vector2Ref TestRiverStart;
    public IntRef TestRiverLength;

    List<Vector2> riverPoints;
    Dictionary<Vector2, float> currentNeighbors;

    int currentLength;
    bool hasLower;

    float lowestHeight;
    Vector2 lowestPosition;

    public void Build()
    {
        riverPoints = new List<Vector2>();

        TestRiverStart.Val.x = Mathf.RoundToInt(TestRiverStart.Val.x);
        TestRiverStart.Val.y = Mathf.RoundToInt(TestRiverStart.Val.y);

        currentLength = 0;

        currentNeighbors = SlopeMap.Map[TestRiverStart.Val];
        lowestHeight = float.MaxValue;

        CheckNeighbors(currentNeighbors);

        Map = riverPoints.ToArray();
    }

    void CheckNeighbors(Dictionary<Vector2, float> neighbors)
    {
        hasLower = false;

        lowestHeight = neighbors.First().Value;
        lowestPosition = neighbors.First().Key;

        foreach (var val in neighbors)
        {
            if (val.Value < lowestHeight)
            {
                lowestHeight = val.Value;
                lowestPosition = val.Key;
                //hasLower = true;
            }
        }

        currentLength++;
        riverPoints.Add(lowestPosition);

        if (currentLength < TestRiverLength.Val)
        {
            CheckNeighbors(SlopeMap.Map[lowestPosition]);
        }
    }
}

//If no neighbor is lower, each of those neighbors needs to be checked for a lower
//neighbor
//