namespace Shadow_PUDGE.Models
{
    public class Products 
    {
        // ID книги
        public int Id { get; set; }
        //назва книги
        public string Title { get; set; }
        // автор книги
        public string Description { get; set; }
        // цiна
        public int Price { get; set; }
        public int PriceCompare { get; set; }
        public int ProductsStatus { get; set; }
    }
}
