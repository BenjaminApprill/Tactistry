using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainTextures: ScriptableObject
{    
    public IntRef TerrainChunks;
    
    [InlineEditor]
    public MapCoordinates MapCoordinates;
    
    [InlineEditor]
    public GenerateTerrainTexture TerrainTexture;

    Texture2D[] textures;

    public Texture2D[] Build()
    {
        textures = new Texture2D[TerrainChunks.Val];

        for (int i = 0; i < TerrainChunks.Val; i++)
        {
            textures[i] = TerrainTexture.Build(MapCoordinates.Array[i]);
        }

        return textures;
    }
}
