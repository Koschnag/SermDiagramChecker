using DiagramChecker.Comperators;
using DiagramChecker.Contracts;
using DiagramChecker.Results;

namespace DiagramChecker
{
    public class Relationship : IEdge, ICheckable
    {
        public Relationship(INode besitzer, INode hund)
        {
            From = besitzer;
            To = hund;
        }

        public INode From { get; set; }
        public INode To { get; set; }
        public IColor Color { get; set; }
        public IResult? Result { get; set; }

        public void Check(IEdge? other, IColorComparer comparer)
        {
            var result = new Result(1);   
            if (other == null)
            {
                result.Annotation = "Relationship is null";
                return;
            }
            if (To != other.To)
            {
                result = new Result("Relationship target node is not equal");
                return;
            }
            Color.Result = comparer.Compare(Color, other.Color);
            Result = result;
        }

        public override string ToString()
        {
            return "From: " + From.ToString() + ", To:   " + To.ToString() + ", Color:   " + Color.ToString();
        }
    }
}