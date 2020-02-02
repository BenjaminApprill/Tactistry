using OdinSerializer;
using Sirenix.OdinInspector;
using System.Collections.Generic;
 
public abstract class Reactor : OdinSerializer.SerializedScriptableObject
{
    [InlineEditor]
    public List<IReact> Reactions;

    public void Activate()
    {
        foreach (var reactive in Reactions)
        {
            reactive.React();
        }
    }
}
