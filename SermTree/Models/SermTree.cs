using SermTreeCore.Contracts;

namespace SermTreeCore.Models
{
    public class SermTree : ITree
    {
        public SermTree()
        {
            Roots = new List<ITreeNode>();
        }

        string? Name { get; set; }
        public IList<ITreeNode> Roots { get; set; }
        public IResult? Result { get; set; }
    }
}
