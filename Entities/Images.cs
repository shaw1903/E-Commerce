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
    [Table("Images")]
    public class Images 
    {  
        public Images()
        {
            Orders = new HashSet<Orders>();
        }
        [Key]  
        public int ItemNumber { get; set; }  
        public string ItemName { get; set; }  
        public decimal ItemPrice { get; set; } 
        public DateTime DateTaken { get; set; }  
        public string Event {get; set;}
        public string ImageURL { get; set; } 
        public virtual IEnumerable<Orders> Orders { get; set; }


    }
}

