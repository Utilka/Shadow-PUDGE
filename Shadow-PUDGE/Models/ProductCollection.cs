using System.ComponentModel.DataAnnotations;

namespace Shadow_PUDGE.Models
{
    public class ProductCollection
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreatedAt { get; set; }

        public List<Collection_product>? Collection_products { get; set; }
    }
}
