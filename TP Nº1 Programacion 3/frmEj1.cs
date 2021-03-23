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
    }
}
