namespace DiagramChecker.Results
{
    public interface IResult
    {
        string Annotation { get; set; }
        int MaxPoints { get; set; }
        int Points { get; set; }
    }
}
