using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatbotAIML_AspNetCore.Models
{
    public class Consulta
    {   //[Required]
        //[Range(1,100,ErrorMessage ="La consulta no puede ser vacia o mayor a 100 caracteres")]
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
    }
}
