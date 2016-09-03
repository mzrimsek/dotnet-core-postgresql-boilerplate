using Core.Models;
using UI.Models;

namespace UI.Mappers
{
    public static class UserViewModelMapper
    {
        public static UserViewModel MapFrom(UserDomainModel domainModel)
        {
            return new UserViewModel
            {
                FirstName = domainModel.FirstName,
                LastName = domainModel.LastName,
                Email = domainModel.Email
            };
        }
    }
}