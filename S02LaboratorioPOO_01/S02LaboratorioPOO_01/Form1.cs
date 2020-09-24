using S02LaboratorioPOO_01.Herencia;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            /* Empleado em = new Empleado(int.Parse(txtCodigoEmpleado.Text),
                     cboTipConEmpleado.SelectedItem.ToString(), double.Parse(txtSueldoEmpleado.Text));
             em.TDoc = cboTipDocEmpleado.SelectedItem.ToString();*/
            Empleado em = new Empleado(int.Parse(txtCodigoEmpleado.Text), cboTipConEmpleado.SelectedItem.ToString(), double.Parse(txtSueldoEmpleado.Text));
            em.NroDoc = txtNumDocEmpleado.Text;
            em.Nom = txtNombresEmpleado.Text;
            em.ApeMat = txtApeMatEmpleado.Text;
            em.ApePat = txtApePatEmpleado.Text;
            em.Dir = txtDireccionEmpleado.Text;

            txtSalida.AppendText("Empleado ------------------------->\r\n");
            txtSalida.AppendText("Codigo "+ em.Cod+ "\r\n");
            txtSalida.AppendText("documento " + em.NroDoc+ "\r\n");
            txtSalida.AppendText("nombres " + em.Nom+ "\r\n");
            txtSalida.AppendText("direccion" + em.Dir + "\r\n");
            txtSalida.AppendText("TContrato" + em.TCont + "\r\n");
            txtSalida.AppendText("Sueldo" + em.Sueldo + "\r\n");
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            Cliente em = new Cliente(cboCatCliente.SelectedItem.ToString(), int.Parse(txtCodigoCliente.Text));
            em.TDoc = cboTipDocCliente.SelectedItem.ToString();
            em.NroDoc = txtNumDocCliente.Text;
            em.Nom = txtNombresCliente.Text;
            em.ApeMat = txtApeMatCliente.Text;
            em.ApePat = txtApePatCliente.Text;
            em.Dir = txtDireccionCliente.Text;

            txtSalida.AppendText("Empleado ------------------------->\r\n");
            txtSalida.AppendText("Codigo " + em.Cod + "\r\n");
            txtSalida.AppendText("documento " + em.NroDoc + "\r\n");
            txtSalida.AppendText("nombres " + em.Nom + "\r\n");
            txtSalida.AppendText("direccion" + em.Dir + "\r\n");
        }
    }
}
