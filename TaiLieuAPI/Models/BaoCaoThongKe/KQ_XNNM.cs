using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// Kết quả xét nghiệm nhiễm mới
    /// </summary>
    public class KQ_XNNM
    {
        public uint ID { get; set; }
        public uint STT { get; set; }
        public string Hoten { get; set; }
        public uint SL_KHDT { get; set; }
        public uint SL_XNmoi { get; set; }
        public string KQ_NhiemMoi { get; set; }
        public string KQ_NhiemLau { get; set; }
    }
}