using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;
            cliente.Dock = DockStyle.Fill;
            PanelCentral.Controls.Clear(); //limpa o Panel
            PanelCentral.Controls.Add(cliente); //Adiciona o Panel
            cliente.Show();
            BtnInicio.Top = BtnClientes.Top;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BtnInicio.Top = BtnAgendamentos.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BtnInicio.Top = BtnServicos.Top;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você Deseja Mesmo?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            //Minimizar
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PanelCentral.Controls.Clear();
            BtnInicio.Top = BtnInicio.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BtnInicio.Top = BtnAnimais.Top;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRacas_Click(object sender, EventArgs e)
        {
            BtnInicio.Top = BtnRacas.Top;
        }
    }
}
