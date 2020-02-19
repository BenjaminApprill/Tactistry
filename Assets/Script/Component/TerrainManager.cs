using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public bool newMap;

    [OnValueChanged("MapUpdate", true)]    
    public TerrainSettings Settings;

    [HideIf("@GenMap3D != null")]
    public GenerateMap3D GenMap3D;
    [HideIf("@UpdateMap3D != null")]
    public UpdateMap3D UpdateMap3D;

    void Start()
    {        
        GenMap3D.Build();
    }
    
    void MapUpdate()
    {
        GenMap3D.Build();
        //UpdateMap3D.MapUpdate();
    }
}
