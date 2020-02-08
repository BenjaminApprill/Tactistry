using UnityEngine;
 
public class GenerateNoiseColors: ScriptableObject
{
    Color[] terrainColors;
    float heightValue;
    Color newColor;

    public Color[] Build(int textureX, int textureY, float[,] heightMap, int mapWidth)
    {
        terrainColors = new Color[textureX * textureY];

        for (int y = 0; y < textureY; y++)
        {
            for (int x = 0; x < textureX; x++)
            {
                heightValue = heightMap[x, y];
                newColor = Color.Lerp(Color.white, Color.black, heightValue);
                terrainColors[x + y * mapWidth] = newColor;
            }
        }

        return terrainColors;
    }
}
