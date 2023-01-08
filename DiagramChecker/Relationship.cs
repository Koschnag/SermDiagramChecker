namespace DiagramChecker
{
    public class Relationship
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Entity Source { get; set; }
        public Entity Target { get; set; }
    }
}