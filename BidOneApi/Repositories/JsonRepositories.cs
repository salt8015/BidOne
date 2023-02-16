using System.Text.Json;

namespace BidOneApi.Repositories
{
    public class JsonRepositories : IJsonRepositories
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public JsonRepositories(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task SaveToJson<T>(T entity, string fileName)
        {
            string wwwPath = _webHostEnvironment.ContentRootPath;
            string path = Path.Combine(_webHostEnvironment.ContentRootPath, "Data");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            await using FileStream createStream = File.Create(Path.Combine(path, fileName));
            await JsonSerializer.SerializeAsync(createStream, entity);
        }
    }
}
