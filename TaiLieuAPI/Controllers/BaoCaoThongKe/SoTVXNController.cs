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
    /// Sổ tư vấn xét nghiệm
    /// </summary>
    public class SoTVXNController : ApiController
    {
        /// <summary>
        /// Lấy danh sách Sổ tư vấn xét nghiệm
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<So_TVXN> Getds()
        {
            List<So_TVXN> So_TVXNs = new List<So_TVXN>(); 
            return So_TVXNs;
        }
    }
}
