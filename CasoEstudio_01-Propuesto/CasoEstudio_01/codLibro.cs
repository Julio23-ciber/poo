using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio_01
{
    public class codLibro
    {
        //Atributos
        private string titulo, autor, estado, sumilla, fecha;
        //propiedades
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Sumilla { get => sumilla; set => sumilla = value; }
        public string Fecha { get => fecha; set => fecha = value; }

    }
}
