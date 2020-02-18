using Sirenix.OdinInspector;
using UnityEngine;
 
public class TerrainTextures: ScriptableObject
{
    public Texture2D[] Array;

    [InlineEditor]
    public GenerateTerrainTextures GenerateTerrainTextures;

    public void Generate()
    {
        Array = GenerateTerrainTextures.Build();
    }
}
