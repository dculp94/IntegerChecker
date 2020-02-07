using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IntegerChecker.Models;


namespace IntegerChecker.Controllers
{


    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]

       public ActionResult Index(IntegerRead num)
        {
            // Checks if input is a whole number

            if (num.Input < 0 || num.Input % 1 != 0)
            {
                num.Result = num.Input;
                num.Output = num.Result.ToString();
                num.Output = "Warning! Integer must be above 0 and a non-decimal number! ";

                return View(num);
            }

            // Checks if divisible by 3 first then if divisible by 5, if not prints out 3 message
            else if (num.Input % 3 == 0 && num.Input > 0)
            {
                if (num.Input % 5 == 0 )
                {
                    num.Result = num.Input;
                    num.Output = num.Result.ToString();
                    num.Output = "Green Cloud";

                    return View(num);
                }
                else 
                {
                    num.Result = num.Input;
                    num.Output = num.Result.ToString();
                    num.Output = "Green";
                    return View(num);
                }
                
            }

            // Checks if number is divisible by 5 and then 3, if not then prints out only 5 message
            else if (num.Input % 5 == 0 && num.Input > 0)
            {
                if (num.Input % 3 == 0)
                {
                    num.Result = num.Input;
                    num.Output = num.Result.ToString();
                    num.Output = "Green Cloud";
                    return View(num);
                }
                else
                {
                    num.Result = num.Input;
                    num.Output = num.Result.ToString();
                    num.Output = "Cloud";
                    return View(num);
                }
                
            }
            
            // Return number as is if none of the above criteria is me
            else
            {
                num.Result = num.Input;
                return View(num);
            }
           

        }
     }
}
