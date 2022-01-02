using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.AutoGen
{
    public partial class Image
    {
        public Image()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column(TypeName = "INT")]
        public long ItemNumber { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] Name { get; set; }
        [Required]
        [Column(TypeName = "DECIMAL")]
        public byte[] ItemPrice { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public byte[] DateTaken { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] Event { get; set; }

        [InverseProperty(nameof(Order.ItemNumberNavigation))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
