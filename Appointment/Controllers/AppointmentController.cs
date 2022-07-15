using Microsoft.AspNetCore.Mvc;
using System;

namespace Appointment.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
           return View();
           /*string todaysDate = DateTime.Now.ToShortDateString();
           return Ok(todaysDate);*/
        }
    }
}
