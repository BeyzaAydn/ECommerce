using ECommerce.Model.Entities;
using ECommerceDAL.Seeds;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceDAL.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);
            builder.HasData(CategorySeed.Categories);
        }
    }
}
