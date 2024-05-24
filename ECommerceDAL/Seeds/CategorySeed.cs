using ECommerce.Model.Entities;

namespace ECommerceDAL.Seeds
{
    public  class CategorySeed
    {
        public static List<Category> Categories = new List<Category>()
        {

            new Category{Id=1,CategoryName="test1",Description="testaciklama1"},
            new Category{Id=2,CategoryName="test2",Description="testaciklama2"},
            new Category{Id=3,CategoryName="test3",Description="testaciklama3" }
        };
    }
}
