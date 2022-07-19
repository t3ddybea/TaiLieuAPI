using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// Khách hàng dương tính
    /// </summary>
    public class KH_DT
    {
        /// <summary>
        /// Mã sổ
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Số thứ tự
        /// </summary>
        public uint STT { get; set; }
        /// <summary>
        /// Mã khách hàng 
        /// </summary>
        public uint MaKH { get; set; }
        /// <summary>
        /// Họ tên khách hàng
        /// </summary>
        public string Hoten { get; set; }
        /// <summary>
        /// Ngày sinh của khách hàng
        /// </summary>
        public DateTime NgaySinh { get; set; }
        /// <summary>
        /// Chứng minh nhân dân
        /// </summary>
        public uint CMND { get; set; }
        /// <summary>
        /// Địa chỉ cư trú hiện tại
        /// </summary>
        public string DiaChiHT { get; set; }
        /// <summary>
        /// Hộ khẩu đăng ký thường trú
        /// </summary>
        public string HoKhauDK { get; set; }
        /// <summary>
        /// Nghề nghiệp
        /// </summary>
        public string NgheNghiep { get; set; }
        /// <summary>
        /// Đối tượng
        /// </summary>
        public string DoiTuong { get; set; }
        /// <summary>
        /// Đường lây
        /// </summary>
        public string DuongLay { get; set; }
        /// <summary>
        /// Nơi lấy máu
        /// </summary>
        public string NoiLayMau { get; set; }
        /// <summary>
        /// Ngày lấy máu
        /// </summary>
        public DateTime NgayLayMau { get; set; }
        /// <summary>
        /// Ngày xét nghiệm đăng ký
        /// </summary>
        public DateTime NgayXNDK { get; set; }
        /// <summary>
        /// Phòng xét nghiệm đăng ký
        /// </summary>
        public string PhongXNDK { get; set; }
    }
}