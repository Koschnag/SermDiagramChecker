namespace SermTreeCore.Contracts
{
    public interface IResult
    {
        IList<IResult> SubResults { get; set; }
        bool IsRight { get; }
        IList<string> Annotation { get; set; }
        int MaxPoints { get; set; }
        int Points { get; set; }
    }

}