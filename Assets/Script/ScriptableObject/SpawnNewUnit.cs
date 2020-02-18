using OdinSerializer;
using UnityEngine;
 
public class SpawnNewUnit: SerializedScriptableObject, IReact
{
    public GameObject unitPrefab;
    [OdinSerialize]
    public Transform parent;

    public void React()
    {
        Instantiate(unitPrefab, Vector3.zero, Quaternion.identity, parent);
    }
}
