using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models
{
    public class BaoCaoPrEP
    {
        /// <summary>
        /// Mã báo cáo
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Họ tên khách hàng
        /// </summary>
        public string Hoten { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public uint Gioitinh { get; set; }
        /// <summary>
        /// Địa chỉ liên hệ
        /// </summary>
        public string DiachiLH { get; set; }
        /// <summary>
        /// Căn cước công dân
        /// </summary>
        public uint CCCD { get; set; }
        /// <summary>
        /// Số điện thoại của khách hàng
        /// </summary>
        public uint SDT { get; set; }
        /// <summary>
        /// Ngày ngày xét nghiệm HIV gần nhất
        /// </summary>
        public DateTime Ngay_XNHIV { get; set; }
        /// <summary>
        /// Ngày tiếp nhận điều trị PrEP
        /// </summary>
        public DateTime Ngay_PrEP { get; set; }
        /// <summary>
        /// Họ tên người chuyển gửi
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
    }
}