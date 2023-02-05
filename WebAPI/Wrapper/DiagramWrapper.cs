using SermTreeCore.Contracts;
using SermTreeCore.Helper;
using SermTreeCore.Models;
using System.Runtime.CompilerServices;
using WebAPI.DTO.Diagram;

namespace WebAPI.Wrapper
{
    public static class DiagramWrapper
    {

        //Asynch method
        public static async Task<Diagram> ConvertToTree(Diagram inputObject)
        {
            var output = new SermTreeCore.Models.SermTree();
            



            return diagram;
        }

        //Write a Methode which convert a Diagram to a SermTree
        

        private static IList<SermTreeNode> FindRootNodes(Diagram inputObject)
        {
            var rootNodes = new List<SermTreeNode>();

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

            foreach (var id in allRootId)
            {
                Entity entity = CreateEntityFromId(inputObject, id);
                SermTreeNode node = CreateNodeFromEntity(entity);

                var nextIds = from x in inputObject.connections
                              where x.startEntity == id
                              select x.endEntity;

                CreateSuccessorsFromNode(inputObject, node, nextIds);
                rootNodes.Add(node);
            }
            return rootNodes;
        }

        private static void CreateSuccessorsFromNode(Diagram inputObject, SermTreeNode node, IEnumerable<int> nextIds)
        {
            //Add Successors
            var nextEntitys = CreateNextEntity(inputObject, nextIds);
            foreach (var next in nextEntitys)
            {
                var relationShip = new SermRelationship();
                relationShip.From = node;
                relationShip.To = next;
                //Type is missing      
                node.Successor.Relationships.Add(relationShip);
            }
        }

        private static List<SermTreeNode> CreateNextEntity(Diagram inputObject, IEnumerable<int> nextIds)
        {
            //Create a List of Nodes
            var result = new List<SermTreeNode>();
            foreach (var nextId in nextIds)
            {
                var nextEntity = CreateEntityFromId(inputObject, nextId);
                var nextNode = CreateNodeFromEntity(nextEntity);
                result.Add(nextNode);
            }
            return result;
        }

        private static Entity CreateEntityFromId(Diagram inputObject, int id)
        {
            return (from x in inputObject.entities where x.id == id select x).ToList()[0];
        }

        private static SermTreeNode CreateNodeFromEntity(Entity entity)
        {
            var node = new SermTreeNode();
            node.Name = entity.entityName;
            node.Attributes = ConvertAttributes(entity.attributes);
            node.Successor = new PossibleSuccessors();
            return node;
        }

        private static IList<IColor> ConvertAttributes(DTO.Diagram.Attribute[] attributes)
        {
            if (attributes.Length == 0)
            {
                throw new ArgumentNullException("attributes");
            }
            
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

        private static IList<IEdge> ConvertConnections(Connection[] connections, int id
        {
            var y = from x in connections where x.startEntity == id select x;
            var result = new List<IEdge>();
            foreach (var connection in y)
            {
                var element = new SermRelationship();
                element.From =  connection.startEntity;
                element.To = connection.endEntity;
                element.Target = connection.endEntity;
                result.Add(element);
            }
        }
    }
}
