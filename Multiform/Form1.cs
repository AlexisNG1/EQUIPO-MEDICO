using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class Form1 : Form
    {
        public static string NombreUsuario = "Athos";
        public static string ContraseñaUsuario = "HelloWorld";

        public Form1()
        {
            InitializeComponent();
            pswTxtBox.Text = "";
            pswTxtBox.PasswordChar = '*';
            pswTxtBox.MaxLength = 24;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void loginBtn_Click(object sender, EventArgs e)

        {
           // userTxtBox.Text = NombreUsuario;
           // pswTxtBox.Text = ContraseñaUsuario;
            if (userTxtBox.Text == NombreUsuario && pswTxtBox.Text == ContraseñaUsuario)
            {
                
                MessageBox.Show("Bienvenido al sistema usuario  " +NombreUsuario);
                Form1 FormularioLogin = new Form1();
               
                try
                {
                    this.Hide();
                    Form2 FormularioPrincipal = new Form2();
                    FormularioPrincipal.Show();

                    Form1 LoginForm = new Form1();
                    LoginForm.Close();


                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }


            }
            else if(userTxtBox.Text == NombreUsuario)
            {
                MessageBox.Show("Contraseña Incorrecta");
            }
            else if (pswTxtBox.Text == "HelloWorld")
            {
                MessageBox.Show("Ingresa un Usuario Valido");
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña Incorrectos ");
            }
        }
    }
}
