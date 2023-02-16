using BidOneApi.Repositories;
using Moq;

namespace BidOneApi.UnitTest.Repositories.Mocks
{
    internal class JsonRepositoryMock
    {
        public Mock<IJsonRepositories> Mock;

        public JsonRepositoryMock()
        {
            Mock = new Mock<IJsonRepositories>();
        }
    }
}
