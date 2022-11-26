using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Blazor.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee>? Employees { get; set; } = default;

        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }
    }
}
