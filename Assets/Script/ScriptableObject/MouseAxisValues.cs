using UnityEngine;

public class MouseAxisValues: ScriptableObject
{
    float val;

    public float axisX()
    {
        //Mouse is moving left
        if(Input.GetAxis("Mouse X") < 0)
        {
            val = Input.GetAxis("Mouse X");
        }

        //Mouse is moving right
        if (Input.GetAxis("Mouse X") > 0)
        {
            val = Input.GetAxis("Mouse X");
        }

        return val;
    }
}
