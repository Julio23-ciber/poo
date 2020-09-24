using S02LaboratorioPOO_01.Clases_de_Form2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S02LaboratorioPOO_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Datos d = new Datos();
        private void btnCalcAreaCuadrado_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
            d.LCuadrado = double.Parse(txtLadoCuadrado.Text);
            txtSalida.AppendText("La Area del Cuadrado es: " + d.aCuadrado(d.LCuadrado));

        }

        private void btnCalcAreaRectangulo_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
            d.BRect = double.Parse(txtBaseRectangulo.Text);
            d.HRect = double.Parse(txtAlturaRectangulo.Text);
            txtSalida.AppendText("La Area del rectangulo es: " + d.aRectangulo(d.BRect, d.HRect));
        }

        private void btnCalcAreaTriangulo_Click(object sender, EventArgs e)
        {
            txtSalida.Clear();
            d.BTri = double.Parse(txtBaseTriangulo.Text);
            d.HTri = double.Parse(txtAlturaTriangulo.Text);
            txtSalida.AppendText("La altura del triangulo es: " + d.aTriangulo(d.BTri, d.HTri));
        } 
    }
}
