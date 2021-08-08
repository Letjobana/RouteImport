using Geotab.Checkmate;
using Geotab.Checkmate.ObjectModel;

namespace RouteImport.Repositories.Abstracts
{
    public interface IApiRepository
    {
        bool Aunthenticate(API api);
        User GetUserByUserName(string name);
    }
}
