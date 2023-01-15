using SermTreeCore.Contracts;
using SermTreeCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SermTreeCore.Helper
{
    public static class TreeNodeConnector
    {
        public static IEdge Connect(ITreeNode from, ITreeNode to, string type)
        {
            return new SermRelationship()
            {
                From = from,
                To = to,
                Type = type
            };
        }
    }
}
