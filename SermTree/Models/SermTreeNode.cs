using SermTree.Contracts;

namespace SermTree.Models
{
    public class SermTreeNode : ITreeNode
    {
        public IColor Color{get; set;}
        public IList<INode> Children { get; set; }
    }
}
