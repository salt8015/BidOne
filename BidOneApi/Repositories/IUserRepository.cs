using BidOneApi.Model;

namespace BidOneApi.Repositories
{
    public interface IUserRepository
    {
        Task SaveAsync(User user);
    }
}
