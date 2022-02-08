using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consolas.Views
{
    public partial class AlquilerConsola : Form
    {
        public double PrecioxMin = 0.33333333333333333333333333333333;
        public string Cliente;
        public string consola;
        public string Tiempo;
        public string Pago;
        public DateTime HoraInicio;
        public DateTime HoraFinal;
        public Label Lbl = new Label();
        public Menu menu1 = new Menu();
        public AlquilerConsola(string Consola, Menu menu)
        {
            InitializeComponent();
            TxtConsola.Text = Consola;
            consola = Consola;
            menu1 = menu;
            CmbTiempo.Items.Add("30 Min");
            CmbTiempo.Items.Add("60 Min");
            CmbTiempo.Items.Add("90 Min");
            CmbTiempo.Items.Add("120 Min");
            CmbTiempo.Items.Add("150 Min");
            CmbTiempo.Items.Add("Otro...");
            CmbTiempo.SelectedIndex = 0;
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CmbTiempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbTiempo.Text == "Otro...")
            {
                TxtTiempo.Visible = true;
                TxtTiempo.Focus();
                LblMontoPago.Text = $"Monto a pagar: C$";
            }
            else
            {
                TxtTiempo.Visible = false;
                Tiempo = int.Parse(CmbTiempo.Text.Substring(0, 3)).ToString();
                Pago = (int.Parse(CmbTiempo.Text.Substring(0, 3)) * PrecioxMin).ToString();
                LblMontoPago.Text = $"Monto a pagar: C$ {Pago}";
            }
        }

        private void TxtTiempo_TextChanged(object sender, EventArgs e)
        {
            if (TxtTiempo.Text == "")
            {
                LblMontoPago.Text = $"Monto a pagar: C$";
            }
            else
            {
                Pago = ((int.Parse(TxtTiempo.Text)) * PrecioxMin).ToString();
                Tiempo = TxtTiempo.Text;
                LblMontoPago.Text = $"Monto a pagar: C$ {Pago}";
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El tiempo ha empezado a correr!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            HoraInicio = DateTime.Now;
            HoraFinal = HoraInicio.AddMinutes(int.Parse(Tiempo));

            if (consola.ToString() == "Xbox One 1")
            {
                menu1.LblXboxOne1.Text = $"Cliente: {Cliente}" +
                    $"\nTiempo: {Tiempo} Min" +
                    $"\nPago: C$ {Pago}" +
                    $"\nInicio: {String.Format("{0:hh:mm tt}", HoraInicio)}" +
                    $"\nFinal: {String.Format("{0:hh:mm tt}", HoraFinal)}";
            }
            else if (consola.ToString() == "Xbox One 2")
            {
                menu1.LblXboxOne2.Text = $"Cliente: {Cliente}" +
                    $"\nTiempo: {Tiempo} Min" +
                    $"\nPago: C$ {Pago}" +
                    $"\nInicio: {String.Format("{0:hh:mm tt}", HoraInicio)}" +
                    $"\nFinal: {String.Format("{0:hh:mm tt}", HoraFinal)}";
            }
            else if (consola.ToString() == "Xbox One 3")
            {
                menu1.LblXboxOne3.Text = $"Cliente: {Cliente}" +
                    $"\nTiempo: {Tiempo} Min" +
                    $"\nPago: C$ {Pago}" +
                    $"\nInicio: {String.Format("{0:hh:mm tt}", HoraInicio)}" +
                    $"\nFinal: {String.Format("{0:hh:mm tt}", HoraFinal)}";
            }
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            Cliente = TxtCliente.Text;
        }
    }
}