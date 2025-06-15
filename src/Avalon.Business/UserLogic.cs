using Avalon.Data;
using Avalon.Domain;

using System.Collections.Generic;
using System.Linq;


namespace Avalon.Business
{
    public class UserLogic
    {
        private readonly AvalonDbContext _db;

        public UserLogic(AvalonDbContext db)
        {
            _db = db;
        }

        public IEnumerable<User> GetUsers()
        {
            return _db.Users.ToList();
        }
    }
}
