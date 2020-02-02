using UnityEngine;
 
public class DecrementNewUnitCount: ScriptableObject, IReact
{
    public IntRef NewUnitCount;

    public void React()
    {
        if(NewUnitCount.Val > 0)
        {
            NewUnitCount.Val--;
        }
    }
}
