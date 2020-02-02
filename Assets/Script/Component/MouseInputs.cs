using OdinSerializer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : SerializedMonoBehaviour
{
    public IUpdate[] Updates;
    
    void Update()
    {
        for (int i = 0; i < Updates.Length; i++)
        {
            Updates[i].Update();
        }
    }
}
