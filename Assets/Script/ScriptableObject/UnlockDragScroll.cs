using UnityEngine;

public class UnlockDragScroll : ScriptableObject, IReact
{
    public UsesMouseX UMX_Ref;
    public UsesMouseY UMY_Ref;
    public UpdateCameraX UCX_Ref;
    public UpdateCameraZ UCZ_Ref;

    public void React()
    {
        UMX_Ref.Reactions.Add(UCX_Ref);
        UMY_Ref.Reactions.Add(UCZ_Ref);
    }
}
