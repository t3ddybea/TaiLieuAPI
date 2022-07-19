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
    /// Chuyển gửi chưa đến
    /// </summary>
    public class CG_ChuaDenController : ApiController
    {
        /// <summary>
        /// lấy danh sách Chuyển gửi chưa đến
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<CG_ChuaDen> Getds()
        {
            List<CG_ChuaDen> CG_ChuaDens = new List<CG_ChuaDen>();
            return CG_ChuaDens;
        }
    }
}
