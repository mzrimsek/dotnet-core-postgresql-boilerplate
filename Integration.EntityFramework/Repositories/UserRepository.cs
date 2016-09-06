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

        public void Save(UserDomainModel userToSave)
        {
            var databaseModel = UserDatabaseModelMapper.MapFrom(userToSave);
            var userFromDb = _databaseContext.Users.SingleOrDefault(x => x.Id == databaseModel.Id);

            if(userFromDb != null)
            {
                userFromDb = databaseModel;
            }
            else
            {
                _databaseContext.Users.Add(databaseModel);
            }
            _databaseContext.SaveChanges();
        }
    }
}
