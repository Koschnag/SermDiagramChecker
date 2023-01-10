using DiagramChecker;

namespace Services
{
    public interface IEdgeSynthaxChecker
    {
        bool Check(IEdge testTarget);
    }
}