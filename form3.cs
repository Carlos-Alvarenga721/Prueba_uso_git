using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace L0GIN
{
    public partial class Login : Form
    {
        string contraseña;
        public Login()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string usuario = txtnombre.Text;
            string contra = txtcontraseña.Text;
            string url = "C:\\Users\\ialva\\Desktop\\Login\\" + usuario + ".txt"; 
            if (File.Exists(url))
            {
                MessageBox.Show("ERROR. ¡Usuario ya existe!");
                txtnombre.Clear(); 
                txtcontraseña.Clear();
            }
            else
            {
                File.WriteAllText(url, contra);
                MessageBox.Show("Usuario Registrado con éxito");
                txtnombre.Clear();
                txtcontraseña.Clear();
            }
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string Nombre = txtnombre.Text;
            string contra = txtcontraseña.Text;
            string url = "C:\\Users\\ialva\\Desktop\\Login\\" + Nombre + ".txt";
            if (File.Exists(url))
            {
                contraseña = File.ReadAllText(url); //lee el texto almacenado dentro del archivo
                if (contra.Equals(contraseña))
                {
                    MessageBox.Show("¡Ingreso exitoso, bienvenido!");
                    Vehiculos menu = new Vehiculos();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("¡Contraseña incorrecta!  ");
                }
            }
            else
            { 
             MessageBox.Show("¡Usuario incorrecto! ");
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {//puse una advertencia para decirle al usuario si realmente desea salir de la aplicaccion
            if (MessageBox.Show("Desea salir de la aplicacion?", "Aviso", MessageBoxButtons.YesNo,
              MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
