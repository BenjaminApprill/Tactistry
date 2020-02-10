using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateTerrainTextures: ScriptableObject
{
    public IntRef TerrainChunks;

    public MapCoordinates Coords;

    [InlineEditor]
    public GenerateTerrainTexture TerrainTexture;

    Texture2D[] textures;

    public Texture2D[] Build()
    {
        textures = new Texture2D[TerrainChunks.Val];

        for (int i = 0; i < TerrainChunks.Val; i++)
        {
            textures[i] = TerrainTexture.Build(Coords.Array[i]);
        }

        return textures;
    }
}
