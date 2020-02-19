using Sirenix.OdinInspector;
using UnityEngine;
 
public class TerrainObjects: ScriptableObject
{
    public GameObject[] Array;

    [InlineEditor]
    public GenerateTerrainObjects GenerateTerrainObjects;

    public void Generate()
    {
        Array = GenerateTerrainObjects.Build();
    }
    
    public void ClearObjects()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            DestroyImmediate(Array[i]);
        }
    }
}
