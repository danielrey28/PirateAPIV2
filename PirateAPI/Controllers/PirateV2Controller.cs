using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PirateAPI.Controllers
{
    public class PirateV2Controller : ApiController
    {
        /// <summary>
        /// Calculates the total amount of gold coins in the chest before the first pirates begins to divide it up.
        /// The equation for this calculation is N^N - N + 1 where N is the amount of pirates. 
        /// </summary>
        /// <param name="pirateCount">The amount of pirates</param>
        /// <returns>A long variable that represnet the total amount of coins</returns>
        public long Get(int pirateCount)
        {
            return Convert.ToInt64(Math.Pow(pirateCount, pirateCount) - pirateCount + 1);
        }
    }
}
