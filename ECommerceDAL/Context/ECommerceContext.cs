using ECommerce.Model.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ECommerceDAL.Context
{

    


    public class ECommerceContext:IdentityDbContext<AppUser,AppUserRole,Guid>
    {

        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        //veritabanı bağlantısı için onconfiguring bağlantısı gerekiyor
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseSqlServer("server=BEYZA\\SQLEXPRESS; database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=true");
                

        //    base.OnConfiguring(optionsBuilder);
        //}qqqqqq
    }
}
