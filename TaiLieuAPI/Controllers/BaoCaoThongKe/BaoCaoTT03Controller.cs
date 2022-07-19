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
    /// BÁO CÁO TT03 CŨ
    /// </summary>
    public class BaoCaoTT03Controller : ApiController
    {
        /// <summary>
        /// lấy danh sách BÁO CÁO TT03 CŨ
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BaoCaoTT03C> Getds()
        {
            List<BaoCaoTT03C> BaoCaoTT03Cs = new List<BaoCaoTT03C>();
            return BaoCaoTT03Cs;
        }
    }
}
