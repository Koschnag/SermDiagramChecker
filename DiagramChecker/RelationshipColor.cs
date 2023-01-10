using DiagramChecker.Contracts;
using DiagramChecker.Results;

namespace DiagramChecker
{
    public class RelationshipColor : IColor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public IResult? Result { get; set; }
    }
}