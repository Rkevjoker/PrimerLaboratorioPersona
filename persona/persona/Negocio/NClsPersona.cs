using persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona persona)
        {
            persona.Nombre = "Martin";

            return "la persona" + persona.Nombre + "esta hablando";
        }
        public String Caminar(ClsPersona persona)
        {
            persona.Nombre = "Martin";
            return "la persona llamada" + persona.Nombre + " esta caminando";
        }
        public String Reir(ClsPersona persona)
        {
            persona.Nombre = "Martin";
            return "la persona de nombre" + persona.Nombre + "se esta riendo";
        }
        public String Observar(ClsPersona persona)
        {
            persona.Nombre = "Martin";
            return "la persona llamada" + persona.Nombre + "te esta observando";

        }
    }
}
