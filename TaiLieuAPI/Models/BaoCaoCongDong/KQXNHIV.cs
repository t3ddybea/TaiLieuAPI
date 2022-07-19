using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models
{
    public class KQXNHIV
    {
        /// <summary>
        /// Mã báo cáo
        /// </summary>
        public uint ID { get; set; }
        /// <summary>
        /// Số thứ tự
        /// </summary>
        public uint STT { get; set; }
        /// <summary>
        /// Danh mục báo cáo
        /// </summary>
        public string Danhmucbaocao { get; set; }
        /// <summary>
        /// Số Lượng người được tư vấn trước xét nghiệm
        /// </summary>
        public uint SLTVtruocXN { get; set; }
        /// <summary>
        /// Tổng số lượng người xét nghiệm 
        /// </summary>
        public uint SLXN_HIV { get; set; }
        /// <summary>
        /// Số lượng người có phản ứng HIV
        /// </summary>
        public uint SL_HIV { get; set; }
        /// <summary>
        /// Tổng Số lượng người có phản ứng được chuyển gửi thành công xét nghiệm khẳng định
        /// </summary>
        public uint SL_XNKD { get; set; }
        /// <summary>
        /// Số lượng người người có phản ứng dương tính HIV 
        /// </summary>
        public uint SL_HIVKD { get; set; }
    }
}