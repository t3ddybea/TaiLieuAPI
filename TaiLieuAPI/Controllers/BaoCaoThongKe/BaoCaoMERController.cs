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
    /// Báo cáo MER
    /// </summary>
    public class BaoCaoMERController : ApiController
    {
        /// <summary>
        ///  lấy danh sách Báo cáo MER
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BaoCao_MER> Getds()
        {
            List<BaoCao_MER> BaoCao_MERs = new List<BaoCao_MER>();
            return BaoCao_MERs;
        }
    }
}
