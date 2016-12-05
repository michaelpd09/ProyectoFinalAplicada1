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

namespace SistemasDeBancas.Consulta
{
    public partial class ConsultarDetalle : Form
    {
        public ConsultarDetalle()
        {
            InitializeComponent();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.Show();
            Close();
        }

        public List<Detalles> lista = new List<Detalles>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;
           

            if (CamposComboBox.SelectedItem.ToString() == "Id Detalle")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = DetallesBLL.GetLista(Utilidades.ToInt(FiltroTextBox.Text));
                else
                    lista = DetallesBLL.GetLista();
            }
            
            else
            
            {

                lista = DetallesBLL.GetLista();

            }
            DatosDataGridView.DataSource = lista;
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CamposComboBox.SelectedIndex = 0;
        }
    }
}
