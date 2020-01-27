using OdinSerializer;
using System.Collections.Generic;
 
public abstract class Reactor: SerializedScriptableObject
{
    public List<IReact> Reactions;

    public void Activate()
    {
        foreach (var reactive in Reactions)
        {
            reactive.React();
        }
    }
}
