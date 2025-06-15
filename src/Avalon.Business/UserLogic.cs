using Avalon.Data;
using Avalon.Domain;

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
