using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02LaboratorioPOO_01.Herencia
{
    public class Persona
    {
        private int cod;
        private string tDoc, nroDoc, nom, apePat, apeMat, dir;

        public Persona(int cod)
        {
            this.cod = cod;
        }
        public int Cod { get => cod; set => cod = value; }
        public string TDoc { get => tDoc; set => tDoc = value; }
        public string NroDoc { get => nroDoc; set => nroDoc = value; }
        public string Nom { get => nom; set => nom = value; }
        public string ApePat { get => apePat; set => apePat = value; }
        public string ApeMat { get => apeMat; set => apeMat = value; }
        public string Dir { get => dir; set => dir = value; }


    }
}
