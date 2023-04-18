using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Blazor.Services
{
    public interface IJobCategoryService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int countryId);
    }
}
