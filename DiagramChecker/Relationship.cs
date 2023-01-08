namespace DiagramChecker
{
    public class Relationship:IEdge
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public INode From   { get; set; }
        public INode To { get; set; }
    }
}