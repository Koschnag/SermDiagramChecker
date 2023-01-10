namespace DiagramChecker.Results
{
    public interface IResult
    {
        bool IsRight { get; }
        string Annotation { get; set; }
        int MaxPoints { get; set; }
        int Points { get; set; }
    }
}
