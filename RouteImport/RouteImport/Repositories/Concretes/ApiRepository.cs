using Geotab.Checkmate;
using Geotab.Checkmate.ObjectModel;
using RouteImport.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RouteImport.Repositories.Concretes
{
    public class ApiRepository : IApiRepository
    {
        private API _api;
        public bool Aunthenticate(API api)
        {
            try
            {
                _api = api;
                var user = GetUserByUserName(_api.UserName);

                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUserByUserName(string name)
        {
            return _api.CallAsync<List<User>>("Get", typeof(User), new
            {
                search = new UserSearch
                {
                    Name = name
                }
            }).Result.FirstOrDefault();

        }
    }
}
