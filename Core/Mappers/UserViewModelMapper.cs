using Core.Models.Database;
using Core.Models.View;

namespace Core.Mappers
{
    public static class UserViewModelMapper
    {
        public static UserViewModel MapFrom(UserDatabaseModel user)
        {
            return new UserViewModel
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
        }
    }
}