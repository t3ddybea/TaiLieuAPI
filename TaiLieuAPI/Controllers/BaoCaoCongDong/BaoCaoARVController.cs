using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaiLieuAPI.Models;

namespace TaiLieuAPI.Controllers
{
    /// <summary>
    /// TỔNG HỢP CHUYỂN VÀO ARV
    /// </summary>
    public class BaoCaoARVController : ApiController
    {
        /// <summary>
        /// Lấy danh sách TỔNG HỢP CHUYỂN VÀO ARV
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BaoCaoARV> Getds()
        {
            List<BaoCaoARV> BaocaoARVs = new List<BaoCaoARV>();
            return BaocaoARVs;
        }
    }
}
