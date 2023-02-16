using BidOneApi.Model;

namespace BidOneApi.Services
{
    public interface IUserService
    {
        Task SaveAsync(User user);
    }
}
