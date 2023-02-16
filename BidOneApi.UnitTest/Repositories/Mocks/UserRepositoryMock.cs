using BidOneApi.Repositories;
using Moq;

namespace BidOneApi.UnitTest.Repositories.Mocks
{
    internal class UserRepositoryMock
    {
        public Mock<IUserRepository> Mock;

        public UserRepositoryMock()
        {
            Mock = new Mock<IUserRepository>();
        }
    }
}
