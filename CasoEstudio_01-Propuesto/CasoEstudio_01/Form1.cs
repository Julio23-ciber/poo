using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasoEstudio_01
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            codLibro codLibro = new codLibro();
            codLibro.Titulo = txtTitulo.Text;
            codLibro.Autor = txtAutor.Text;
            codLibro.Fecha = dateAño.Text;
            codLibro.Estado = txtEstado.Text;
            codLibro.Sumilla = txtSumilla.Text;
            //codigo de datagridview
            //adicionando filas
            int n = dgwLibros.Rows.Add();
            //donde se coloca la informacion
            dgwLibros.Rows[n].Cells[0].Value = codLibro.Titulo;
            dgwLibros.Rows[n].Cells[1].Value = codLibro.Autor;
            dgwLibros.Rows[n].Cells[2].Value = codLibro.Fecha;
            dgwLibros.Rows[n].Cells[3].Value = codLibro.Estado;
            dgwLibros.Rows[n].Cells[4].Value = codLibro.Sumilla;
            txtTitulo.Text = "";
            txtSumilla.Text = "";
            txtAutor.Text = "";
            txtEstado.Text = "";
        }

        private void dgwLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (n != -1)
                {
                    dgwLibros.Rows.RemoveAt(n);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No hay libro que eliminar");
               
            }
        }
    }
}
