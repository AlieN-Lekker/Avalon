using Avalon.Engine;
using Avalon.Models;

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
