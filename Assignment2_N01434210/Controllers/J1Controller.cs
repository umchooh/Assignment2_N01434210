using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01434210.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculate the total calories of the meal based on choices of burger, drink, side and dessert.
        /// </summary>
        /// <param name="burger">Integer representing the index burger choice</param>
        /// <param name="drink">Integer representing the index drink choice</param>
        /// <param name="side">Integer representing the index side choice</param>
        /// <param name="dessert">Integer representing the index dessert choice</param>
        /// <returns>A string with total calories count.</returns>
        /// <example>GET../api/J1/Menu/4/4/4/4----> Your total calorie count is 0</example>
        /// <example>Get../a[i/J1/Menu/1/2/3/4----> Your total calorie count is 691</example>
        /// 
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            //Prevent invalid input.
            if (burger < 1 || burger > 4 || drink < 1 || drink > 4 || 
                side < 1 || side > 4 || dessert < 1 || dessert > 4 )
            {
                return "invalid input";
            }

            //list of numbers.
            int[] burgerCalories = { 461, 431, 420, 0 };
            int[] drinkCalories = { 130, 160, 118, 0 };
            int[] sideCalories = { 100, 57, 70, 0 };
            int[] dessertCalories = { 167, 266, 75, 0 };

            // list of indexes, [-1] to start count from 1.
            int myBurger = burgerCalories[burger - 1];
            int myDrink = drinkCalories[drink - 1];
            int mySide = sideCalories[side - 1];
            int myDessert = dessertCalories[dessert - 1];

            //Count total of Calorie based on menu iteam on its categories.
            int totalCalorie = myBurger + myDrink + mySide + myDessert;

            // return string with total amount of calorie.
            return "Your total calorie count is " + totalCalorie;
        }
    }
}
