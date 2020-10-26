using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DOLPHIN.Model
{
    public class OrderDetails : AuditableEntity
    {
        [Key]
        public long Id { get; set; }

        public Guid OrderId { get; set; }

        public Guid ProductId { get; set; }

        public int Status { get; set; }

        public int Quantity { get; set; }

        public string Price { get; set; }

        public string OtherDetail { get; set; }
    }
}
