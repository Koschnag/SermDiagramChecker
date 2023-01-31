namespace WebAPI.DTO.Diagram
{
    public class Connection
    {
        public int startEntity { get; set; }
        public ConnectorPostition startConnectorPosition { get; set; }
        public int endEntity { get; set; }
        public ConnectorPostition endConnectorPosition { get; set; }

    }
}