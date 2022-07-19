using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// Chuyển gửi thành công
    /// </summary>
    public class CG_TC
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
        /// Ngày chuyển
        /// </summary>
        public DateTime NgayChuyen { get; set; }
        /// <summary>
        /// Cơ sở chuyển đến
        /// </summary>
        public string CoSo_Chuyen { get; set; }
        /// <summary>
        /// Ngày đăng ký điều trị
        /// </summary>
        public DateTime NgayDT { get; set; }
        /// <summary>
        /// Cơ sở điều trị  
        /// </summary>
        public string CSDT { get; set; }
        /// <summary>
        /// Mã điều trị
        /// </summary>
        public uint MSDT { get; set; }
    }
}