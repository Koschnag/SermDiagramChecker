using SermTreeCore.Contracts;
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

            foreach(var id in allRootId)
            {
                var entity = (from x in inputObject.entities where x.id == id select x).ToList()[0];
                var node = new SermTreeNode();
                node.Name= entity.entityName;
                node.Attributes = ConvertAttributes(entity.attributes);
                node.Successor = ConvertConnections(inputObject.connections);
            
            }


            return rootNodes;
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

        private static IList<IEdge> ConvertConnections(Connection[] connections)
        {
            
        }
    }
}
