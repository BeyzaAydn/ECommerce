using ECommerce.BLL.Repositories.Abstracts;
using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Repositories.Concretes
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;//Programcs de bu fırlatılacak

        public CategoryService(IRepository<Category> categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

    }
}
