using Consolas.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consolas
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                Restaurar.Visible = false;
                Maximizar.Visible = true;
            }
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                Maximizar.Visible = false;
                Restaurar.Visible = true;
            }
        }

        private void XboxOneClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AlquilerConsola Frm = new AlquilerConsola(btn.Text, this);
            Frm.Show();
        }
    }
}