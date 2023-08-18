using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio__1_Postres
{
    public partial class Frm_AccionProducto : Form
    {
        public Frm_AccionProducto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.MostrarPantallaPrincipal();
        }
        private void MostrarPantallaPrincipal()
        {
            try
            {
                Form1 frm2 = new Form1();
                frm2.ShowDialog();
                frm2.Dispose();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
