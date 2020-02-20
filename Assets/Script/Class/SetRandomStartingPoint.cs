using Sirenix.OdinInspector;
using UnityEngine;

public class SetRandomStartingPoint : IReact
{
    public GameObject Capital;
    public Camera MainCamera;

    [InlineEditor]
    public FloatRef CameraStartScale;

    Vector3 capitalStartingPosition;
    Vector3 cameraStartingPosition;

    public void React()
    {
        capitalStartingPosition = Vector3.zero;
        cameraStartingPosition = capitalStartingPosition;
        cameraStartingPosition.x += -1f * CameraStartScale.Val;
        cameraStartingPosition.y += CameraStartScale.Val;

        Capital.transform.position = capitalStartingPosition;
        MainCamera.transform.position = cameraStartingPosition;
    }
}
