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
        public FrmSocios()
        {
            InitializeComponent();
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
    }
}
