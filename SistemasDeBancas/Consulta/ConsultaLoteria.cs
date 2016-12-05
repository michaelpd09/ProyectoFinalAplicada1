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
    public partial class ConsultaLoteria : Form
    {
        public ConsultaLoteria()
        {
            InitializeComponent();
        }

        public List<Loterias> lista = new List<Loterias>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;

            if (CamposComboBox.SelectedItem.ToString() == "Id Loteria")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = LoteriasBLL.GetListaLoteriaID(Utilidades.ToInt(FiltroTextBox.Text));
                else
                    lista = LoteriasBLL.GetLista();
            }
            else
            if (CamposComboBox.SelectedItem.ToString() == "Nombre")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = LoteriasBLL.GetListaLoterias(FiltroTextBox.Text);
                else
                    lista = LoteriasBLL.GetLista();
            }
            else
            {

                lista = LoteriasBLL.GetLista();

            }
            DatosDataGridView.DataSource = lista;
            EliminarButton.Enabled = true;
            EditarButton.Enabled = true;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            var registrarLoteria = new RegistrarLoteria();
            registrarLoteria.Visible = true;
            Close();
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
        
            if (DatosDataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int LoteriaId = Convert.ToInt32(DatosDataGridView.CurrentRow.Cells["IdLoteria"].Value);
                    LoteriasBLL.Eliminar(LoteriaId);
                    lista = LoteriasBLL.GetLista();
                    FiltroTextBox.Clear();
                }
            }
            else
            {
                MessageBox.Show("No hay Dato para Borrar");

            }
            DatosDataGridView.DataSource = lista;
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                var modificarLoteria = new ModificarLoteria();
                modificarLoteria.Show();
                
                modificarLoteria.IdLoteriatextBox.Text = DatosDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                modificarLoteria.NombretextBox.Text = DatosDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                modificarLoteria.MontoPrimeratextBox.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                modificarLoteria.MontoSegundatextBox.Text = DatosDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                modificarLoteria.MontoTerceratextBox.Text = DatosDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                modificarLoteria.MontoPale1textBox.Text = DatosDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                modificarLoteria.MontoPale2textBox.Text = DatosDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                modificarLoteria.MontoTripleta1textBox.Text = DatosDataGridView.SelectedRows[0].Cells[7].Value.ToString();
                modificarLoteria.MontoTripleta2textBox.Text = DatosDataGridView.SelectedRows[0].Cells[8].Value.ToString();
                modificarLoteria.HoraApecturadateTimePicker.Text = DatosDataGridView.SelectedRows[0].Cells[9].Value.ToString();
                modificarLoteria.HoraCierredateTimePicker.Text = DatosDataGridView.SelectedRows[0].Cells[10].Value.ToString();
                modificarLoteria.MaximoQuinielatextBox.Text = DatosDataGridView.SelectedRows[0].Cells[11].Value.ToString();
                modificarLoteria.MaximoPaletextBox.Text = DatosDataGridView.SelectedRows[0].Cells[12].Value.ToString();
                modificarLoteria.MaximoTripletatextBox.Text = DatosDataGridView.SelectedRows[0].Cells[13].Value.ToString();
            }
            else
            {
                MessageBox.Show("No hay Usuario para Modificar");

            }
        }

        private void ConsultaLoteria_Load(object sender, EventArgs e)
        {
            CamposComboBox.SelectedIndex = 0;
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
