using SermTreeCore.Contracts;
using System.ComponentModel.DataAnnotations;

namespace SermTreeCore.Models
{
    public class SermTree : ITree, ICheckable
    {
        public SermTree()
        {
            Roots = new List<ITreeNode>();
        }

        [Key]
        int ID { get; set; }
        string? Name { get; set; }
        public IList<ITreeNode> Roots { get; set; }
        
        public IList<IResult> GetResult(INode referenceNode)
        {
            
        }
    }
}
