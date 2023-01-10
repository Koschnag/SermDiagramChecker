namespace DiagramChecker.Contracts
{
    public interface INode: IComparable<INode>
    {
        IList<IColor> Attributes { get; set; }
        IList<IEdge> Relationships { get; set; }
    }
}