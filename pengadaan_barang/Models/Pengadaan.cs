using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Client.Models
{
    public class Pengadaan
    {
        //public string PengaadanGuid { get; set; }
        [Key]
        public int Id { get; set; }
        public  Product IdBarangNavigation { get; set; }
        [ForeignKey ("IdBarangNavigation")]
        public int? IdBarang { get; set; }
        public Status IdStatusNavigation { get; set; }
        [ForeignKey("IdStatusNavigation")]
        public int? IdStatus { get; set; }

        public int? Kuantitas { get; set; }
        public int? Totals { get; set; }
        public  Divisi IdDivisiNavigation { get; set; }
        [ForeignKey("IdDivisiNavigation")]
        public int? IdDivisi { get; set; }
        public  Supplier IdSupplierNavigation { get; set; }
        [ForeignKey("IdSupplierNavigation")]
        public int? IdSupplier { get; set; }


    }
}
