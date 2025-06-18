using Avalon.Database;
using Avalon.Models;

namespace Avalon.Logic
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
