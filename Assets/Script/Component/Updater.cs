using OdinSerializer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updater : SerializedMonoBehaviour
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
