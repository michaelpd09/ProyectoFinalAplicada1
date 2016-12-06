using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas.Modificaciones
{
    public partial class ModificarBanca : Form
    {
        public ModificarBanca()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            BancasBLL.Modificar(new Bancas()
            {
                BancaId = Convert.ToInt32(BancaIDTextBox.Text),
                Nombre = NombreTextBox.Text,
                Direccion = DireccionTextBox.Text,
                Telefono = TelefonomaskedTextBox.Text,
                RNC = rnctextBox.Text,
            });

            DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
            Close();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
