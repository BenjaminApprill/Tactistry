using UnityEngine;
 
public class GenerateNoiseColors: ScriptableObject
{
    public IntRef MapWidth;
    public HeightMap HeightMap_Ref;

    Color[] terrainColors;
    float heightValue;
    Color newColor;

    public Color[] Build(int textureX, int textureY)
    {
        terrainColors = new Color[textureX * textureY];

        for (int y = 0; y < textureY; y++)
        {
            for (int x = 0; x < textureX; x++)
            {
                heightValue = HeightMap_Ref.Array[x, y];
                newColor = Color.Lerp(Color.white, Color.black, heightValue);
                terrainColors[x + y * MapWidth.Val] = newColor;
            }
        }

        return terrainColors;
    }
}
