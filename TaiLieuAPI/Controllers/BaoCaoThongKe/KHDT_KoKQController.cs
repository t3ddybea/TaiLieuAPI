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
    /// KHÁCH HÀNG DƯƠNG TÍNH KHÔNG NHẬN KQ
    /// </summary>
    public class KHDT_KoKQController : ApiController
    {
        /// <summary>
        /// Lấy danh sách KHÁCH HÀNG DƯƠNG TÍNH KHÔNG NHẬN KQ
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<KHDT_KoKQ> Getds()
        {
            List<KHDT_KoKQ> KHDT_KoKQs = new List<KHDT_KoKQ>();
            return KHDT_KoKQs;
        }
    }
}
