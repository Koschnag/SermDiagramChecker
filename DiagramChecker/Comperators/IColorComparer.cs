using DiagramChecker.Contracts;
using DiagramChecker.Results;

namespace DiagramChecker.Comperators
{
    public interface IColorComparer
    {
        IResult Compare(IColor x, IColor y);
    }
}