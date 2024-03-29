﻿using DiagramChecker.Comperators;
using DiagramChecker.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramChecker.Contracts
{
    public interface IEdge
    {
        INode From { get; set; }
        INode To { get; set; }
        IColor Color { get; set; }
        IResult? Result { get; set; }

        void Check(IEdge? other, IColorComparer comparer);
    }
}
