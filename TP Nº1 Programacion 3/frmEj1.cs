using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Nº1_Programacion_3
{
    public partial class frmEj1 : Form
    {
        private Form FrmMain { get; set; }

        public frmEj1(frmMain frmMain)
        {
            this.FrmMain = frmMain;
            InitializeComponent();
        }

        private void frmEj1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Show();
        }

        private void frmEj1_Load(object sender, EventArgs e)
        {
            FrmMain.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (lstBox1.Items.Contains(txtNombre.Text))
                MessageBox.Show("Ya existe ese nombre.", "Error");
            else if (txtNombre.Text.Trim().Length == 0)
                MessageBox.Show("Nombre vacío.", "Error");
            else 
            { 
                lstBox1.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
            }
        }

        private void btnSingular_Click(object sender, EventArgs e)
        {
            if (lstBox1.SelectedItem != null)
            {
                lstBox2.Items.Add(lstBox1.SelectedItem);
                lstBox1.Items.Remove(lstBox1.SelectedItem);
            }
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            foreach (string item in lstBox1.Items)
                lstBox2.Items.Add(item);
            lstBox1.Items.Clear();
        }
    }
}
