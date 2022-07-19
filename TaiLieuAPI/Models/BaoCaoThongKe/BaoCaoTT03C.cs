using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// BÁO CÁO TT03 CŨ
    /// </summary>
    public class BaoCaoTT03C
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
        /// Danh mục báo cáo
        /// </summary>
        public string DanhMucBaoCao { get; set; }
        /// <summary>
        /// Số người được tư vấn xét nghiệm
        /// </summary>
        public uint SL_TVXN { get; set; }
        /// <summary>
        /// Tổng số người được xét nghiệm hIV
        /// </summary>
        public uint SL_TXN { get; set; }
        /// <summary>
        /// Số người dương tính HIV
        /// </summary>
        public uint SL_XNHIV { get; set; }
        /// <summary>
        /// Tổng số người được kết quả xét nghiệm
        /// </summary>
        public uint SL_TKQ { get; set; }
        /// <summary>
        /// Số người được kết qua xét nghiệm dương tính HIV
        /// </summary>
        public uint SL_KQHIV { get; set; }
    }
}