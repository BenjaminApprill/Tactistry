using UnityEngine;
 
public class IncrementNewUnitCount: ScriptableObject, IReact
{
    public IntRef NewUnitCount;

    public void React()
    {
        NewUnitCount.Val++;
    }
}
