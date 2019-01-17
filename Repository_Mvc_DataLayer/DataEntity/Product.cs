
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Repository_Mvc_DataLayer.DataEntity
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} has between {2} and {1}")]
        public string Name { get; set; }
        [DisplayFormat(DataFormatString ="{0}F2")]
        public double Weight { get; set; }
        [DisplayFormat(DataFormatString ="{0}F2")]
        public double Price { get; set; }
        public string PathImage { get; set; }
    }
}
