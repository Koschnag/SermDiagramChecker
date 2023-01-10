using DiagramChecker;

namespace Services
{
    public class EdgeSynthaxChecker : IEdgeSynthaxChecker
    {
        public bool Check(IEdge testTarget)
        {
            //No cyclic dependency
            if (testTarget.To == testTarget)
            {
                return false;
            }
            return true;
        }
    }
}