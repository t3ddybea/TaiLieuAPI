using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// Báo cáo chuyển gửi
    /// </summary>
    public class BaoCao_CG
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
        /// Đối tượng
        /// </summary>
        public string DoiTuong { get; set; }
        /// <summary>
        /// Số khách hàng nam dương tính được giới thiệu tới cơ sở điều trị trong kỳ báo cáo
        /// </summary>
        public uint SL_KHNam { get; set; }
        /// <summary>
        /// Số khách hàng nữ dương tính được giới thiệu tới cơ sở điều trị trong kỳ báo cáo
        /// </summary>
        public uint SL_KHNu { get; set; }
        /// <summary>
        /// Tổng số khách hàng dương tính được giới thiệu tới cơ sở điều trị trong kỳ báo cáo
        /// </summary>
        public uint SL_Tong { get; set; }
        /// <summary>
        /// Số khách hàng nam dương tính được giới thiệu tới cơ sở điều trị đã được đăng ký vào chăm sóc điều trị trong kỳ báo cáo 
        /// </summary>
        public uint SL_KHNamDT { get; set; }
        /// <summary>
        /// Số khách hàng nữ dương tính được giới thiệu tới cơ sở điều trị đã được đăng ký vào chăm sóc điều trị trong kỳ báo cáo 
        /// </summary>
        public uint SL_KHNuDT { get; set; }
        /// <summary>
        /// Tổng số khách hàng dương tính được giới thiệu tới cơ sở điều trị đã được đăng ký vào chăm sóc điều trị trong kỳ báo cáo 
        /// </summary>
        public uint SL_TongDT { get; set; }

    }
}