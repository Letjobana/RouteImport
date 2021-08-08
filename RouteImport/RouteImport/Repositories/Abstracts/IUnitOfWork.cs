namespace RouteImport.Repositories.Abstracts
{
    public interface IUnitOfWork
    {
        IApiRepository apiRepository { get; }
    }
}
