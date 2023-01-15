namespace SermTreeCore.Contracts
{
    public interface ITreeNode
    {
        IList<IColor> Attributes { get; set; }
        string Name { get; set; }
        IPossibleSuccessors Successor { get; set; }
    }
}