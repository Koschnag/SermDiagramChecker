using SermTreeCore.Contracts;

namespace SermTreeCore.Models
{
    public class SermTreeNode : ITreeNode
    {
        //Constructor
        public SermTreeNode()
        {
            Attributes = new List<IColor>();
            Successor = new PossibleSuccessors();
        }

        public string Name { get; set; }
        public IList<IColor> Attributes { get; set; }
        public IPossibleSuccessors Successor { get; set; }
        public IResult? Result { get; set; }
    }
}
