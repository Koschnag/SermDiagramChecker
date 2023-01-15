namespace SermTreeCore.Contracts
{

    public interface ITree
    {
        IList<ITreeNode> Roots { get; set; }
    }
}