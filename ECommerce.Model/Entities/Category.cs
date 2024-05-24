using ECommerce.Model.Base;

namespace ECommerce.Model.Entities
{
    public  class Category:BaseEntity
    {
        public string CategoryName { get; set; }

        public string Description {  get; set; }

        public string CategoryPicturePath {  get; set; }



    }
}
