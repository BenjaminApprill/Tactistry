using OdinSerializer;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputs : SerializedMonoBehaviour
{    
    public MouseButtonDowns MBD_Ref;
    public MouseButtonUps MBU_Ref;
    
    public MouseAxisInputs MAI_Ref;

    float axisValue;    

    void Update()
    {
        for (int i = 0; i < MBD_Ref.ButtonDowns.Length; i++)
        {
            if (Input.GetMouseButtonDown((int)MBD_Ref.ButtonDowns[i].ButtonID))
            {
                for (int j = 0; j < MBD_Ref.ButtonDowns[i].Reactors.Length; j++)
                {
                    MBD_Ref.ButtonDowns[i].Reactors[j].Activate();
                }
            }
        }

        for (int i = 0; i < MBU_Ref.ButtonUps.Length; i++)
        {
            if (Input.GetMouseButtonUp((int)MBU_Ref.ButtonUps[i].ButtonID))
            {
                for (int j = 0; j < MBU_Ref.ButtonUps[i].Reactors.Length; j++)
                {
                    MBU_Ref.ButtonUps[i].Reactors[j].Activate();
                }
            }
        }

        for (int i = 0; i < MAI_Ref.AxisInputs.Length; i++)
        {
            axisValue = Input.GetAxis(MAI_Ref.AxisInputs[i].axisName);

            if(axisValue != 0f)
            {
                MAI_Ref.AxisInputs[i].axisValue.Val = axisValue;

                for (int j = 0; j < MAI_Ref.AxisInputs[i].Reactors.Length; j++)
                {
                    MAI_Ref.AxisInputs[i].Reactors[j]?.Activate();
                }
            }
        }
    }
}
