using System.Collections.Generic;
using UnityEngine;
 
public class BuildTerrainOffsets: ScriptableObject
{
    List<Vector3> offsets;

    float halfChunkSize;

    Vector3 one;
    Vector3 two;
    Vector3 three;
    Vector3 four;

    public List<Vector3> Build(float terrainChunkSize)
    {
        offsets = new List<Vector3>();

        halfChunkSize = terrainChunkSize / 2f;

        one = Vector3.zero;
        one.x -= halfChunkSize;
        one.z -= halfChunkSize;

        two = Vector3.zero;
        two.x -= halfChunkSize;
        two.z += halfChunkSize;

        three = Vector3.zero;
        three.x += halfChunkSize;
        three.z += halfChunkSize;

        four = Vector3.zero;
        four.x += halfChunkSize;
        four.z -= halfChunkSize;

        offsets.Add(one);
        offsets.Add(two);
        offsets.Add(three);
        offsets.Add(four);

        return offsets;
    }
}
