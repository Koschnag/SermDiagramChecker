using DiagramChecker.Contracts;
using DiagramChecker.Helper;
using DiagramChecker.Results;

namespace DiagramChecker.Comperators
{
    public class ColorComparer : IColorComparer
    {
        private readonly IStringSimilarity stringSimilarity;

        public ColorComparer(IStringSimilarity stringSimilarity)
        {
            this.stringSimilarity = stringSimilarity;
        }

        public IResult Compare(IColor x, IColor y)
        {
            IResult result = new Result();
            result.MaxPoints = 2; //1p for name, 1p for type

            if (stringSimilarity.IsSimilar(x.Name, y.Name))
                result.Points++;
            else
                result.Annotation += "Name is not equal. ";
            if (x.Type == y.Type)
                result.Points++;
            else
                result.Annotation += "Type is not equal. ";
            return result;
        }
    }
}
