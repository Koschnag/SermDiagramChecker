namespace DiagramChecker.Helper
{
    public class StringEqual : IStringSimilarity
    {
        public bool IsSimilar(string target, string solution)
        {
            if (target == solution)
                return true;
            return false;
        }
    }
}
