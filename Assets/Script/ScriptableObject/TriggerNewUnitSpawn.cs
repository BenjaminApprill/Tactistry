using UnityEngine;
 
public class TriggerNewUnitSpawn: ScriptableObject, ITrigger
{
    public KeyCode TriggerKey;
    public KeyCode trigger { get => TriggerKey; }

    public IntRef NewUnitCount;

    public Reactor NewUnitSpawned;

    public void Trigger()
    {
        if(NewUnitCount.Val > 0)
        {
            NewUnitSpawned.Activate();
        }
    }
}
