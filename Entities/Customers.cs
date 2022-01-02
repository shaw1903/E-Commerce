using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using E_Commerce.Data;
using E_Commerce.Controllers;
using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

#nullable disable

namespace E_Commerce.Models
{
  [Table("Customers")]
  [Index(nameof(CustomerName), Name = "CustomerName")]
  [Index(nameof(PostCode), Name = "PostCode")]
  [Index(nameof(PhoneNumber), Name = "PhoneNumber")]
  [Index(nameof(Address), Name = "Address")]
  [Index(nameof(EmailAddress), Name = "EmailAddress")]
  [BindProperties]
  public class Customers
  {
        [Key]
        [Column(TypeName = "nvarchar (30)")]
        [Display(Name = "Customer Name")]
        [StringLength(30)]
        public string CustomerName { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public string PostCode { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public string City { get; set; }

        [Column(TypeName = "INT")]
        public int PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public string Address { get; set; }
        [Required]
        [Column(TypeName = "STRING")]
        public string EmailAddress { get; set; }
  }
}

