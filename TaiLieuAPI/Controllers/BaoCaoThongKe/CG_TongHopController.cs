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
    /// Chuyển gửi tổng hợp
    /// </summary>
    public class CG_TongHopController : ApiController
    {
        /// <summary>
        /// Lấy danh sách Chuyển gửi tổng hợp
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CG_TongHop> Getds()
        {
            List<CG_TongHop> CG_TongHops = new List<CG_TongHop>();
            return CG_TongHops;
        }
    }
}
