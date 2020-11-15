using Microsoft.AspNetCore.Mvc;
using Emergency.Client.Models;
using System;

namespace Emergency.Client.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {

        [HttpPost]  
        public ActionResult <EmergencyReport> CreateEmergency(EmergencyReport emergency)  
        {
            return emergency;
        } 
    }
}