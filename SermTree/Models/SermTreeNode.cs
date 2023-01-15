﻿using SermTreeCore.Contracts;

namespace SermTreeCore.Models
{
    public class SermTreeNode : ITreeNode
    {
        public string Name { get; set; }
        public IList<IColor> Attributes { get; set; }
        public IPossibleSuccessors Successor { get; set; }
        public IResult? Result { get; set; }
    }
}
