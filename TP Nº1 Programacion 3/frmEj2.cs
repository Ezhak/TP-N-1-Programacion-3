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
    public partial class frmEj2 : Form
    {
        private frmMain FrmMain { get; set; }
        public frmEj2(frmMain frmMain)
        {
            FrmMain = frmMain;
            InitializeComponent();
        }

        private void frmEj2_Load(object sender, EventArgs e)
        {
            FrmMain.Hide();
            listBox1.Sorted = true;
        }

        private void frmEj2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0 || textBoxSurname.Text.Length == 0)
                MessageBox.Show("Nombre o Apellido invalido");
            else
                if (!listBox1.Items.Contains($"{textBoxName.Text} {textBoxSurname.Text}"))
                listBox1.Items.Add($"{textBoxName.Text} {textBoxSurname.Text}");
            else
                MessageBox.Show("Este nombre ya se encuentra en la lista");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }
}
