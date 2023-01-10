using DiagramChecker.Contracts;

namespace Services
{
    public interface IEdgeSynthaxChecker
    {
        bool Check(IEdge testTarget);
    }
}