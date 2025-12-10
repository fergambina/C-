using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(); 
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.FechaNacimiento = dtpFechaNacimiento.Value.ToString();
            persona.Email = txtEmail.Text;
            if (rdbArgentino.Checked)
                persona.Nacionalidad = "Argentino/a";
            else
                persona.Nacionalidad = "Extranjero/a";

            MessageBox.Show(persona.Saludar());
        }
    }
}
