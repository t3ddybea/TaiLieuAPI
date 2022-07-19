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
    /// TỔNG HỢP CHUYỂN VÀO PREP
    /// </summary>
    public class BaoCaoPrEPController : ApiController
    {
        /// <summary>
        /// Lấy danh sách TỔNG HỢP CHUYỂN VÀO PREP
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BaoCaoPrEP> Getds()
        {
            List<BaoCaoPrEP> BaoCaoPrEPs = new List<BaoCaoPrEP>();
            return BaoCaoPrEPs;
        }
    }
}
