using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models
{
    public class KH_ARV
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
        /// mã điều trị arv
        /// </summary>
        public uint Ma_ARV { get; set; }
        /// <summary>
        /// Ngày tiếp nhận điều trị ARV
        /// </summary>
        public DateTime Ngay_ARV { get; set; }
        /// <summary>
        /// Cơ sở điều trị ARV
        /// </summary>
        public string CS_ARV { get; set; }
        /// <summary>
        /// Xác nhận tình trạng điều trị tháng 1
        /// </summary>
        public string XNDT_T1 { get; set; }
        /// <summary>
        /// Xác nhận tình trạng điều trị tháng 2
        /// </summary>
        public string XNDT_T2 { get; set; }
        /// <summary>
        /// Xác nhận tình trạng điều trị tháng 3
        /// </summary>
        public string XNDT_T3 { get; set; }
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string GhiChu { get; set; }

    }
}