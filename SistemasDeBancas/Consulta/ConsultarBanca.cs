using BLL;
using Entidades;
using SistemasDeBancas.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas.Consulta
{
    public partial class ConsultarBanca : Form
    {
        public ConsultarBanca()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var registroDeLaBanca = new RegistroDeLaBanca();
            registroDeLaBanca.Show();
            Close();
        }

        public List<Bancas> lista = new List<Bancas>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;
           

            if (CamposComboBox.SelectedItem.ToString() == "Id Detalle")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = BancasBLL.GetLista(Utilidades.ToInt(FiltroTextBox.Text));
                else
                    lista = BancasBLL.GetLista();
            }
            
            else
            
            {

                lista = BancasBLL.GetLista();

            }
            DatosDataGridView.DataSource = lista;
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CamposComboBox.SelectedIndex = 0;
        }
    }
}
