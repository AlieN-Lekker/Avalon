using Avelon.Engine;
using Avelon.Domain;
using System.Collections.Generic;

namespace Avelon.Api.Services
{
    public class UserService
    {
        private readonly AvelonEngine _engine;

        public UserService(AvelonEngine engine)
        {
            _engine = engine;
        }

        public IEnumerable<User> GetUsers()
        {
            return _engine.GetAllUsers();
        }
    }
}
