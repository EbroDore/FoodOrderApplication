using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantAPI.Models
{
    public class OrderMaster
    {
        public long OrderMasterId { get; set; }

        [Column(TypeName = "nvarchar(75)")]
        public string? OrderNumber { get; set; }

        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string? PMethod { get; set; }

        public decimal GTotal { get; set; }
        

        //navigational property
        public Customer? Customer { get; set; }
    }
}
