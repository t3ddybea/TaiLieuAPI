 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TaiLieuAPI.Models;

namespace TaiLieuAPI
{
    public interface ITVXNservice
    {
        Task<IEnumerable<TVXNCD>> ListAsync();
    }
}