
using Avelon.Data;
using Avelon.Domain;


using System.Collections.Generic;
using System.Linq;

namespace Avelon.Service
{
    public class UserLogic
    {
        private readonly AvelonDbContext _db;

        public UserLogic(AvelonDbContext db)

        {
            _db = db;
        }

        public IEnumerable<User> GetUsers()
        {
            return _db.Users.ToList();
        }
    }
}
