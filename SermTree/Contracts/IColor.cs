namespace SermTreeCore.Contracts
{
    public interface IColor
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string? Description { get; set; }
        public IResult? Result { get; set; }
    }
}