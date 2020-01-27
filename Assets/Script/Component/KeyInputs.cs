using OdinSerializer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : SerializedMonoBehaviour
{
    public ITrigger[] KeyDowns;
    public ITrigger[] KeyUps;
    
    void Update()
    {
        for (int i = 0; i < KeyDowns.Length; i++)
        {
            if (Input.GetKeyDown(KeyDowns[i].trigger))
            {
                KeyDowns[i].Trigger();
            }
        }
        for (int i = 0; i < KeyUps.Length; i++)
        {
            if(Input.GetKeyUp(KeyUps[i].trigger))
            {
                KeyUps[i].Trigger();
            }
        }
    }
}
