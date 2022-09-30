using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class GreetingsController : ApiController
    {
        /// <summary> 
        /// greets a number of people 
        /// </summary> 
        /// <param name="id"> </param> 
        /// <returns>Returns a greeting to the number of people input </returns> 
        /// <example>http://localhost:51950/api/greetings/10 
        ///Greetings to 10 people!  
        ///</example> 
        public int Get(int id)
        {
            return “Greetings to” +id + “people!”;
        }
    }
}
