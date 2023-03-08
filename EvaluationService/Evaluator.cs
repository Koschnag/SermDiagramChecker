using SermTreeCore.Contracts;

namespace EvaluationService
{
    public static class Evaluator
    {
        public static ITree Evaluate(ITree subject, ITree solution)
        {
            if (subject == null)
            {
                throw new ArgumentNullException(nameof(subject));
            }

            if (solution == null)
            {
                throw new ArgumentNullException(nameof(solution));
            }

            var result = new Tree();
            result.Name = subject.Name;
            result.Roots = new List<ITreeNode>();
            foreach (var root in subject.Roots)
            {
                var solutionRoot = solution.Roots.FirstOrDefault(r => r.Name == root.Name);
                if (solutionRoot == null)
                {
                    result.Result = new Result();
                    result.Result.Annotation = "Missing root: " + root.Name + ".";
                    continue;
                }
                result.Roots.Add(Evaluate(root, solutionRoot));
            }

            return result;


        }


    }
}
