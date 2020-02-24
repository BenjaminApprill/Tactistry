using Sirenix.OdinInspector;
using System;

[Serializable]
public class TerrainSettings
{
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
    public FloatRef TerrainHeightAdjustment;
    [InlineEditor]    
    public FloatRef OffsetX;
    [InlineEditor]    
    public FloatRef OffsetZ;
    [InlineEditor]
    public Vector2Ref TestRiverStart;
    [InlineEditor]
    public IntRef TestRiverLength;
    [InlineEditor]
    public HeightEvaluationCurve HeightEvaluationCurve;
}
