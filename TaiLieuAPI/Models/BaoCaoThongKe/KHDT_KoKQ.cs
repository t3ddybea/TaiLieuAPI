using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// KHÁCH HÀNG DƯƠNG TÍNH KHÔNG NHẬN KQ
    /// </summary>
    public class KHDT_KoKQ
    {
        /// <summary>
        /// Mã 
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Số thứ tự
        /// </summary>
        public uint STT { get; set; }
        /// <summary>
        /// Mã số khách hàng
        /// </summary>
        public uint MaSo { get; set; }
        /// <summary>
        /// Họ tên khách hàng
        /// </summary>
        public string Hoten { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime NgaySinh { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public uint GioiTinh { get; set; }
        /// <summary>
        /// Địa chỉ cư trú
        /// </summary>
        public string DiaChiCT { get; set; }
        /// <summary>
        /// Địa chỉ thường trú
        /// </summary>
        public string DiaChiTT { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public uint SDT { get; set; }
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
        public string KQ_XN { get; set; }
        /// <summary>
        /// kết quả xét nghiệm khẳng định
        /// </summary>
        public string KQ_XNKD { get; set; }
        /// <summary>
        /// Cơ sở xét nghiệm
        /// </summary>
        public string CSXN { get; set; }
        /// <summary>
        /// Mã tư vấn xét nghiệm
        /// </summary>
        public uint MA_TVXN { get; set; }
        /// <summary>
        /// Nhận kết quả sau khi tư vấn xét nghiệm
        /// </summary>
        public bool KQ_Nhan { get; set; }
        /// <summary>
        /// Chứng minh nhân dân
        /// </summary>
        public uint CMND { get; set; }
        /// <summary>
        /// Cơ sở điều trị cần khách hàng đến
        /// </summary>
        public string CS_DT { get; set; }
        /// <summary>
        /// Ngày chuyển đi
        /// </summary>
        public DateTime NgayChuyen { get; set; }
        /// <summary>
        /// Cơ sở đăng ký điều trị
        /// </summary>
        public string CS_DTDK { get; set; }
        /// <summary>
        /// Ngày đăng ký điều trị
        /// </summary>
        public DateTime NgayDT { get; set; }
        /// <summary>
        /// Ngày tư vấn viên đăng ký(trước XN)
        /// </summary>
        public DateTime NgayTV1 { get; set; }
        /// <summary>
        /// Ngày tư vấn viên đăng ký(SauXN)
        /// </summary>
        public DateTime NgayTV2 { get; set; }

    }
}
