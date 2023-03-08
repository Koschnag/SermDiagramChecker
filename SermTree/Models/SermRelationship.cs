using SermTreeCore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SermTreeCore.Models
{
    public class SermRelationship : IEdge
    {
        public ITreeNode From { get; set; }
        public ITreeNode To { get; set; }
        public string Type { get; set; }
        public IList<IResult> Result { get; set; }
    }
}
