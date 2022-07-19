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
    /// TỔNG HỢP KHÁCH HÀNG TUÂN THỦ ARV
    /// </summary>
    public class KH_ARVController : ApiController
    {
        /// <summary>
        /// Lấy danh sách TỔNG HỢP KHÁCH HÀNG TUÂN THỦ ARV
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<KH_ARV> Getds()
        {
            List<KH_ARV> KH_ARVs = new List<KH_ARV>();
            return KH_ARVs;
        }
    }
}
