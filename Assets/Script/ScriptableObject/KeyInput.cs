using Sirenix.OdinInspector;
using UnityEngine;

public class KeyInput: ScriptableObject
{
    public KeyCode Input;

    [InlineEditor]
    public Reactor[] Reactors;
}
