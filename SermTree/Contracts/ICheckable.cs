using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SermTreeCore.Contracts
{
    public interface ICheckable
    {
        IList<IResult> GetResult(INode referenceNode);
    }
}
