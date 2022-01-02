using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.AutoGen
{
    public partial class Order
    {
        [Key]
        [Column(TypeName = "INT")]
        public long OrderNumber { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public byte[] OrderDate { get; set; }
        [Column(TypeName = "INT")]
        public long ItemNumber { get; set; }
        [Column(TypeName = "INT")]
        public long ItemQuantity { get; set; }
        [Required]
        [Column(TypeName = "DECIMAL")]
        public byte[] ItemPrice { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] CustomerName { get; set; }

        [ForeignKey(nameof(CustomerName))]
        [InverseProperty(nameof(Customer.Orders))]
        public virtual Customer CustomerNameNavigation { get; set; }
        [ForeignKey(nameof(ItemNumber))]
        [InverseProperty(nameof(Image.Orders))]
        public virtual Image ItemNumberNavigation { get; set; }
    }
}
