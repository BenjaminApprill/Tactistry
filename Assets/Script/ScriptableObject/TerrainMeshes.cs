using Sirenix.OdinInspector;
using UnityEngine;
 
public class TerrainMeshes: ScriptableObject
{
    public Mesh[] Array;

    [InlineEditor]
    public GenerateTerrainMeshes GenerateTerrainMeshes;

    public void Generate()
    {
        Array = GenerateTerrainMeshes.Build();
    }
}
