using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public class Divisi
    {

        [Key]
        public int Id { get; set; }
        public string Nama { get; set; }
        public int AnggaraanTetap { get; set; }


        
    }
}
