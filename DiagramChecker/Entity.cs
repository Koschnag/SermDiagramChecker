using DiagramChecker.Comperators;
using DiagramChecker.Contracts;
using DiagramChecker.Results;
using System.Drawing;

namespace DiagramChecker
{
    public class Entity : INode
    {
        public IList<IColor> Attributes { get; set; }
        public IList<IEdge> Relationships { get; set; }
        public IResult? Result { get; set; }

        public void Check(INode other, IColorComparer colorComparer)
        {
            Result = new Result();
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            //Check if my entity has more attributes
            foreach (var attribute in Attributes)
            {
                var otherAttribute = other.Attributes.FirstOrDefault(a => colorComparer.Compare(a, attribute).IsRight);
                if (otherAttribute == null)
                {
                    Result.Annotation+=("Attribute is missing in the solution: "+attribute.ToString()+".");
                    continue;
                }
                attribute.Result = colorComparer.Compare(attribute, otherAttribute);
            }

            //Check if the other entity has more attributes
            foreach (var attribute in other.Attributes)
            {
                if (Attributes.FirstOrDefault(a => colorComparer.Compare(a, attribute).IsRight) == null)
                {
                    Result.Annotation+=("Missing attribute: "+attribute.ToString()+".");
                }
            }

            //Check if my entity has more relationships
            foreach (var relationship in Relationships)
            {
                var otherRelationship = other.Relationships.FirstOrDefault(r => r.To == relationship.To);
                if (otherRelationship == null)
                {
                    relationship.Result.Annotation = "Relationship is missing in the solution: " + relationship.ToString() + ".";
                    continue;
                }
                relationship.Check(otherRelationship, colorComparer);
            }

            //Check if my entity is missing relationships
            foreach (var relationship in other.Relationships)
            {
                if (Relationships.FirstOrDefault(r => r.To == relationship.To) == null)
                {
                    Result.Annotation+="Missing relationship: " + relationship + ".";
                }
            }

        }
    }
}