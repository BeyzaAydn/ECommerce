using ECommerce.Model.Base;

namespace ECommerce.BLL.Repositories.Abstracts.BaseAbstract
{
   public interface IRepository<T> where T : BaseEntity
    {
       public  IEnumerable<T> GetAll();
        
    }
}
