namespace SermTreeCore.Contracts
{
    public interface IEdge
    {
        INode From { get; set; }
        INode To { get; set; }
        IColor Color { get; set; }
        IResult? Result { get; set; }
    }
}