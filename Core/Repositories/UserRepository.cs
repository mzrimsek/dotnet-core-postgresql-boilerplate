using System.Linq;
using Core.Models.Database;

namespace Core.Respositories
{
    public class UserRepository
    {
        private readonly DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public User GetByEmail(string email)
        {
            return _databaseContext.Users.SingleOrDefault(x => x.Email == email);
        }

        public void Save(User user)
        {
            var userFromDb = _databaseContext.Users.SingleOrDefault(x => x.Id == user.Id);
            if(userFromDb != null)
            {
                userFromDb = user;
            }
            else
            {
                _databaseContext.Users.Add(user);
            }
            _databaseContext.SaveChanges();
        }
    }
}
