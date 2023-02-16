using BidOneApi.Model;
using BidOneApi.Repositories;
using BidOneApi.UnitTest.Repositories.Mocks;
using Microsoft.Extensions.Logging;
using Moq;

namespace BidOneApi.UnitTest.Repositories
{
    public class UserRepositoryTests
    {
        [Test]
        public async Task UserRepository_SaveAsync_CallsExecuteAsyncWithCorrectParameters()
        {
            var jsonRepositoryMock = new JsonRepositoryMock();
            var loggerMock = new Mock<ILogger<UserRepository>>();
            var repository = new UserRepository(jsonRepositoryMock.Mock.Object, loggerMock.Object);
            var user = new User
            {
                FirstName = "FirstName",
                LastName = "LastName"
            };

            await repository.SaveAsync(user);
            jsonRepositoryMock.Mock.Verify(p => p.SaveToJson(It.Is<object>(obj => ReferenceEquals(user, obj)),
                It.Is<string>(filename => filename.Contains(user.FirstName))), Times.Once);
        }
    }
}
