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
    /// Phiếu chuyển gửi PrEP
    /// </summary>
    public class Phieu_PrEPController : ApiController
    {
        /// <summary>
        /// Phiếu chuyển gửi PrEP
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Phieu_PrEP> Getds()
        {
            List<Phieu_PrEP> Phieu_PrEPs = new List<Phieu_PrEP>();
            return Phieu_PrEPs;
        }
    }
}
