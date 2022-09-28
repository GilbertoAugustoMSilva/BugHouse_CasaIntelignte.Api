using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BugHouse_CasaIntelignte.Api.Controllers
{
    public class ConfigService : Controller
    {


        private string xPassOauth = "MyKeyApiEndPoitn_ArduinoIpSetings_aiofhsfiuohans8342or208930fni0vk";


        [HttpGet("api/v1/GetIp")]
        public IActionResult GetIp()
        {
            return Ok();
        }


        [HttpGet("api/v1/PostLastIp")]
        public IActionResult PostLastIp(string Interface, string Oauth, string User)
        {
            if (Oauth != xPassOauth)
                return Unauthorized();

            var xIdInterface = Interface;
            var xUsuario = User;


           var xIpClient = this.HttpContext.Connection.RemoteIpAddress.ToString();


            return Ok(xIpClient);
        }

    }
}
