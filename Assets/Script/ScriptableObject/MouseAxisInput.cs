using Sirenix.OdinInspector;
using UnityEngine;
 
public class MouseAxisInput: ScriptableObject
{
    public MouseAxisEnum axis;

    public string axisName
    {
        get
        {
            string name = "";

            switch (axis)
            {
                case MouseAxisEnum.ScrollWheel:
                    name = "Mouse ScrollWheel";
                    break;
                case MouseAxisEnum.xAxis:
                    name = "Mouse X";
                    break;
                case MouseAxisEnum.yAxis:
                    name = "Mouse Y";
                    break;
            }

            return name;
        }
    }

    [InlineEditor]
    public Reactor[] Reactors;
}
