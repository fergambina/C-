using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Negro");
            cboColor.Items.Add("Azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string basquet = ckbBasquet.Checked == true ? "Le gusta el basquet" : "Odia el basquet";
            string tipo;
            if (rbtMaggle.Checked)
                tipo = "Maggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";
            string colorFavorito = cboColor.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString(); //Capturo el numero favorito
            string mensaje = "Nombre: " + nombre + "Apellido: " + apellido + "Fecha de nacimiento: " + fecha;

            MessageBox.Show(mensaje);
        }
    }
}
