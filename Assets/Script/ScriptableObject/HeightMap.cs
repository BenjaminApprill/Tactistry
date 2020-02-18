using UnityEngine;
 
public class HeightMap: ScriptableObject
{
    public float[,] Array;

    public GenerateHeightMap GenerateHeightMap;

    public void Generate()
    {
        Array = GenerateHeightMap.Build();
    }
}
