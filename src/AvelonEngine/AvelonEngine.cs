using Avelon.Service;
using Avelon.Domain;
using System.Collections.Generic;


namespace Avelon.Engine
{
    public class AvelonEngine
    {
        private readonly UserLogic _userLogic;

        public AvelonEngine(UserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userLogic.GetUsers();
        }
    }
}
