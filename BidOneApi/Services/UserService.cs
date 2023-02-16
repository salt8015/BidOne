using BidOneApi.Model;
using BidOneApi.Repositories;
using System.ComponentModel.DataAnnotations;

namespace BidOneApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task SaveAsync(User user)
        {
            if(user == null)
            {
                throw new ValidationException($"Invalid request");
            }

            if(string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName))
            {
                throw new ValidationException($"FirstName and LastName are mandatory fields");
            }
            //Save user
            await _userRepository.SaveAsync(user);
        }
    }
}
