using BethanysPieShopHRM.Shared.Domain;
using System.Text.Json;

namespace BethanysPieShopHRM.Blazor.Services
{
    public class EmployeeDataService : IEmployeeDataService
    {
        private readonly HttpClient _httpClient;

        public EmployeeDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<Employee> AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            var response = await _httpClient.GetStreamAsync($"api/employee");
            return await JsonSerializer.DeserializeAsync<IEnumerable<Employee>>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<Employee> GetEmployeeDetails(int employeeId)
        {
            var response = await _httpClient.GetStreamAsync($"api/employee/{employeeId}");
            return await JsonSerializer.DeserializeAsync<Employee>(response, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public Task UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
