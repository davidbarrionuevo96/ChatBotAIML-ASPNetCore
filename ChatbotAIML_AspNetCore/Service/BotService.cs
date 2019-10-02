using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIMLbot;
using ChatbotAIML_AspNetCore.Models;

namespace ChatbotAIML_AspNetCore.Service
{
    public class BotService
    {
        Bot AI = new Bot();//Define el objeto AI para mantener la informaicon del bot

        User usuario;
        static List<Consulta> consultas = new List<Consulta>();
        public string ConsultarBot(string consultaUsuario)
        {
            //Crea un nuevo usuario llamado Cliente, usando la informacion del objeto AI
            usuario = new User("Cliente", AI);

            AI.loadSettings(); // Carga la configuracion de la carpeta config

            AI.loadAIMLFromFiles(); // Carga los archivos AIML desde la carpeta aiml

            AI.isAcceptingUserInput = true; // Permite que el usuario pueda ingresar valores

            Request r = new Request(consultaUsuario, usuario, AI);//Genera el request usando la consulta string que entra
            
            Result res = AI.Chat(r);//Manda el request al objeto ia para que pueda responder basado en los archivos de aiml

            Consulta _con = new Consulta()
            {
                Pregunta = consultaUsuario,
                Respuesta=res.Output            
            };
            consultas.Add(_con);

            return res.Output;
        }
        public List<Consulta> ObtenerConsultas()
        {
            return consultas;
        }
    }
}
