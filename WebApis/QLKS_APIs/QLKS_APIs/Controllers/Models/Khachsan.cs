namespace QLKS_APIs.Controllers.Models
{
    public class Khachsan
    {
        
            public int? Id { get; set; }
            public string? Ten { get; set; }
            public string? DiaChi { get; set; }
            public List<Phong>? DanhSachPhong { get; set; }
            // Các thuộc tính khác có thể thêm vào nếu cần
        
    }

}
