using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;


namespace Ejercicio__1_Postres
{
    public partial class Agregar : Form
    {

        private Class1 objProce = null;
        public Agregar()
        {
            InitializeComponent();
             objProce = new Class1();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i = 0;
            this.AgregarPostre(this.txtNomPostre.Text.Trim());
            
            
        }

        private void AgregarPostre(string postre)
        {

            if (objProce.i2 == 6)
            {
                MessageBox.Show("Error", "EL arreglo esta lleno ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objProce.AgregarPostre(postre);
            }

          
               
        }

 
    }
}
