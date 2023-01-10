using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramChecker
{
    public interface IEdge
    {
        INode From { get; set; }
        INode To { get; set; }
        string Name { get; set; }
    }
}
