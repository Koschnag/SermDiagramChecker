using SermTreeCore.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SermTreeCore.Models
{
    public class SermAttribute : IColor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public IResult? Result { get; set; }
    }
}
