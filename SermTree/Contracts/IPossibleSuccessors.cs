namespace SermTreeCore.Contracts
{
    public interface IPossibleSuccessors
    {
        public IList<IEdge> Relationships { get; set; }
        public IResult? Result { get; set; }
    }
}
