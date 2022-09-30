using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace assignment1.Controllers
{
    public class addTenController : ApiController
    {
        /// <summary>
        /// takes int id and adds 10
        /// </summary>
        /// <param name="id"> </param>
        /// <returns>Returns 10 more than the integer input {id}.</returns>
        /// <example>http://localhost:51950/api/addTen/10 output = 20</example>
        public int Get(int id)
            {
                int difference = id + 10;
                return difference;
            }
        }
    }


