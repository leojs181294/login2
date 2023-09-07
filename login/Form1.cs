using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario, contraseña;
            usuario = txtUsuario.Text.Trim();
            contraseña = txtContraseña.Text.Trim();
            if (usuario == "admin" && contraseña == "admin" || usuario == "usuario" && contraseña == "usuario")
            {
                MessageBox.Show("bienvenidos al sistema");
            }
            else
            {
                MessageBox.Show("acceso denegado!!");
            }

            if (usuario == "admin" && contraseña == "admin")
            {
                this.Hide();
                Form2 frm = new Form2();
                frm.ShowDialog();

               // if (frm.ShowDialog() == DialogResult.OK)
                //{
                 //   this.Show();
               // }

            }

            

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           DialogResult= MessageBox.Show("desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }

            //this.Close(); para que cierre de una
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}
