using UnityEngine;

public interface ITrigger
{
    KeyCode trigger { get; }

    void Trigger();
}
