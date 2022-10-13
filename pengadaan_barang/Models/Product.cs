using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Client.Models
{
    public class Product
    {
        
        [Key]
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public Satuan IdSatuanNavigation { get; set; }

        [ForeignKey("IdSatuanNavigation")]
        public int? IdSatuan { get; set; }
        public int? HargaProduct { get; set; }
        public int? StockProduct { get; set; }
        public Supplier IdSupplierNavigation { get; set; }

        [ForeignKey("IdSupplierNavigation")]
        public int? IdSupplier { get; set; }




    }
}
