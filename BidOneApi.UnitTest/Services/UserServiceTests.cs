using BidOneApi.Model;
using BidOneApi.Services;
using BidOneApi.UnitTest.Repositories.Mocks;
using Moq;

namespace BidOneApi.UnitTest.Services
{
    public class UserServiceTests
    {
        [Test]
        public async Task UserService_SaveAsync_CreatesNewUser()
        {
            var userRepositoryMock = new UserRepositoryMock();
            var service = new UserService(userRepositoryMock.Mock.Object);
            var user = new User
            {
                FirstName = "FirstName",
                LastName = "LastName"
            };

            await service.SaveAsync(user);
            userRepositoryMock.Mock.Verify(p => p.SaveAsync(It.Is<User>(obj => ReferenceEquals(user, obj))), Times.Once);
        }
    }
}
