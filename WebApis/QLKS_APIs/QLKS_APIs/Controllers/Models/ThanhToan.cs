namespace QLKS_APIs.Controllers.Models
{
    public class ThanhToan
    {
        public int Id { get; set; }
        public int IdDatPhong { get; set; }
        public DatPhong? DatPhong { get; set; }
        public decimal SoTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
    }
}
