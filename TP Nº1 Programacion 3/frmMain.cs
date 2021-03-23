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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmEj1 = new frmEj1(this);
            frmEj1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmEj2 = new frmEj2(this);
            frmEj2.Show();
        }
    }
}
