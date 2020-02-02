using UnityEngine;

public class TestScrollUp : ScriptableObject, IReact
{
    public void React()
    {
        Debug.Log("Scrolled up");
    }
}
