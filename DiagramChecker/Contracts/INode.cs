namespace DiagramChecker.Contracts
{
    public interface INode
    {
        IList<IColor> Attributes { get; set; }
        IList<IEdge> Relationships { get; set; }
    }
}