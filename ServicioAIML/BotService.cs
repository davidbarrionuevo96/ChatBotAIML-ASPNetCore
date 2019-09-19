using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMLbot;
namespace ServicioAIML
{
    public class BotService
    {
        public Bot AI = new Bot();
        

        public string Responder(string pregunta)
        {
            #region configuraciones
            AI.loadSettings(); // config folder carga las configuraciones desde la carpeta config

            AI.loadAIMLFromFiles(); // carga los archivos AIML desde la carpeta aiml

            AI.isAcceptingUserInput = false; // evita que entren valores mientras el bot carga
            #endregion

            User Usuario = new User("Username", AI);//crea un nuevo usuario "algo", usando la informacion del objeto ai

            AI.isAcceptingUserInput = true; // permite de nuevo que el usuario pueda preguntar

            Request r = new Request(pregunta, Usuario, AI); 

            Result res = AI.Chat(r); // mando el objeto request para que la ia responda
            return res.Output;// res.Output es la respuesta en string del bot
            

        }

    }
}
