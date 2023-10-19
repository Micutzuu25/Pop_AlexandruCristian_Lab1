using Microsoft.AspNetCore.Mvc;

namespace Pop_AlexandruCristian_Lab1.Controllers
{
    public class IndexController : Controller
    {
        public string Index()
        {
            return "Salutare";
        }

        public string Greet()
        {
            return "Hello";
        }

        public string Indicator (string nume, int age) 
        {
           nume = " Alex";
           age = 10;   
            return $"My name is{nume} si am varsta de {age}";
        }

        
    }
   
}
