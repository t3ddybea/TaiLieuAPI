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
    /// TỔNG HỢP KQXN HIV TẠI CỘNG ĐỒNG VÀ CHUYỂN GỬI XN
    /// </summary>
    public class KQXNHIVController : ApiController
    {
        /// <summary>
        /// Lấy danh sách TỔNG HỢP KQXN HIV TẠI CỘNG ĐỒNG VÀ CHUYỂN GỬI XN
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<KQXNHIV> Getds()
        {
            List<KQXNHIV> hivs = new List<KQXNHIV>();
            return hivs;
        }
    }
}
