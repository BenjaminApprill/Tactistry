using UnityEngine;

public class TestLeftUp : ScriptableObject, IReact
{
    public void React()
    {
        Debug.Log("Left button up");
    }
}
