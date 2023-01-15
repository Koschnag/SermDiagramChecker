namespace DiagramChecker.Contracts
{
    public interface ITree
    {
        INode Root { get; set; }
    }

    public interface ITreeNode
    {
        IColor Color { get; set; }
        IList<ITreeNode> Children { get; set; }
    }


}