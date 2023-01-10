namespace DiagramChecker
{
    public interface INode
    {
        IList<IColor> Attributes { get; set; }
        IList<IEdge> Relationships { get; set; }
    }
}