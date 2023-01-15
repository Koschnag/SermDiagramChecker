namespace SermTree.Contracts
{
    public interface ITreeNode
    {
        IColor Color { get; set; }
        IList<INode> Children { get; set; }
    }
}