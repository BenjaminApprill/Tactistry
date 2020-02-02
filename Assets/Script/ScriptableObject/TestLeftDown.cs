using UnityEngine;

public class TestLeftDown : ScriptableObject, IReact
{
    public void React()
    {
        Debug.Log("Left button down");
    }
}
