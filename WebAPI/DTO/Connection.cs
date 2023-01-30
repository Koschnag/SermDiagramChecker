namespace WebAPI.DTO
{
    public class Connection
    {
        public int startEntity{get;set;}
        public string startConnectorPosition { get; set; }
        public int endEntity { get; set; }
        public string endConnectorPosition { get; set; }

    }
}