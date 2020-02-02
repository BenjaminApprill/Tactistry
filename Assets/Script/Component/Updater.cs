using OdinSerializer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Updater : SerializedMonoBehaviour
{
    public GameUpdates GU_Ref;

    void Update()
    {
        for (int i = 0; i < GU_Ref.Updates.Length; i++)
        {
            GU_Ref.Updates[i].Update();
        }
    }
}
