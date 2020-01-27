using UnityEngine;
 
public class DecrementNewUnitCount: ScriptableObject, IReact
{
    public IntRef NewUnitCount;

    public void React()
    {
        NewUnitCount.Val--;
    }
}
