using Sirenix.OdinInspector;
using UnityEngine;
 
public class LockDragScroll: ScriptableObject, IReact
{
    [InlineEditor]
    public UsesMouseX UMX_Ref;
    [InlineEditor]
    public UsesMouseY UMY_Ref;
    [InlineEditor]
    public UpdateCameraX UCX_Ref;
    [InlineEditor]
    public UpdateCameraZ UCZ_Ref;

    public void React()
    {
        UMX_Ref.Reactions.Remove(UCX_Ref);
        UMY_Ref.Reactions.Remove(UCZ_Ref);
    }
}
