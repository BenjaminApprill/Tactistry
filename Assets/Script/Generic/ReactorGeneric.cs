using OdinSerializer;
using System.Collections.Generic;
 
public abstract class Reactor<T>: SerializedScriptableObject
{
    public List<IReact<T>> Reactions;

    public void Activate(T catalyst)
    {
        foreach (var reactive in Reactions)
        {
            reactive.React(catalyst);
        }
    }
}
