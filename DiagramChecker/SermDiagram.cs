using DiagramChecker.Contracts;

namespace DiagramChecker
{
    public class  SermDiagram:IDiagram
    {
        public SermDiagram()
        {
            StartNodes = new List<INode>();
        }

        public IList<INode> StartNodes { get; set; }
     }
}