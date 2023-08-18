using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Ejercicio__1_Postres
{
    public partial class Frm_Eliminar : Form
    {
        private Class1 objProce = null;
        public Frm_Eliminar()
        {
            InitializeComponent();
            objProce = new Class1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EliminarPostre();

        }
        private void EliminarPostre()
        {
            for (int i = 0; i < 5; i++)
            {
                if (objProce.Postres[i] == textBox1.Text.Trim())
                {
                    objProce.Postres[i] = "";
                    return;
                    //MessageBox.Show("Proceso completado", "Se elimino correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("Error", "No se encontro ningun postre con ese nombre", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
          
                label3.Text = objProce.Postres[0];
            
        }

       
    }//
}//
