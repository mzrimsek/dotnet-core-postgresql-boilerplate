using Core.Models;
using Integration.EntityFramework.Models;

namespace Integration.EntityFramework.Mappers
{
    public static class UserDatabaseModelMapper
    {
        public static UserDatabaseModel MapFrom(UserDomainModel domainModel)
        {
            return new UserDatabaseModel
            {   
                Id = domainModel.Id,
                FirstName = domainModel.FirstName,
                LastName = domainModel.LastName,
                Email = domainModel.Email,
                Password = domainModel.Password
            };
        }
    }
}