using UnityEngine;
 
public class LockDragScroll: ScriptableObject, IReact
{
    public UsesMouseX UMX_Ref;
    public UsesMouseY UMY_Ref;
    public UpdateCameraX UCX_Ref;
    public UpdateCameraZ UCZ_Ref;

    public void React()
    {
        UMX_Ref.Reactions.Remove(UCX_Ref);
        UMY_Ref.Reactions.Remove(UCZ_Ref);
    }
}
