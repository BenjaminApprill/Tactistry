using UnityEngine;
 
public class HeightRefiner : ScriptableObject
{
    public FloatRef TerrainHeightAdjustment;
    public HeightEvaluationCurve HeightEvaluationCurve;
    public HeightMap HeightMap;

    public void Refine()
    {
        for (int y = 0; y < HeightMap.Array.GetLength(1); y++)
        {
            for (int x = 0; x < HeightMap.Array.GetLength(0); x++)
            {
                HeightEvaluationCurve.AnimationCurve.Evaluate(HeightMap.Array[x, y]);
                HeightMap.Array[x, y] *= TerrainHeightAdjustment.Val;
            }
        }

    }
}
