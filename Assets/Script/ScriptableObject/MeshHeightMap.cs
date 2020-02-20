using Sirenix.OdinInspector;
using UnityEngine;
 
public class MeshHeightMap: ScriptableObject
{
    public float[,] Array;

    public FloatRef TerrainHeightAdjustment;

    [InlineEditor]
    public HeightMap HeightMap;
    [InlineEditor]
    public HeightEvaluationCurve HeightEvaluationCurve;

    int xSize;
    int ySize;

    public void Generate()
    {
        xSize = HeightMap.Array.GetLength(0);
        ySize = HeightMap.Array.GetLength(1);

        Array = new float[xSize,ySize];

        for (int y = 0; y < ySize; y++)
        {
            for (int x = 0; x < xSize; x++)
            {
                Array[x, y] = HeightEvaluationCurve.AnimationCurve.Evaluate(HeightMap.Array[x, y]);
                Array[x, y] *= TerrainHeightAdjustment.Val;
            }
        }
    }
}
