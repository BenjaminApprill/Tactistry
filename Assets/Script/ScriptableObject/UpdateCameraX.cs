using UnityEngine;

public class UpdateCameraX : ScriptableObject, IReact
{
    public FloatRef MousePositionX;
    public FloatRef DragScrollSpeed;

    Vector3 currentPos;
    Vector3 newPos;
    float newX;

    public void React()
    {
        currentPos = Camera.main.transform.position;
        newX = currentPos.x + (-1*MousePositionX.Val * DragScrollSpeed.Val);
        newPos = new Vector3(newX, currentPos.y, currentPos.z);
        Camera.main.transform.position = newPos;
    }
}
