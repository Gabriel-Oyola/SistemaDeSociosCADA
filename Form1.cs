using SistemaDeSociosCADA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeSociosCADA
{
    public partial class FrmSocios : Form
    {
        Persona per = new Persona();

        public ListaSocios Lista { get; set; } = new ListaSocios();
        public FrmSocios()
        {
            InitializeComponent();

            dgSocios.DataSource = Lista.DTS;
        }

        private void FrmSocios_Load(object sender, EventArgs e)
        {
            cbCarnet.Items.Add("Niño/a $600");
            cbCarnet.Items.Add("Juvenil $800"); 
            cbCarnet.Items.Add("Adulto $1200");

            cbPlatea.Items.Add("Norte");
            cbPlatea.Items.Add("Sur");
            cbPlatea.Items.Add("Este");
            cbPlatea.Items.Add("Oeste");

            cbEstado.Items.Add("Habilitado");
            cbEstado.Items.Add("Inhablitado");

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            per.Nombre = txtNombre.Text;
            per.Apellido = txtApellido.Text;
            per.Nacimiento = txtNacimiento.Text;
            per.Edad = Convert.ToInt32(txtEdad.Text);
            per.Documento = txtDocumento.Text;
            per.Domicilio = txtDomicilio.Text;
            per.Carnet = (string)cbCarnet.SelectedItem;
            per.Platea = (string)cbPlatea.SelectedItem;
            per.Estado = (string)cbEstado.SelectedItem;
            per.DiaModificacion = DateTime.Now.ToShortDateString();

            if (!Lista.UpdatePersona(per))
            {
                txtEdad.Focus();
                txtEdad.SelectAll();
                MessageBox.Show("Edad no validad, intente de nuevo");
              
            }
            else
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtNacimiento.Text = "";
                txtEdad.Text = "";
                txtDocumento.Text = "";
                txtDomicilio.Text = "";
                cbCarnet.Text = "";
                cbPlatea.Text = "";
                cbEstado.Text = "";
                txtNombre.Focus();
                
            }
            per = new Persona();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            per = Lista.BuscarPersona(Convert.ToInt32(txtBuscar.Text));

            if (per.NumSocio>0)
            {
                txtNombre.Text = per.Nombre;
                txtApellido.Text = per.Apellido;
                txtNacimiento.Text = per.Nacimiento;
                txtEdad.Text = per.Edad.ToString();
                txtDocumento.Text = per.Documento;
                txtDomicilio.Text = per.Domicilio;
                cbCarnet.Text = per.Carnet;
                cbPlatea.Text = per.Platea;
                cbEstado.Text = per.Estado;

                txtNombre.Focus();
                txtBuscar.Text = "";
            }
            else
            {
                txtBuscar.Text = "La persona no existe";
                txtBuscar.Focus();
                txtBuscar.SelectAll();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.DeletePersona(per))
            {
                limpiar();
            }
            else
            {
                MessageBox.Show("El registro" + per.NumSocio + "no se pudo borrar");
                limpiar();
            }
            per = new Persona();

        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNacimiento.Text = "";
            txtEdad.Text = "";
            txtDocumento.Text = "";
            txtDomicilio.Text = "";
            cbCarnet.Text = "";
            cbPlatea.Text = "";
            cbEstado.Text = "";

        }
    }
}
