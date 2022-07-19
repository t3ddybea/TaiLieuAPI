using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models
{
    public class TVXNCD
    {
        /// <summary>
        /// Mã sổ tư vấn xét nghiệm
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Số thứ tự
        /// </summary>
        public uint STT { get; set; }
        /// <summary>
        /// Ngày xét nghiệm
        /// </summary>
        public DateTime NgayXN { get; set; }
        /// <summary>
        /// Mã số khách hàng
        /// </summary>
        public string MaSo { get; set; }
        /// <summary>
        /// Họ tên khách hàng
        /// </summary>
        public string Hoten { get; set; }
        /// <summary>
        /// Tuổi của khách hàng
        /// </summary>
        public uint Tuoi { get; set; }
        /// <summary>
        /// Giới tính của khách hàng
        /// </summary>
        public uint GioiTinh { get; set; }
        /// <summary>
        /// Địa chỉ liên hệ của khách hàng
        /// </summary>
        public string DiachiLH { get; set; }
        /// <summary>
        /// Số điện thoại của khách hàng
        /// </summary>
        public uint SDT { get; set; }
        /// <summary>
        /// Đánh giá nguy cơ
        /// </summary>
        public string DanhGiaNguyCo { get; set; }
        /// <summary>
        /// Tư vấn trước xét nghiệm
        /// </summary>
        public string TuVanTruocXN { get; set; }
        /// <summary>
        /// Kết quả xét nghiệm
        /// </summary>
        public string KQXN { get; set; }
        /// <summary>
        /// Kết quả xét nghiệm tại cộng đồng
        /// </summary>
        public string KQCD { get; set; }
        /// <summary>
        /// Giới thiệu đến cơ sở xét nghiệm khẳng định
        /// </summary>
        public string CSXNKD { get; set; }
        /// <summary>
        /// Ngày có kết quả xét nghiệm khẳng định
        /// </summary>
        public DateTime NgayCoKQ { get; set; }
        /// <summary>
        /// Ngày nhận kết quả xét nghiệm khẳng định
        /// </summary>
        public DateTime NgayNhanKQ { get; set; }
        /// <summary>
        /// Giới thiệu dịch vụ
        /// </summary>
        public string GTDichVu { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string GhiChu { get; set; }
        /// <summary>
        /// Tư vấn viên ký ( tư vấn trước XN)
        /// </summary>
        public string TuVan1 { get; set; }
        /// <summary>
        /// Tư vấn viên ký ( tư vấn sau XN)
        /// </summary>
        public string TuVan2 { get; set; }

    }
}