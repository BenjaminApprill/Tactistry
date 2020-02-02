using Sirenix.OdinInspector;
using UnityEngine;

public class NewUnitTimer: ScriptableObject, IUpdate
{
    public FloatRef NewUnitSpawnLimiter;
    float currentTimer;

    [InlineEditor]
    public Reactor NewUnitAdded;

    public void Update()
    {
        currentTimer -= Time.deltaTime;

        if(currentTimer <= 0f)
        {
            currentTimer = NewUnitSpawnLimiter.Val;

            NewUnitAdded.Activate();
        }
    }
}
