using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public bool newMap;

    [InlineEditor]
    public IntRef MapWidth;
    [InlineEditor]
    public IntRef MapHeight;
    [InlineEditor]
    public IntRef MapSize;
    [InlineEditor]
    public IntRef TerrainChunkSize;
    [InlineEditor]
    public IntRef NoisePasses;
    [InlineEditor]
    public FloatRef NoiseScale;
    [InlineEditor]
    public FloatRef Isolation;
    [InlineEditor]
    public FloatRef Constriction;
    [InlineEditor]
    public FloatRef OffsetX;
    [InlineEditor]
    public FloatRef OffsetZ;

    [HideIf("@GenMap3D != null")]
    public GenerateMap3D GenMap3D;
    [HideIf("@UpdateMap3D != null")]
    public UpdateMap3D UpdateMap3D;
     
    void Start()
    {
        //if (newMap)
        //{
        //    GenMap3D.Build();
        //}
        GenMap3D.Build();
    }
    
    void MapUpdate()
    {
        //UpdateMap3D.MapUpdate();
    }
}
