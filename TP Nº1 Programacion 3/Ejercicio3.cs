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
    public partial class Ejercicio3 : Form
    {
        private frmMain FrmMain { get; set; }
        public Ejercicio3(frmMain frmMain)
        {
            this.FrmMain = frmMain;
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            FrmMain.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Ejercicio3_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Show();
        }
    }
}
