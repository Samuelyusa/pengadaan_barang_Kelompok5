namespace API.ViewModel
{
    public class EditProduct
    {
        public int Id { get; set; }
        public string NamaProduk { get; set; }
        public int? IdSatuan { get; set; }
        public int? HargaProduct { get; set; }
        public int? StockProduct { get; set; }
        public int? IdSupplier { get; set; }
    }
}
