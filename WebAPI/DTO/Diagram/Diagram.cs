namespace WebAPI.DTO.Diagram
{
    public class Diagram
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public string name { get; set; }
        public Config config { get; set; }

        public Entity[] entities { get; set; }

        public Connection[] connections { get; set; }

        public Category? category { get; set; }
    }
}
