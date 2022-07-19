using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaiLieuAPI.Models.BaoCaoThongKe
{
    /// <summary>
    /// Báo cáo MER
    /// </summary>
    public class BaoCao_MER
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
        /// Tên cơ sở
        /// </summary>
        public string TenCoSo { get; set; }
        /// <summary>
        /// Tỉnh
        /// </summary>
        public string Tinh { get; set; }
        /// <summary>
        /// Loại dịch vụ
        /// </summary>
        public string LoaiDichVu { get; set; }
        /// <summary>
        /// Danh sách nhóm đôi tượng nguy cơ cao
        /// </summary>
        public List<NguyCoCao> nguycocaos { get; set; }
        /// <summary>
        /// Phân loại nhóm theo tuổi, giới và kết quả xét nghiệm dương tính
        /// </summary>
        public List<NhomXNDT> NhomXNDTs { get; set; }
        /// <summary>
        /// Phân loại nhóm theo tuổi giới và kết quả xét nghiệm âm tính
        /// </summary>
        public List<NhomXNAT> NhomXNATs { get; set; }
    }

    public class NguyCoCao
    {
        public uint DTNC_Matuy { get; set; }
        public uint DTNC_NamQH { get; set; }
        public uint DTNC_NguoiCG { get; set; }
        public uint DTNC_PhuNuBD { get; set; }
        public uint ATNC_Matuy { get; set; }
        public uint ATNC_NamQH { get; set; }
        public uint ATNC_NguoiCG { get; set; }
        public uint ATNC_PhuNuBD { get; set; }
    }

    public class NhomXNDT
    {
        public uint DT_NuKoT { get; set; }
        public uint DT_NamKoT { get; set; }
        public uint DT_1Tuoi { get; set; }
        public uint DT_9Tuoi { get; set; }
        public uint DT_Nu10T { get; set; }
        public uint DT_Nam10T { get; set; }
        public uint DT_Nu15T { get; set; }
        public uint DT_Nam15T { get; set; }
        public uint DT_Nu20T { get; set; }
        public uint DT_Nam20T { get; set; }
        public uint DT_Nu25T { get; set; }
        public uint DT_Nam25T { get; set; }
        public uint DT_Nu50T { get; set; }
        public uint DT_Nam50T { get; set; }
    }

    public class NhomXNAT
    {
        public uint AT_NuKoT { get; set; }
        public uint AT_NamKoT { get; set; }
        public uint AT_1Tuoi { get; set; }
        public uint AT_9Tuoi { get; set; }
        public uint AT_Nu10T { get; set; }
        public uint AT_Nam10T { get; set; }
        public uint AT_Nu15T { get; set; }
        public uint AT_Nam15T { get; set; }
        public uint AT_Nu20T { get; set; }
        public uint AT_Nam20T { get; set; }
        public uint AT_Nu25T { get; set; }
        public uint AT_Nam25T { get; set; }
        public uint AT_Nu50T { get; set; }
        public uint AT_Nam50T { get; set; }
    }
}