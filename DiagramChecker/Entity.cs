namespace DiagramChecker
{
    public class Entity : INode
    {
        IList<SermAttribute> attributes;
        IList<Relationship> relationships;
    }
}