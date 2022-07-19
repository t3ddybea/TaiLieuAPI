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
    /// Phiếu chuyển gửi CSXN
    /// </summary>
    public class Phieu_CSXNController : ApiController
    {
        /// <summary>
        /// Phiếu chuyển gửi CSXN
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Phieu_CSXN> Getds()
        {
            List<Phieu_CSXN> Phieu_CSXNs = new List<Phieu_CSXN>();
            return Phieu_CSXNs;
        }
    }
}
