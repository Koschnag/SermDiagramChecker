using SermTreeCore.Contracts;
using SermTreeCore.Models;
using WebAPI.DTO.Diagram;

namespace WebAPI.Wrapper
{
    public class DiagramConverter
    {
        public static ITree ConvertToTree(Diagram inputObject)
        {
            var RootIds = FindRootIds(inputObject);

            var tree = new SermTree();
            
            foreach (var id in RootIds)
            {
                Entity entity = CreateEntityFromId(inputObject, id);
                SermTreeNode node = CreateNodeFromEntity(inputObject, entity);
                tree.Roots.Add(node);
            }
            return tree;
        }

        private static SermTreeNode CreateNodeFromEntity(Diagram inputObject, Entity entity)
        {
            var node = new SermTreeNode();
            node.Name = entity.entityName;
            node.Attributes = ConvertAttributes(entity.attributes);
            var nextIds = FindNextIds(inputObject, entity);
            foreach (var nextId in nextIds)
            {
                var nextEntity = CreateEntityFromId(inputObject, nextId);
                var nextNode = CreateNodeFromEntity(inputObject, nextEntity);
                var relationShip = new SermRelationship();
                relationShip.From = node;
                relationShip.To = nextNode;
                node.Successor.Relationships.Add(relationShip);
            }
            return node;
        }

        private static IList<int> FindNextIds(Diagram inputObject, Entity entity)
        {
            var nextIds = (from x in inputObject.connections
                           where x.startEntity == entity.id
                           select x.endEntity).ToList();
            return nextIds;
        }

        private static IList<IColor> ConvertAttributes(DTO.Diagram.Attribute[] attributes)
        {
            var result = new List<IColor>();

            foreach (var attribute in attributes)
            {
                var element = new SermAttribute();
                element.Type = attribute.type.ToString();
                element.Name = attribute.name;
                element.Description = "";
                result.Add(element);
            }
            return result;
        }


        private static Entity CreateEntityFromId(Diagram inputObject, int id)
        {
            return (from x in inputObject.entities where x.id == id select x).ToList()[0];
        }

        private static List<int> FindRootIds(Diagram inputObject)
        {
            var allEndId = new List<int>();
            foreach (var con in inputObject.connections)
            {
                if (!allEndId.Contains(con.endEntity))
                {
                    allEndId.Add(con.endEntity);
                }
            }

            var allRootId = new List<int>();
            foreach (var entity in inputObject.entities)
            {
                if (!allEndId.Contains(entity.id))
                {
                    allRootId.Add(entity.id);
                }
            }
            return allRootId;
        }
    }
}
