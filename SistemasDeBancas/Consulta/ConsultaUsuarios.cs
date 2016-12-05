using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace SistemasDeBancas.Consulta
{
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        public List<Usuarios> lista = new List<Usuarios>();

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;
           
            if (CamposComboBox.SelectedItem.ToString() == "UsuarioID")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = UsuariosBLL.GetListaUsuarioID(Utilidades.ToInt(FiltroTextBox.Text));
                else
                    lista = UsuariosBLL.GetLista();
            }
            else
            if(CamposComboBox.SelectedItem.ToString() == "Nombre")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = UsuariosBLL.GetListaUsuario(FiltroTextBox.Text);
                else
                    lista = UsuariosBLL.GetLista();
            }
            else
            {
               
                lista = UsuariosBLL.GetLista();
               
            }
           DatosDataGridView.DataSource = lista;
            DatosDataGridView.Columns.RemoveAt(2);
            //DatosDataGridView.Columns.RemoveAt(2);

            EliminarButton.Enabled = true;
            EditarButton.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

            var registroUsuarios = new RegistroUsuarios();
            registroUsuarios.Visible = true;
           
            Close();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CamposComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            CamposComboBox.SelectedIndex = 0;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int UsuarioID = Convert.ToInt32(DatosDataGridView.CurrentRow.Cells["UsuarioID"].Value);
                    UsuariosBLL.Eliminar(UsuarioID);
                    lista = UsuariosBLL.GetLista();
                }
            }
            else
            {
                return;

            }
            DatosDataGridView.DataSource = lista;
        }

        private void DatosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                Registros.ModificarUsuarios mu = new Registros.ModificarUsuarios();
                mu.Show();

                mu.UsuarioIDTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                mu.NombreTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                mu.ClaveTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                mu.ConfirmarTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                mu.PerfilComboBox.Text = DatosDataGridView.SelectedRows[0].Cells[3].Value.ToString();
               
            }
            else
            {
                MessageBox.Show("No hay Usuario para Modificar");

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            var registroUsuarios = new RegistroUsuarios();
            registroUsuarios.Visible = true;

            Close();
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            this.DatosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.MultiSelect = false;

            if (CamposComboBox.SelectedItem.ToString() == "UsuarioID")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = UsuariosBLL.GetListaUsuarioID(Utilidades.ToInt(FiltroTextBox.Text));
                else
                    lista = UsuariosBLL.GetLista();
            }
            else
            if (CamposComboBox.SelectedItem.ToString() == "Nombre")
            {
                if (!String.IsNullOrEmpty(FiltroTextBox.Text))
                    lista = UsuariosBLL.GetListaUsuario(FiltroTextBox.Text);
                else
                    lista = UsuariosBLL.GetLista();
            }
            else
            {

                lista = UsuariosBLL.GetLista();

            }
            DatosDataGridView.DataSource = lista;
            EliminarButton.Enabled = true;
            EditarButton.Enabled = true;

        }

        private void EditarButton_Click_1(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                Registros.ModificarUsuarios mu = new Registros.ModificarUsuarios();
                mu.Show();

                mu.UsuarioIDTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                mu.NombreTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                mu.ClaveTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                mu.ConfirmarTextBox.Text = DatosDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                mu.PerfilComboBox.Text = DatosDataGridView.SelectedRows[0].Cells[3].Value.ToString();

            }
            else
            {
                MessageBox.Show("No hay Usuario para Modificar");

            }
        }

        private void SalirButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            if (DatosDataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int UsuarioID = Convert.ToInt32(DatosDataGridView.CurrentRow.Cells["UsuarioID"].Value);
                    UsuariosBLL.Eliminar(UsuarioID);
                    lista = UsuariosBLL.GetLista();
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
