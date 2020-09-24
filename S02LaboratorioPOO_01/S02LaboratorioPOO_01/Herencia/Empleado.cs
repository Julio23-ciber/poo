using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02LaboratorioPOO_01.Herencia
{
    public class Empleado : Persona
    {
        private string tCont;
        private double sueldo;
        public Empleado(int cod, string tCont, double sueldo) : base(cod)
        {
            this.tCont = tCont;
            this.sueldo = sueldo;
        }
        public string TCont { get => tCont; set => tCont = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }


    }
}
