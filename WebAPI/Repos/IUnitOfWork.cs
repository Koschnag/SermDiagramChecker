namespace WebAPI.Repos
{
    public interface IUnitOfWork : IDisposable
    {
        void SaveChanges();
    }
}
