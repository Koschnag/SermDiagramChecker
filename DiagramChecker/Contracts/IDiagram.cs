namespace DiagramChecker.Contracts
{
    public interface IDiagram
    {
        IList<INode> StartNodes { get; set; }
    }
}