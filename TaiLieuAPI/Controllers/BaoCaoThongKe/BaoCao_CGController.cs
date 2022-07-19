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
    /// Báo cáo chuyển gửi
    /// </summary>
    public class BaoCao_CGController : ApiController
    {
        /// <summary>
        ///  lấy danh sách Báo cáo chuyển gửi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<BaoCao_CG> Getds()
        {
            List<BaoCao_CG> BaoCao_CGs = new List<BaoCao_CG>();
            return BaoCao_CGs;
        }
    }
}
