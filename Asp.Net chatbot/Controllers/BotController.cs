using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServicioAIML;
namespace Asp.Net_chatbot.Controllers
{
    public class BotController : Controller
    {
        BotService serv = new BotService();
        List<string> res = new List<string>();
        public ActionResult Consutas()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Consultas(string pregunta)
        {
            res.Add(serv.Responder(pregunta));
            return View();
        }
    }
}