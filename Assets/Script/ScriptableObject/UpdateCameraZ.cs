using UnityEngine;

public class UpdateCameraZ : ScriptableObject, IReact
{
    public FloatRef MousePositionY;
    public FloatRef DragScrollSpeed;

    Vector3 currentPos;
    Vector3 newPos;
    float newZ;

    public void React()
    {
        currentPos = Camera.main.transform.position;
        newZ = currentPos.z + (MousePositionY.Val * DragScrollSpeed.Val);
        newPos = new Vector3(currentPos.x, currentPos.y, newZ);
        Camera.main.transform.position = newPos;
    }
}
