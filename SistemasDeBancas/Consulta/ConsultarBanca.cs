using BLL;
using Entidades;
using SistemasDeBancas.Modificaciones;
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
            EliminarButton.Enabled = true;
            EditarButton.Enabled = true;
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            CamposComboBox.SelectedIndex = 0;
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                var modificarBanca = new ModificarBanca();
                modificarBanca.Show();
              
                modificarBanca.BancaIDTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                modificarBanca.NombreTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                modificarBanca.DireccionTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                modificarBanca.TelefonomaskedTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                modificarBanca.rnctextBox.Text = DatosDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay Usuario para Modificar");

            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int BancaId = Convert.ToInt32(DatosDataGridView.CurrentRow.Cells["BancaId"].Value);
                    BancasBLL.Eliminar(BancaId);
                    lista = BancasBLL.GetLista();
                    FiltroTextBox.Clear();

                }
            }
            else
            {
                return;

            }
            DatosDataGridView.DataSource = lista;
        }
    }
}
