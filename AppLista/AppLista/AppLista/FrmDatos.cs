using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLista
{
    public partial class FrmDatos : Form
    {
        List<ClsLista> MiLista = new List<ClsLista>();
        public FrmDatos()
        {
            InitializeComponent();
            tslConsultar.Enabled = false;
            tslEliminar.Enabled = false;
        }

        private void tslRegistrar_Click(object sender, EventArgs e)
        {
            if(ValidarNombre() == false)
            { 
                return;
            }
            if(ValidarNumero() == false) 
            {
                return;
            }
            if (Existe(txtNombre.Text))
            {
                erpError.SetError(txtNombre, "El número con ese nombre ya esta registrado");
                LimpiarControles();
                txtNombre.Focus();
                return;
            }
            erpError.SetError(txtNombre, "");

            //Creación el objeto de la clase lista
            ClsLista miNumero = new ClsLista();
            miNumero.Nombre = txtNombre.Text;
            miNumero.Numero = double.Parse(txtNumero.Text);
            //Agregar objeto en la lista
            MiLista.Add(miNumero);
            //Agregar lista en el Data Grid View
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = MiLista;
            LimpiarControles();
            txtNombre.Focus();
            tslConsultar.Enabled = true;
        }
        //Método que valida que no ingresen con el mismo nombre
        private bool Existe(string Nombre)
        {
            foreach (ClsLista miNumero in MiLista)
            {
                if(miNumero.Nombre == Nombre)
                    {
                        return true; 
                    }
            }
            return false;
        }

        //Validar el nombre
        private bool ValidarNombre()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
                {
                erpError.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Clear();
                txtNombre.Focus();
                return false;
                }
            else 
            {
                erpError.SetError(txtNombre, "");
                return true;
            }
        }

        //Validar el número
        private bool ValidarNumero()
        {
            double Numero;
            if (!double.TryParse(txtNumero.Text, out Numero) || txtNumero.Text == "")
            {
                erpError.SetError(txtNumero, "Debe ingresar un valor númerico");
                txtNumero.Clear();
                txtNumero.Focus();
                return false;
            }
            else
            {
                erpError.SetError(txtNumero, "");
                return true;
            }
        }

        //Metodo para limpiar controles
        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtNumero.Clear();
        }

        private void tslSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tslConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarNombre() == false) 
            {
                return;
            }
            ClsLista miNumero = GetIndice(txtNombre.Text);
            if (miNumero == null) 
            {
                erpError.SetError(txtNombre, "El Indice no está registrado en la lista");
                LimpiarControles();
                txtNombre.Focus();
                return;
            }
            else 
            {
                erpError.SetError(txtNombre, "");
                txtNombre.Text = miNumero.Nombre;
                txtNumero.Text = miNumero.Numero.ToString();
                tslEliminar.Enabled = true;
            }
            
        }
        //Método obtener o consultar Indice
        private ClsLista GetIndice(string Nombre)
        {
            return MiLista.Find(Indice => Indice.Nombre.Contains(Nombre));
        }
        //Evento de la opción eliminar
        private void tslEliminar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") 
            {
                erpError.SetError(txtNombre, "Debe consultar el número a eliminar");
                LimpiarControles();
                txtNombre.Focus();
                tslEliminar.Enabled = false;
                return;
            }
            else 
            {
                erpError.SetError(txtNombre, "");
                DialogResult Respuesta = MessageBox.Show("Esta seguro de eliminar el registro?",
                "Configuración", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (Respuesta == DialogResult.Yes) 
                {
                    foreach (ClsLista miNumero in MiLista)
                    {
                        if(miNumero.Nombre == txtNombre.Text) 
                        {
                            MiLista.Remove(miNumero);
                            break;
                        }
                    }
                    LimpiarControles();
                    dgvDatos.DataSource = null;
                    dgvDatos.DataSource = MiLista;
                }
            }
        }
    }
}
