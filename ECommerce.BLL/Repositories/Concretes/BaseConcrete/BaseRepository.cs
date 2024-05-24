using ECommerce.BLL.Repositories.Abstracts.BaseAbstract;
using ECommerce.Model.Base;
using ECommerceDAL.Context;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Repositories.Concretes.BaseConcrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ECommerceContext _context;
        private DbSet<T> _entities;
        public BaseRepository(ECommerceContext context)//todo:bu enjekte edilen context program cs de fırlatılacak
        {
            _context = context;
            _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();

        }
    }
}
