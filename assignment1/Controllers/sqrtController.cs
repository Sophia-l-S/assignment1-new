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
     /// square given number
     /// </summary>
     /// <param name="id"></param>
     /// <returns>Returns the square of the integer input {id}.</returns>
     /// <example> 
     /// Console.WriteLine(Math.Sqrt(id));
     /// </example>
        public int Get(int id)
        {
            int Sroot = id * id;
            return Sroot;

        }
    }
}
