using Sirenix.OdinInspector;
using UnityEngine;

public class MouseButtonInput: ScriptableObject
{
    public MouseButtonEnum ButtonID;

    [InlineEditor]
    public Reactor[] Reactors;
}
