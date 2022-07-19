using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaiLieuAPI.Models.BaoCaoThongKe;

namespace TaiLieuAPI.Controllers.BaoCaoThongKe
{
    /// <summary>
    /// Kết quả xét nghiệm nhiễm mới
    /// </summary>
    public class KQ_XNNMController : ApiController
    {
        /// <summary>
        /// Lấy danh sách Kết quả xét nghiệm nhiễm mới
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<KQ_XNNM> Getds()
        {
            List<KQ_XNNM> KQ_XNNMs = new List<KQ_XNNM>();
            return KQ_XNNMs;
        }
    }
}
