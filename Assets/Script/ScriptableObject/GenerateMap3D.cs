using Sirenix.OdinInspector;
using UnityEngine;
 
public class GenerateMap3D: ScriptableObject
{
    public IntRef MapWidth_Ref;
    public IntRef MapHeight_Ref;
    public FloatRef TerrainChunkSize_Ref;

    public GenerateTerrainTexture TerrainTexture;

    MeshRenderer renderer;

    [Button]
    public void Build()
    {
        renderer = new MeshRenderer();
        renderer.sharedMaterial.mainTexture = TerrainTexture.Build();
    }
}
