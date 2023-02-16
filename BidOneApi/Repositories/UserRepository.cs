using BidOneApi.Model;
using Newtonsoft.Json;

namespace BidOneApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IJsonRepositories _jsonRepositories;
        private readonly ILogger _logger;

        public UserRepository(IJsonRepositories jsonRepositories, ILogger<UserRepository> logger)
        {
            _jsonRepositories = jsonRepositories;
            _logger = logger;
        }
        public async Task SaveAsync(User user)
        {
            _logger.LogInformation($"Save user to Json: {JsonConvert.SerializeObject(user)}");
            await _jsonRepositories.SaveToJson<User>(user, $"{user.FirstName}_{user.LastName}.json");
        }
    }
}
