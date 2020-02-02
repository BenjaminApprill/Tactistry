using UnityEngine;

public class TestScrollDown : ScriptableObject, IReact
{
    public void React()
    {
        Debug.Log("Scrolled down");
    }
}
