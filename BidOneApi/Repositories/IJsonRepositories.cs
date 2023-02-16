namespace BidOneApi.Repositories
{
    public interface IJsonRepositories
    {
        Task SaveToJson<T>(T entity, string fileName);
    }
}
