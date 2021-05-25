using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiform
{
    public partial class Inicio : Form
    {
        public static string NombreUsuario = "BIOMEDICSSA";
        public static string  ContraseñaUsuario = "Electrocardiografo86"; 
        public Inicio()
        {
            InitializeComponent();
            UserTxtBox2.Text= "";
            UserTxtBox2.PasswordChar = '*';
            UserTxtBox2.MaxLength = 20;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            label1.Visible = false;

        }

        private void userTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void contra_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            //userTxtBox.Text = NombreUsuario;

            if (userTxtBox.Text == NombreUsuario && UserTxtBox2.Text == ContraseñaUsuario)
            {
                label1.Visible = true;
                label1.Text = " Hola de nuevo " + NombreUsuario ;
                MessageBox.Show(" El inventario esta listo " + NombreUsuario);
                

                try
                {
                    this.Hide();//ayuda a ocultar el formulario 
                    HOLA FormularioPrincipal = new HOLA();
                    FormularioPrincipal.Show();

                    Inicio LoginForm = new Inicio();
                    LoginForm.Close();
                    

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else if (userTxtBox.Text == NombreUsuario )  {
                MessageBox.Show("Contraseña Incorrecta");
            }
            else if (UserTxtBox2.Text == " HelloWorld")
            {
                MessageBox.Show("Ingresa un usuario valido");
            }
            else
            {
                MessageBox.Show("USUARIO OCONTRASEÑA INCORRECTOS");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
                
        }
    }
}
