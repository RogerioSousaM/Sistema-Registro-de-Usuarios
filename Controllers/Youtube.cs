using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace RegistrarUsuarios.Controllers
{
    public class Youtube : Controller
    {
        public IActionResult ApiYoutube()
        {
            return View();
        }
    }
}