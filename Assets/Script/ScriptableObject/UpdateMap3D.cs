using Sirenix.OdinInspector;
using UnityEngine;
 
public class UpdateMap3D: ScriptableObject
{
    public InitializeMapVariables InitializeMapVariables;
    public GenerateMap3D GenerateMap3D;

    public void MapUpdate()
    {
        InitializeMapVariables.React();
        GenerateMap3D.React();
    }
}
