using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Entidades;

namespace SistemasDeBancas.Registros
{
    public partial class ModificarUsuarios : Form
    {
        public ModificarUsuarios()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            UsuariosBLL.Modificar(new Usuarios()
            {
                UsuarioID = Convert.ToInt32(UsuarioIDTextBox.Text),
                Nombre = NombreTextBox.Text,
                Clave = ClaveTextBox.Text,
                Tipo = PerfilComboBox.Text,
                Fecha = FechadateTimePicker.Value,
            });

            DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
            Close();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModificarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
