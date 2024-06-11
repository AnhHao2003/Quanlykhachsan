namespace QLKS_APIs.Controllers.Models
{
    public class DatPhong
    {
        public int Id { get; set; }
        public int IdKhachHang { get; set; }
        public KhachHang? KhachHang { get; set; }
        public int IdPhong { get; set; }
        public Phong? Phong { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool DaXacNhan
        {
            get; set;
        }
    }
}