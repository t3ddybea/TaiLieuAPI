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
    /// TỔNG HỢP KHÁCH HÀNG TUẦN THỦ PREP
    /// </summary>
    public class KH_PrEPController : ApiController
    {
        /// <summary>
        /// Lấy danh sách TỔNG HỢP KHÁCH HÀNG TUẦN THỦ PREP
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<KH_PrEP> Getds()
        {
            List<KH_PrEP> KH_PrEPs = new List<KH_PrEP>();
            return KH_PrEPs;
        }
    }
}
