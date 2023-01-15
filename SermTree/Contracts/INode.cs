namespace SermTree.Contracts
{
    public interface INode
    {
        string Name { get; set; }
        IList<IColor> Attributes { get; set; }
        IList<IEdge> Relationships { get; set; }
    }
}