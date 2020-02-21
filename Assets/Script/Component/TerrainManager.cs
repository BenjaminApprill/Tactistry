using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    [OnValueChanged("MapUpdate", true)]    
    public TerrainSettings Settings;

    [OnValueChanged("MapUpdate", true)]
    [InlineEditor]
    public TerrainCells TerrainCells;
    
    [HideIf("@UpdateMap3D != null")]
    public UpdateMap3D UpdateMap3D;

    void MapUpdate()
    {        
        UpdateMap3D.MapUpdate();
    }
}
