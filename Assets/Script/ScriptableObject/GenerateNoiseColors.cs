using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateNoiseColors: ScriptableObject
{    
    [Required]
    public HeightMap HeightMap;

    int mapSizeX;
    int mapSizeZ;

    Color[,] terrainColors;
    float heightValue;
    Color newColor;

    public Color[,] Build()
    {
        mapSizeX = HeightMap.Array.GetLength(0);
        mapSizeZ = HeightMap.Array.GetLength(1);

        terrainColors = new Color[mapSizeX, mapSizeZ];

        for (int y = 0; y < mapSizeZ; y++)
        {
            for (int x = 0; x < mapSizeX; x++)
            {
                heightValue = HeightMap.Array[x, y];
                newColor = Color.Lerp(Color.white, Color.black, heightValue);
                terrainColors[x, y] = newColor;
            }
        }

        return terrainColors;
    }
}
