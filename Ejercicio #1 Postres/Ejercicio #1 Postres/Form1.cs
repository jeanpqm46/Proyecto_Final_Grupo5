using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Ejercicio__1_Postres
{
    public partial class Form1 : Form
    {
        public string[] Postres = new string[5];
        public int contaAgregar = 0;
        public int contaEliminar = 0;
        public int contaIngrediente = 0;
        public int contaprueba = 0;
        public int i3 = 0;
        public List<string> lista1 = new List<string>();
        public List<string> lista2 = new List<string>();
        public List<string> lista3 = new List<string>();
        public List<string> lista4 = new List<string>();
        public List<string> lista5 = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarPostre();
        }
        private void AgregarPostre()
        {
            txtPostres.Visible = true;
            for (int i = 0; i < Postres.Length; i++)
            {
                    

                if (Postres[i] == null)
                {
                    if (txtAgregar.Text == "")
                    {
                        MessageBox.Show("No se pueden ingresar campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                   
                     Postres[i] = txtAgregar.Text.Trim();
                    txtPostres.Text = "Los postres agregados son:";
                    for (int i2 = 0; i2 < Postres.Length; i2++)
                    {
                        txtPostres.Text = txtPostres.Text + "  " + Postres[i2];

                    }

                    //label8.Text = label8.Text + i + " " + Postres[i];
                    contaAgregar = contaAgregar + 1;
                    break;
                }

                if (contaAgregar == 5) {
                    MessageBox.Show("El arreglo esta lleno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }



            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliminarPostre();
        }

        private void EliminarPostre()
        {
            for (int i = 0; i < Postres.Length; i++)
            {
                if (Postres[i] == txtEliminar.Text)
                {

                    Postres[i] = null;
                    
                    if (i == 0)
                    {
                        lista1.Clear();

                    }
                    else if (i == 1)
                    {
                        lista2.Clear();
                    }
                    else if (i == 2)
                    {
                        lista3.Clear();
                    }
                    else if (i == 3) 
                    {  
                        lista4.Clear();
                    }
                    else if (i == 4)
                    {
                        lista5.Clear();
                    }
                    txtPostres.Text = "Los postres agregados son:";
                    for (int i2 = 0; i2 < Postres.Length; i2++)
                    {
                        txtPostres.Text = txtPostres.Text + "  " + Postres[i2];

                    }
                    break;

                }
                contaEliminar = contaEliminar + 1;
                if (contaEliminar == 5)
                {
                    MessageBox.Show("No se encontro ningun postre con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contaEliminar = 0;
                    break;


                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EliminarIngrediente();
        }

        private void EliminarIngrediente()
        {
            for (int i = 0; i < Postres.Length; i++)
            {
                if (Postres[i] == txtSeleccion.Text)
                {
                    if (i == 0)
                    {
                        for(int i2 = 0;i2 < lista1.Count; i2++)
                        {
                            if (lista1[i2] == txtIngredientes.Text)
                            {
                                lista1.Remove(txtIngredientes.Text.Trim());
                                txtImprimir.Text = "Los ingredientes del postre son:";
                                contaprueba = 0;
                                break;

                            }
                            contaprueba = contaprueba + 1;
                            if(contaprueba == lista1.Count)
                            {
                                MessageBox.Show("No se encontro ingrediente con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                contaprueba = 0;
                                break;
                            }

                            
                        }
                            
                    }
                    else if (i == 1)
                    {
                        for (int i2 = 0; i2 < lista2.Count; i2++)
                        {
                            if (lista2[i2] == txtIngredientes.Text)
                            {
                                lista2.Remove(txtIngredientes.Text.Trim());
                                txtImprimir.Text = "Los ingredientes del postre son:";
                                contaprueba = 0;
                                break;

                            }
                            contaprueba = contaprueba + 1;
                            if (contaprueba == lista2.Count)
                            {
                                MessageBox.Show("No se encontro ingrediente con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                contaprueba = 0;
                                break;
                            }


                        }
                    }
                    else if (i == 2)
                    {
                        for (int i2 = 0; i2 < lista3.Count; i2++)
                        {
                            if (lista3[i2] == txtIngredientes.Text)
                            {
                                lista3.Remove(txtIngredientes.Text.Trim());
                                txtImprimir.Text = "Los ingredientes del postre son:";
                                contaprueba = 0;
                                break;

                            }
                            contaprueba = contaprueba + 1;
                            if (contaprueba == lista3.Count)
                            {
                                MessageBox.Show("No se encontro ingrediente con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                contaprueba = 0;
                                break;
                            }


                        }
                    }
                    else if (i == 3)
                    {
                        for (int i2 = 0; i2 < lista4.Count; i2++)
                        {
                            if (lista4[i2] == txtIngredientes.Text)
                            {
                                lista4.Remove(txtIngredientes.Text.Trim());
                                txtImprimir.Text = "Los ingredientes del postre son:";
                                contaprueba = 0;
                                break;

                            }
                            contaprueba = contaprueba + 1;
                            if (contaprueba == lista4.Count)
                            {
                                MessageBox.Show("No se encontro ingrediente con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                contaprueba = 0;
                                break;
                            }


                        }
                    }
                    else if (i == 4)
                    {
                        for (int i2 = 0; i2 < lista5.Count; i2++)
                        {
                            if (lista5[i2] == txtIngredientes.Text)
                            {
                                lista5.Remove(txtIngredientes.Text.Trim());
                                txtImprimir.Text = "Los ingredientes del postre son:";
                                contaprueba = 0;
                                break;

                            }
                            contaprueba = contaprueba + 1;
                            if (contaprueba == lista5.Count)
                            {
                                MessageBox.Show("No se encontro ingrediente con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                contaprueba = 0;
                                break;
                            }


                        }
                    }
                    contaIngrediente = 0;
                    break;

                }
                contaIngrediente = contaIngrediente + 1;
                if (contaIngrediente == 5)
                {
                    MessageBox.Show("No se encontro ningun postre con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contaEliminar = 0;
                    break;


                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblPostre.Text = "El postre seleccionado es: " + txtSeleccion.Text;
            txtImprimir.Text = "Los ingredientes del postre son:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtImprimir.Visible = true;
            VerIngredientes();
        }

        private void VerIngredientes()
        {
            
            for (int i = 0; i < Postres.Length; i++)
            {
                if (Postres[i] == txtSeleccion.Text)
                {
                    if (i == 0)
                    {
                        for (int i2 = 0; i2 < lista1.Count; i2++)
                        {
                            txtImprimir.Text = txtImprimir.Text +", "+lista1[i2];
                            
                        }
                    }
                    else if (i == 1) 
                    {
                        for (int i2 = 0; i2 < lista2.Count; i2++)
                        {
                            txtImprimir.Text = txtImprimir.Text + ", " + lista2[i2];
                            
                        }
                    }

                    else if (i == 2)
                    {
                        for (int i2 = 0; i2 < lista3.Count; i2++)
                        {
                            txtImprimir.Text = txtImprimir.Text + ", " + lista3[i2];
                        }
                    }

                    else if (i == 3)
                    {
                        for (int i2 = 0; i2 < lista4.Count; i2++)
                        {
                            txtImprimir.Text = txtImprimir.Text + ", " + lista4[i2];
                        }
                    }

                    else if (i == 4)
                    {
                        for (int i2 = 0; i2 < lista5.Count; i2++)
                        {
                            txtImprimir.Text = txtImprimir.Text + ", " + lista5[i2];
                        }
                    }
                    contaEliminar = 0;
                    break;

                }
                contaEliminar = contaEliminar + 1;
                if (contaEliminar == 5)
                {
                    MessageBox.Show("No se encontro ningun postre con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contaEliminar = 0;
                    break;


                }

            }

        }

        private void btnIngrediente_Click(object sender, EventArgs e)
        {
            AgregarIngrediente();
        }
        private void AgregarIngrediente()
        {
            for (int i = 0; i < Postres.Length; i++)
            {
                if (Postres[i] == txtSeleccion.Text)
                {
                    if (i == 0)
                    {
                        lista1.Add(txtIngredientes.Text.Trim());
                        txtImprimir.Text = "Los ingredientes del postre son:";
                    }
                    else if (i == 1) 
                    {
                        lista2.Add(txtIngredientes.Text.Trim());
                        txtImprimir.Text = "Los ingredientes del postre son:";
                    }
                    else if (i == 2)
                    {
                        lista3.Add(txtIngredientes.Text.Trim());
                        txtImprimir.Text = "Los ingredientes del postre son:";
                    }
                    else if (i == 3)
                    {
                        lista4.Add(txtIngredientes.Text.Trim());
                        txtImprimir.Text = "Los ingredientes del postre son:";
                    }
                    else if (i == 4)
                    {
                        lista5.Add(txtIngredientes.Text.Trim());
                        txtImprimir.Text = "Los ingredientes del postre son:";
                    }
                    contaIngrediente  = 0;
                    break;
                    
                }   
                contaIngrediente = contaIngrediente + 1;
                if (contaIngrediente == 5)
                  {
                    MessageBox.Show("No se encontro ningun postre con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contaEliminar = 0;
                    break;


                   }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPostres();
        }

        private void VerPostres()
        {
            txtPostres.Visible = true;
            txtPostres.Text = "Los postres agregados son:";
            for (int i2 = 0; i2 < Postres.Length; i2++)
            {
                txtPostres.Text = txtPostres.Text + "  " + Postres[i2];

            }
        }
    }//
}//
