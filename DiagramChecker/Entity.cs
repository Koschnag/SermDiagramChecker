namespace DiagramChecker
{
    public class Entity : INode
    {
        public IList<IColor> Attributes { get; set; }
        public IList<IEdge> Relationships { get; set; }
    }
}