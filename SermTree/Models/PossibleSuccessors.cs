using SermTreeCore.Contracts;
namespace SermTreeCore.Models
{
    public class PossibleSuccessors : IPossibleSuccessors
    {
        //Constructure
        public PossibleSuccessors()
        {
            Relationships = new List<IEdge>();
        }

        public IList<IEdge> Relationships { get; set; }
        public IResult? Result { get; set; }
    }
}
