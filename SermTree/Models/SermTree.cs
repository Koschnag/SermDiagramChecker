using SermTreeCore.Contracts;

namespace SermTreeCore.Models
{
    public class SermTree : ITree
    {
        string? Name { get; set; }
        public ITreeNode Root { get; set; }
        public IResult? Result { get; set; }
    }
}
