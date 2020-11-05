using System;
using System.ComponentModel.DataAnnotations;

namespace DOLPHIN.Model
{
    public class Products : AuditableEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Desciption { get; set; }
        public int Status { get; set; }
    }
}
