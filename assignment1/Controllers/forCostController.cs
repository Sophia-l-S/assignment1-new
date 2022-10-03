using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class forCostController : ApiController
    {
        /// <summary> 
        /// total hosting cost  
        /// </summary> 
        /// <param name="id"> </param> 
        /// <returns>Returns 3 strings which describe the total hosting cost </returns> 
        /// <example>http://localhost:51950/api/forcost/ 
        ///number of nights: 
        ///number of nights * fortnightly 
        /// number of nights * fortnightly total * tax 
        ///</example> 
        /// to solve this problem you could use $5.50 divided by 14(nights) = .3928per day.Times the 13% tax.

     //   public int Get(int id)
      //  {
        //    int charge = id * .3928;
       //     int tax = charge * .13
       //     return tax;
       // }
    }
}
