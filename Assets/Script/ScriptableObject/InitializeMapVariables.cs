using UnityEngine;

public class InitializeMapVariables : ScriptableObject, IReact
{
    public IntRef MapXSize;
    public IntRef MapZSize;
    public IntRef MapWidth;
    public IntRef MapHeight;
    public IntRef TerrainChunkSize;
    public IntRef TerrainChunks;

    public void React()
    {
        MapXSize.Val = MapWidth.Val * TerrainChunkSize.Val;
        MapZSize.Val = MapHeight.Val * TerrainChunkSize.Val;
        TerrainChunks.Val = MapWidth.Val * MapHeight.Val;
    }
}
