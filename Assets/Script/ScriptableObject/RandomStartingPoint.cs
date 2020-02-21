using UnityEngine;

public class RandomStartingPoint: ScriptableObject
{    
    public IntRef MapXSize;
    public IntRef MapZSize;
    public MeshHeightMap MeshHeightMap;

    int startingX;
    int startingZ;
    float startingY;

    Vector3 startingPoint;
    
    public Vector3 Build()
    {
        startingX = Random.Range(0, MapXSize.Val);
        startingZ = Random.Range(0, MapZSize.Val);

        startingY = MeshHeightMap.Array[startingX, startingZ];

        startingPoint = new Vector3(startingX, startingY, startingZ);

        return startingPoint;
    }
}
