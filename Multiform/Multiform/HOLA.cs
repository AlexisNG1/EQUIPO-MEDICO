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
    public partial class HOLA : Form
    {
        List<Inventario> ListaInventario = new List<Inventario>();
        
        public HOLA()
        {
            InitializeComponent();
            TxtEquipo.Text = "";
            TxtMarca.Text = "";
            TxtNombre.Text = "";
            TxtNS.Text = "";
            TxtEstado.Text = "";
        }

        private void HOLA_Load(object sender, EventArgs e)
        {
            Text1.Text = "Usuario: " + Inicio.NombreUsuario ;
            Text2.Text = "Comience la captura del inventario";
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_Click(object sender, EventArgs e)
        {

        }

        private void Añadirbtn_Click(object sender, EventArgs e)
        {
            Inventario nombre = new Inventario();
            nombre.NombreEquipo = TxtNombre.Text;
            nombre.Numeroserie = Convert.ToInt32(TxtNS.Text);
            nombre.EquipoMed = TxtEquipo.Text;
            nombre.MarcaEquipo = TxtMarca.Text;
            nombre.EstadoEquipo = TxtEstado.Text;

            ListaInventario.Add(nombre);
            TxtNombre.Text = String.Empty;
            TxtEstado.Text = String.Empty;
            TxtMarca.Text = String.Empty;
            TxtNS.Text = string.Empty;
            TxtEquipo.Text = String.Empty;

            MessageBox.Show("Equipo médico agregado exitosamente al inventario");
        }

        private void Mostrar_Click(object sender, EventArgs e)
        {
            //Limpiamos el list
            Inventario.Items.Clear();
            foreach (Inventario nombre in ListaInventario)
            {
                ListViewItem item = new ListViewItem();
                item = Inventario.Items.Add(nombre.NombreEquipo);
                item.SubItems.Add(nombre.EquipoMed);
                item.SubItems.Add(nombre.MarcaEquipo);
                item.SubItems.Add(nombre.Numeroserie.ToString());
                item.SubItems.Add(nombre.EstadoEquipo);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
