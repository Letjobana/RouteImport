using RouteImport.Repositories.Abstracts;

namespace RouteImport.Repositories.Concretes
{
    public class UnitOfWork : IUnitOfWork
    {
        public IApiRepository apiRepository { get; private set; }
        public UnitOfWork()
        {
            apiRepository = new ApiRepository();
        }
    }
}
