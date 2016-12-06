using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas.Registros
{
    public partial class RegisttroDeLaBanca : Form
    {
        public RegisttroDeLaBanca()
        {
            InitializeComponent();
        }

        private void RegisttroDeLaBanca_Load(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Enabled = true;
            DireccionTextBox.Enabled = true;
            TelefonomaskedTextBox.Enabled = true;
            GuardarButton.Enabled = true;
            rnctextBox.Enabled = true;
           

            NombreTextBox.Clear();
            DireccionTextBox.Clear();
            TelefonomaskedTextBox.Clear();
            rnctextBox.Clear();
            NombreTextBox.Focus();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
