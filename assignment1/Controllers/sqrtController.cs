using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class sqrtController : ApiController
    {/// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
        public int Get(int id)
        {
            int difference = Math.Sqrt(id);
            return difference;
        }
    }
}
