namespace DiagramChecker.Results
{
    public class Result : IResult
    {
        public Result()
        {
            Points = 0;
        }

        public Result(string annotation)
        {
            Annotation = annotation;
            Points = 0;
        }

        public Result(int maxPoints)
        {
            MaxPoints = maxPoints;
            Points = 0;
        }
        public bool IsRight => Points == MaxPoints;
        public string Annotation { get; set; }
        public int MaxPoints { get; set; }
        public int Points { get; set; }
    }

}
