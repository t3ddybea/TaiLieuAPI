using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using TaiLieuAPI.Models;

namespace TaiLieuAPI.Controllers
{
    /// <summary>
    /// MẪU SỔ TVXN TẠI CỘNG ĐỒNG
    /// </summary>
    public class TVXNCDController : ApiController
    {
        /// <summary>
        /// MẪU SỔ TVXN TẠI CỘNG ĐỒNG
        /// </summary>
        /// <returns></returns>
        [System.Web.Http.HttpGet]
        public List<TVXNCD> Getds()
        {
            List<TVXNCD> tvxns = new List<TVXNCD>();
            return tvxns;
        }
    }
}
