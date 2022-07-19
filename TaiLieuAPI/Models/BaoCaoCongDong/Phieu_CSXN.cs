using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models
{
    public class Phieu_CSXN
    {
        /// <summary>
        /// Mã báo cáo
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Địa chỉ lập phiếu
        /// </summary>
        public string Diachi_phieu { get; set; }
        /// <summary>
        /// Mã số phiếu chuyển gửi
        /// </summary>
        public uint MaSo_Phieu { get; set; }
        /// <summary>
        /// Ngày tiếp nhận
        /// </summary>
        public DateTime NgayTiepNhan { get; set; }
        /// <summary>
        /// địa chỉ khẳng định HIV
        /// </summary>
        public string DiaChi_KD { get; set; }
        /// <summary>
        /// Họ tên khách hàng
        /// </summary>
        public string Hoten { get; set; }
        /// <summary>
        /// Ngày sinh của khách hàng
        /// </summary>
        public DateTime NgaySinh { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public uint Gioitinh { get; set; }
        /// <summary>
        /// Hộ khẩu thường trú
        /// </summary>
        public string HKTT { get; set; }
        /// <summary>
        /// Căn cước công dân
        /// </summary>
        public uint CCCD { get; set; }
        /// <summary>
        /// Ngày cấp Căn cước công dân
        /// </summary>
        public DateTime NgayCap { get; set; }
        /// <summary>
        /// Nơi cấp Căn cước công dân
        /// </summary>
        public string NoiCap { get; set; }
        /// <summary>
        /// Mã tư vấn xét nghiệm của khách hàng
        /// </summary>
        public uint Ma_TVSN { get; set; }
        /// <summary>
        /// họ tên người người chuyển gửi
        /// </summary>
        public string Hoten_Chuyen { get; set; }
        /// <summary>
        /// địa chỉ người chuyển gửi
        /// </summary>
        public string Diachi_chuyen { get; set; }
        /// <summary>
        /// Số điện thoại người chuyển
        /// </summary>
        public uint SDT_Chuyen { get; set; }
        /// <summary>
        /// người giới thiệu ký
        /// </summary>
        public string Nguoi_GT { get; set; }
        /// <summary>
        /// đại diện cơ sở tư vấn xét nghiệm khẳng định
        /// </summary>
        public string CS_TVSN { get; set; }
    }
}