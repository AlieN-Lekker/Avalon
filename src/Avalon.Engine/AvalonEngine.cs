using Avalon.Logic;
using Avalon.Models;

namespace Avalon.Engine
{
    public class AvalonEngine
    {
        private readonly UserLogic _userLogic;

        public AvalonEngine(UserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userLogic.GetUsers();
        }
    }
}
