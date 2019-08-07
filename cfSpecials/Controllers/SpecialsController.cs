using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cfSpecials.Models;
using Newtonsoft.Json;


namespace cfSpecials.Controllers
{
    public class SpecialsController : Controller
    {
        public IActionResult Index()
        {
            // need to read the data from file and json that mofo
            string path = @"C:\Users\andru\source\repos\cfSpecials\cfSpecials\wwwroot\js\current-specials.json";

            //string data = System.IO.File.ReadAllText(path, Encoding.UTF8);

            var str = System.IO.File.ReadAllText(path);
            var obj = JsonConvert.DeserializeObject<List<Specials>>(str);


            return View(obj);
        }

        // Modifiers(private/public) ReturnType Methodname ArgList
        //public IActionResult SetData(Specials obj)
        //{
            
        //}
    }
}