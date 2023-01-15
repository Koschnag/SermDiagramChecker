using SermTree.Contracts;

namespace SermTree.Models
{
    public class SermNode : INode
    {
        public string Name { get; set; }
        public IList<IColor> Attributes { get; set; }
        public IList<IEdge> Relationships { get; set; }
    }
}
