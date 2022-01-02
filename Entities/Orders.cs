using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using E_Commerce.Data;
using E_Commerce.Models;

#nullable disable

namespace E_Commerce.Models
{
  [Table("Orders")]
  public class Orders 
  {
        [Key]
        [Column(TypeName = "INT")]
        public int OrderNumber { get; set; }
        public int OrderDate { get; set; }
        public decimal OrderTotal { get; set; }
        public int ItemNumber { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
        public bool OrderSuccessful { get; set; }

    public virtual ICollection<Images> Image { get; set; }
    public string CustomerName { get; set; }

        //public ItemNumber ItemNumber { get; set; }
        //public  ItemPrice ItemPrice { get; set; }

  }
}

