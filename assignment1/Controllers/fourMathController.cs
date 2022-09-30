using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class fourMathController : ApiController
    {
        /// <summary> 
        ///applies four mathematical operations to a given number 
        /// </summary> 
        /// <param name="id"> </param> 
        /// <returns>Returns the final output of  + 10 – 11 * 6 + 5 to the given number </returns> 
        /// <example>http://localhost:51950/api/fourMath/2 
        ///2 + 10 – 11 * 6 + 5 = 11 
        ///</example> 
        public int Get(int id)
        {
            int equ = id + 10 – 11 * 6 + 5;
            return equ;
        }
    } 
}

