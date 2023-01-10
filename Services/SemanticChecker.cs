using DiagramChecker.Contracts;

namespace Services
{
    public class SemanticChecker
    {
        public void Check(INode node, INode solution)
        {
            //Check Edges
            if (node.Relationships.Count != solution.Relationships.Count)
            {
                throw new Exception("Relationships count mismatch");
            }

            foreach (var relationship in node.Relationships)
            {
                var solutionRelationship = solution.Relationships.FirstOrDefault(r => r.Name == relationship.Name);
                if (solutionRelationship == null)
                {
                    throw new Exception("Relationship not found");
                }

                if (relationship.To.Equals(solutionRelationship.To))
                {
                    throw new Exception("Relationship target mismatch");
                }
            }

            //Check Color
            if (node.Attributes.Count != solution.Attributes.Count)
            {
                throw new Exception("Node " + node + " has " + node.Attributes.Count + " attributes, but should have " + solution.Attributes.Count);
            }

            foreach (var attribute in node.Attributes)
            {
                if (!solution.Attributes.Contains(attribute))
                {
                    throw new Exception("Node " + node + " has attribute " + attribute + " which is not in the solution");
                }

                //Select all nodes in solution which are not contained in the node
                var nodesNotInNode = solution.Attributes.Where(n => !node.Attributes.Contains(n));
                if (nodesNotInNode.Count() > 0)
                {
                    throw new Exception("Node " + node + " is missing attributes " + string.Join(", ", nodesNotInNode));
                }
            }
        }
    }
}