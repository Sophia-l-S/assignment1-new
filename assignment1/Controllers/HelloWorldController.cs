using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class HelloWorldController : ApiController
    {
        /// <summary> 
        /// outputs a string 
        /// </summary> 
        /// <param name="id"> </param> 
        /// <returns>Returns Hello World!</returns>
        Public string greeting()
        {
            return “Hello World”;
        }
    }
}
