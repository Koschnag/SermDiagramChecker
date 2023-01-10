using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramChecker.Helper
{
    public interface IStringSimilarity
    {
        bool IsSimilar(string target, string solution);
    }
}
