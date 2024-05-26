using System.ComponentModel.DataAnnotations;

namespace ECommerce.BLL.ViewModels.CategoryViewModels
{
    public  class CategoryViewModel
    {
        [Display(Name ="Kategori Adı")]
        public string CategoryName {  get; set; }

        [Display(Name ="Açıklama")]
        public string Description { get; set; }
    }
}
