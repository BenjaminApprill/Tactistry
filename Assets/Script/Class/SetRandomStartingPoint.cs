using Sirenix.OdinInspector;
using UnityEngine;

public class SetRandomStartingPoint : ScriptableObject, IReact
{
    public GameObject Capital;
    public Camera MainCamera;

    [InlineEditor]
    public FloatRef CameraStartScale;

    public RandomStartingPoint RandomStartingPoint;

    Vector3 capitalStartingPosition;
    Vector3 cameraStartingPosition;

    public void React()
    {
        capitalStartingPosition = RandomStartingPoint.Build();
        cameraStartingPosition = capitalStartingPosition;

        cameraStartingPosition.z += -0.5f * CameraStartScale.Val;
        cameraStartingPosition.y += CameraStartScale.Val;

        Capital.transform.position = capitalStartingPosition;
        MainCamera.transform.position = cameraStartingPosition;
    }
}
