using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02LaboratorioPOO_01.Herencia
{
    public class Cliente: Persona
    {
        private string cat;

        public Cliente(string cat, int cod):base(cod)
        {
            this.Cat = cat;
        }

        public string Cat { get => cat; set => cat = value; }
    }
}
