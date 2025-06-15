using Avalon.Business;
using Avalon.Domain;
using System.Collections.Generic;


namespace Avalon.Core
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
