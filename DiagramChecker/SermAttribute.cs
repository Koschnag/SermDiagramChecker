using DiagramChecker.Comperators;
using DiagramChecker.Contracts;
using DiagramChecker.Results;

namespace DiagramChecker
{
    public class SermAttribute : IColor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public IResult? Result { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + ", Type: " + Type;
        }
    }
}