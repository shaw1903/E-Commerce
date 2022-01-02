using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.AutoGen
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column(TypeName = "STRING")]
        public byte[] CustomerName { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] PostCode { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] Address { get; set; }
        [Column(TypeName = "INT")]
        public long PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public byte[] EmailAddress { get; set; }

        [InverseProperty(nameof(Order.CustomerNameNavigation))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
