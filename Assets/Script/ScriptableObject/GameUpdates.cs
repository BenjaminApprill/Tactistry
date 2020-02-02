using OdinSerializer;
using Sirenix.OdinInspector;
using UnityEngine;
 
public class GameUpdates: OdinSerializer.SerializedScriptableObject
{
    [InlineEditor]
    public IUpdate[] Updates;
}
