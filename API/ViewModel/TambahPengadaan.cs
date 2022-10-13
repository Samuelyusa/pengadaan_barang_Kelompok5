using System.ComponentModel.DataAnnotations;

namespace API.ViewModel
{
    public class TambahPengadaan
    {

      
        public int? IdBarang { get; set; }

        public int? IdSupplier { get; set; }
        public int? Kuantitas { get; set; }
        public int? Totals { get; set; }

        public int? IdDivisi { get; set; }
        
        public int? IdStatus { get; set; }
    }
}
