using BethanysPieShopHRM.Shared.Domain;
using System.Text.Json;

namespace BethanysPieShopHRM.Blazor.Services
{
    public class CountryDataService : ICountryDataService
    {
        private readonly HttpClient _httpClient;

        public CountryDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Country>> GetAllCountries()
        {
            var countriesResponse = await _httpClient.GetStreamAsync("api/country");

            return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>(countriesResponse,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Country> GetCountryById(int countryId)
        {
            var countryResponse = await _httpClient.GetStreamAsync($"api/country/{countryId}");

            return await JsonSerializer.DeserializeAsync<Country>(countryResponse,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
