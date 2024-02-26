using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola GitHub");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("Mensaje Borrar / Alejo gei", "información", MessageBoxButtons.OKCancel);
            if (mensaje == DialogResult.OK)
            {

                MessageBox.Show("En efecto");
            }
            else
            {
                MessageBox.Show("No","Información");

            }
                   
        }
    }
}
