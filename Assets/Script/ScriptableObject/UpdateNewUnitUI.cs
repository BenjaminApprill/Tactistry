using OdinSerializer;
using UnityEngine;
using UnityEngine.UI;

public class UpdateNewUnitUI : SerializedScriptableObject, IReact
{
    public GameObject NewUnitCountUI;
    public IntRef NewUnitCount;

    public void React()
    {
        NewUnitCountUI.GetComponent<Text>().text = "New Units: " + NewUnitCount.Val.ToString();
    }
}
