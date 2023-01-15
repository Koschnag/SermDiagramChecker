namespace SermTreeCore.Contracts
{
    public interface IEdge
    {
        ITreeNode From { get; set; }
        ITreeNode To { get; set; }
        string Type { get; set; }
        IResult? Result { get; set; }
    }
}