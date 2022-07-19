using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// Sổ tư vấn xét nghiệm
    /// </summary>
    public class So_TVXN
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
        /// Ngày lấy mẫu xét nghiệm SL
        /// </summary>
        public DateTime NgayLayMauXN { get; set; }
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
        /// Giới tính của khách hàng
        /// </summary>
        public uint GioiTinh { get; set; }
        /// <summary>
        /// Địa chỉ liên hệ
        /// </summary>
        public string DiaChiLH { get; set; }
        /// <summary>
        /// Mã BTBC
        /// </summary>
        public string MaBTBC { get; set; }
        /// <summary>
        /// Nhóm nguy cơ
        /// </summary>
        public string NhomNguyCo { get; set; }
        /// <summary>
        /// Xét nghiệm
        /// </summary>
        public string XetNghiem { get; set; }
        /// <summary>
        /// Kết quả xét nghiệm SL
        /// </summary>
        public string KQXN { get; set; }
        /// <summary>
        /// Cơ sở xét nghiệm
        /// </summary>
        public string KQ_CSXN { get; set; }
        /// <summary>
        /// Mã tư vấn xét nghiệm HIV
        /// </summary>
        public string KQ_MaTVXN { get; set; }
        /// <summary>
        /// Kết quả xét nghiệm khẳng định
        /// </summary>
        public string KQ_XNKD { get; set; }
        /// <summary>
        /// Nhận kết quả xét nghiệm
        /// </summary>
        public bool Nhan_KQTV { get; set; }
        /// <summary>
        /// Chứng minh nhân dân 
        /// </summary>
        public uint CMND { get; set; }
        /// <summary>
        /// Số điện thoại khách hàng
        /// </summary>
        public uint SDT { get; set; }
        /// <summary>
        /// Cơ sở điều trị cần chuyển khách hàng đến
        /// </summary>
        public string CS_DT { get; set; }
        /// <summary>
        /// Ngày chuyển gửi 
        /// </summary>
        public DateTime NgayChuyen { get; set; }
        /// <summary>
        /// Cơ sở bệnh nhân đăng kí
        /// </summary>
        public string CS_DK { get; set; }
        /// <summary>
        /// Ngày đăng ký điều trị
        /// </summary>
        public DateTime NgayDK { get; set; }
        /// <summary>
        /// Ngày tư vấn viên đăng ký(Trước XN)
        /// </summary>
        public DateTime Ngay_TVDK1 { get; set; }
        /// <summary>
        /// Ngày tư vấn viên đăng ký(Sau XN)
        /// </summary>
        public DateTime Ngay_TVDK2 { get; set; }

    }
}