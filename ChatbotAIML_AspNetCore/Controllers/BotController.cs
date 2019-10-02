using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChatbotAIML_AspNetCore.Service;
using ChatbotAIML_AspNetCore.Models;
namespace ChatbotAIML_AspNetCore.Controllers
{
    public class BotController : Controller
    {
        public readonly BotService _botService = new BotService();
        public IActionResult ConsultarBot()
        {
            return View(_botService.ObtenerConsultas());
        }
        [HttpPost]
        public IActionResult ConsultarBot(string consulta)
        {
                ViewData["Respuesta"] = _botService.ConsultarBot(consulta);
            
            return View(_botService.ObtenerConsultas());
        }
    }
}