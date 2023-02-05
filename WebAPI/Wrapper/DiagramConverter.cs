using WebAPI.DTO.Diagram;

namespace WebAPI.Wrapper
{
    public class DiagramConverter
    {
        public static async Task<Diagram> ConvertToTree(Diagram inputObject)
        {
            var output = new SermTreeCore.Models.SermTree();
            var RootIds = FindRootIds(inputObject);

            return diagram;
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
            return allEndId;
        }
    }
}
