using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    public bool newMap;

    [OnValueChanged("MapUpdate", true)]
    public TerrainDataModel TerrainData;

    [Required]
    public GenerateMap3D GenMap3D;
    [Required]
    public UpdateMap3D UpdateMap3D;
     
    void Start()
    {
        if (newMap)
        {
            GenMap3D.Build(TerrainData);
        }
    }
    
    void MapUpdate()
    {
        UpdateMap3D.MapUpdate(TerrainData);
    }
}
