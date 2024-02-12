
namespace WebApplication5.Models
{
    public class ProductViewModel
    {

        public int currentPageIndex { get; set; }

        public int pageCount { get; set; }

        public  List<ProductDetail> ProductList { get; set; }
    }
}

