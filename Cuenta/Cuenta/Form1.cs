using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (cbntipo.Text == "DEBITO")
            {
                dgvcuentas.Rows.Add(txtcuenta.Text, txtdescripcion.Text,txtmonto.Text,0);
            }

            if (cbntipo.Text == "CREDITO")
            {
                dgvcuentas.Rows.Add(txtcuenta.Text, txtdescripcion.Text,0, txtmonto.Text);
            }

            Double totaldebito = 0;
            foreach (DataGridViewRow suma in dgvcuentas.Rows)
            {
                totaldebito += Convert.ToDouble(suma.Cells["Column3"].Value);
            }
            txtdebito.Text = Convert.ToString(totaldebito);

            Double totalcredito = 0;
            foreach (DataGridViewRow suma in dgvcuentas.Rows)
            {
                totalcredito += Convert.ToDouble(suma.Cells["Column4"].Value);
            }
            txtcredito.Text = Convert.ToString(totalcredito);

            txtcuenta.Clear();
            txtdescripcion.Clear();
            txtmonto.Clear();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcuenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtdescripcion.Focus();
        }

        private void txtdescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cbntipo.Focus();
        }

        private void cbntipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtmonto.Focus();
        }

        private void txtmonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnagregar.Focus();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
