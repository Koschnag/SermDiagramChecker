using DiagramChecker.Contracts;

namespace DiagramChecker
{
    public class  SermDiagram:IDiagram
    {
       public IList<INode> StartNodes { get; set; }
     }
}