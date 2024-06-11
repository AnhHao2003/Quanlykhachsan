namespace QLKS_APIs.Controllers.Models
{
    public class Phong
    {
        public int Id { get; set; }
        public string? SoPhong { get; set; }
        public LoaiPhong LoaiPhong { get; set; }
        public decimal Gia { get; set; }
        public bool TrangThai { get; set; } // Trạng thái phòng (đang sử dụng, trống)
                                            // Các thuộc tính khác có thể thêm vào nếu cần
    }
}
