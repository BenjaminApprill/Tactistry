using OdinSerializer;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialize : MonoBehaviour
{
    [InlineEditor]
    public Reactor InitialReactor;

    void Start()
    {
        InitialReactor.Activate();
    }
}
