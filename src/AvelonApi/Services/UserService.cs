using Avalon.Core;
using Avalon.Domain;

using System.Collections.Generic;


namespace Avalon.Api.Services
{
    public class UserService
    {
        private readonly AvalonEngine _engine;

        public UserService(AvalonEngine engine)
        {
            _engine = engine;
        }

        public IEnumerable<User> GetUsers()
        {
            return _engine.GetAllUsers();
        }
    }
}
