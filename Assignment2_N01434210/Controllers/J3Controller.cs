using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01434210.Controllers
{
    public class J3Controller : ApiController
    {
        /// Problem J4/S2 - Poetry (2003)
        /// https://cemc.math.uwaterloo.ca/contests/computing/2003/stage1/2003CCCStage1Contest.pdf
        /// <summary>
        /// Find the type of rhyme based on the last syllables of each verse.
        /// </summary>
        /// <param name="verse1">string for verse 1</param>
        /// <param name="verse2">string for verse 2</param>
        /// <param name="verse3">string for verse 3</param>
        /// <param name="verse4">string for verse 4</param>
        /// <returns> return string of ryhme type </returns>
        /// <example>
        /// One plus one is small    
        /// one hundred plus one is not
        /// you might be very tall
        /// but summer is not      --------> cross
        /// </example>
        /// /// <example>
        /// I say to you boo    
        /// You say boohoo
        /// I cry too
        /// It is too much foo ------> perfect
        /// </example>
        [HttpGet]
        [Route("api/J3/Poetry/{verse1}/{verse2}/{verse3}/{verse4}")]
        public string Poetry (string verse1, string verse2, string verse3, string verse4)
        {
            //declare return with a string
            string message = "";

            // Remove spacing to get the last syllables of each verse.
            verse1 = verse1.Trim();
            verse2 = verse2.Trim();
            verse3 = verse3.Trim();
            verse4 = verse4.Trim();

            // To start [indexes] at 1, and take into account of the last character for each verse
            char last1 = verse1[verse1.Length - 1];
            char last2 = verse2[verse2.Length - 1];
            char last3 = verse3[verse3.Length - 1];
            char last4 = verse4[verse4.Length - 1];

            //IF statement when last syllables of each verse matches, result in different ryhmes
            if (( last1 == last2) && (last3 == last4))
            {
                message = "perfect"; 
            } 
            else if((last2 == last3) && (last1 == last4))
            {
                message = "shell";
            }
            else if((last1 == last3) && (last2 == last4))
            {
                message = "cross";
            }
            else
            {
                message = "free";
            }

            return message;

        }
        
    }
}
