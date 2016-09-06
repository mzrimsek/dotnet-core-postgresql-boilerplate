using Core.Models;
using Integration.EntityFramework.Models;

namespace Integration.EntityFramework.Mappers
{
    public static class UserDomainModelMapper
    {
        public static UserDomainModel MapFrom(UserDatabaseModel databaseModel)
        {
            return new UserDomainModel
            {
                Id = databaseModel.Id,
                FirstName = databaseModel.FirstName,
                LastName = databaseModel.LastName,
                Email = databaseModel.Email,
                Password = databaseModel.Password
            };
        }
    }
}