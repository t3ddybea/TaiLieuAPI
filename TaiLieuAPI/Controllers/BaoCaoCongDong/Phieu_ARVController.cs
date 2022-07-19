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
    /// Phiếu chuyển gửi ARV
    /// </summary>
    public class Phieu_ARVController : ApiController
    {
        /// <summary>
        ///  Phiếu chuyển gửi ARV
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Phieu_ARV> Getds()
        {
            List<Phieu_ARV> Phieu_ARVs = new List<Phieu_ARV>();
            return Phieu_ARVs;
        }
    }
}
