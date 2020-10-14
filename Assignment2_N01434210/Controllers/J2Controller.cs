using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Assignment2_N01434210.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Calculate how many ways for 2 dices give the total value of 10.
        /// </summary>
        /// <returns>Return string on total ways of 2 dices to get sum of 10</returns>
        /// <param name="m">The postive integer representing the number of sides on first dice</param>
        /// <param name="n">The postive integer representing the number of sides on second dice</param>
        /// <example>GET../api/J2/DiceGame/6/8 ---> "There are 5 total ways to get the sum 10."</example>
        /// <example>GET../api/J2/DiceGame/12/4 ---> "There are 4 total ways to get the sum 10."</example>
        /// <example>GET../api/J2/DiceGame/3/3 ---> "There are 0 total ways to get the sum 10."</example>
        /// <example>GET../api/J2/DiceGame/5/5 ---> "There are 1 total ways to get the sum 10."</example>
        /// 
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame (int m, int n)
        {
            //decalre int count as number of outcome.
            int count = 0;

            //Prevent invalid input, m and n to be positive all time.

            if (m < 0 || n < 0 )
            {
                return "invalid input";
            }

            //Nested loop : loop will run from value 1 to m and value 1 to n [m*n] , with
            //IF steatement with condition when i + j = 10, once hit total of 10, it will add to int count.
            for(int i = 1; i <= m; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i + j == 10)
                    {
                        count += 1;
                    }
                    
                }
            }
            // return string with total outcome to get sum of 10
            return "There are " + count + " ways to get the sum of 10.";
            
        }
    }
}
