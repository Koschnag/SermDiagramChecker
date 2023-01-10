using DiagramChecker.Contracts;
using DiagramChecker.Results;

namespace DiagramChecker
{
    public class Entity : INode
    {
        public IList<IColor> Attributes { get; set; }
        public IList<IEdge> Relationships { get; set; }
        public IResult? Result { get; set; }

        public int CompareTo(INode? other)
        {
            //Check for null
            if (other == null)
            {
                return 1;
            }
               
        }
    }
}