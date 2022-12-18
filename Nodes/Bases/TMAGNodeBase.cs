using XNode;

public class TMAGNodeBase : Node
{
    protected virtual string NodeName { get; }

    protected void Reset()
    {
        name = NodeName;
    }
}