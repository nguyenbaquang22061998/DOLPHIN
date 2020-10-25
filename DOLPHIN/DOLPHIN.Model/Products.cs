using System;
using System.ComponentModel.DataAnnotations;

namespace DOLPHIN.Model
{
    public class Products
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Desciption { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public int CreatedBy { get; set; }

        public int UpdatedBy { get; set; }

    }
}
