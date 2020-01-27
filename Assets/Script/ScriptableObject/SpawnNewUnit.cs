using UnityEngine;
 
public class SpawnNewUnit: ScriptableObject, IReact
{
    public GameObject unitPrefab;
    public Transform parent;

    public void React()
    {
        Instantiate(unitPrefab, Vector3.zero, Quaternion.identity, parent);
    }
}
