using persona.Entidades;
using persona.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clspersona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            clspersona.Nombre = "Martin";

            Console.WriteLine(nclspersona.Hablar(clspersona));

            Console.ReadLine();
        }
    }
}
