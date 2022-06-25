using BlazingShop.Shared;
using System.Net.Http.Json;

namespace BlazingShop.Client.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly HttpClient _http;

        public List<Edition> Editions { get; set; } = new List<Edition>();

        public EditionService(HttpClient http)
        {
            _http = http;
        }

        public async Task LoadEditions()
        {
            Editions = await _http.GetFromJsonAsync<List<Edition>>("api/edition");
        }
    }
}
