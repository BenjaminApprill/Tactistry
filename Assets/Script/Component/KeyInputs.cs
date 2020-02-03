using OdinSerializer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInputs : SerializedMonoBehaviour
{
    public KeyDownInputs KDI_Ref;
    public KeyUpInputs KUI_Ref;
    
    void Update()
    {
        for (int i = 0; i < KDI_Ref.KeyDowns?.Length; i++)
        {
            if (Input.GetKeyDown(KDI_Ref.KeyDowns[i].Input))
            {
                for (int j = 0; j < KDI_Ref.KeyDowns[i].Reactors.Length; j++)
                {
                    KDI_Ref.KeyDowns[i].Reactors[j].Activate();
                }
            }
        }

        for (int i = 0; i < KUI_Ref.KeyUps?.Length; i++)
        {
            if (Input.GetKeyUp(KUI_Ref.KeyUps[i].Input))
            {
                for (int j = 0; j < KUI_Ref.KeyUps[i].Reactors.Length; j++)
                {
                    KUI_Ref.KeyUps[i].Reactors[j].Activate();
                }
            }
        }
    }
}
