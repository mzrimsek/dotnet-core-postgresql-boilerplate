using System.Linq;
using Core.Interfaces;
using Core.Models;
using Integration.EntityFramework.Mappers;
using Integration.EntityFramework.Models;

namespace Integration.EntityFramework.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext _databaseContext;

        public UserRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public UserDomainModel GetByEmail(string email)
        {
            var userFromDb = _databaseContext.Users.SingleOrDefault(x => x.Email == email);
            return UserDomainModelMapper.MapFrom(userFromDb);
        }

        public void Save(UserDatabaseModel userToSave)
        {
            var userFromDb = _databaseContext.Users.SingleOrDefault(x => x.Id == userToSave.Id);
            if(userFromDb != null)
            {
                userFromDb = userToSave;
            }
            else
            {
                _databaseContext.Users.Add(userToSave);
            }
            _databaseContext.SaveChanges();
        }
    }
}
