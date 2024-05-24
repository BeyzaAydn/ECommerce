using ECommerce.Model.Entities;

namespace ECommerce.BLL.Repositories.Abstracts
{
    public  interface ICategoryService
    {
        public IEnumerable<Category> GetAllCategories();
    }
}
