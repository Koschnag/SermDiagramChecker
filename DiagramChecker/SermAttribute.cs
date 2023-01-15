using DiagramChecker.Comperators;
using DiagramChecker.Contracts;
using DiagramChecker.Results;

namespace DiagramChecker
{
    public class SermAttribute : IColor
    {
        public SermAttribute(string name, string type)
        {
            Name = name;
            Type = type;
            Result = new Result();
        }

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