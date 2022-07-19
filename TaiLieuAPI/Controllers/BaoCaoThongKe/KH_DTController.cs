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
    /// Khách hàng dương tính
    /// </summary>
    public class KH_DTController : ApiController
    {
        /// <summary>
        /// Lấy danh sách Khách hàng dương tính
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<KH_DT> Getds()
        {
            List<KH_DT> KH_DTs = new List<KH_DT>();
            return KH_DTs;
        }
    }
}
