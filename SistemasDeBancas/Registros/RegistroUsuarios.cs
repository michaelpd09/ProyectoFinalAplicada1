using System;
using System.Windows.Forms;
using Entidades;
using BLL;
using SistemasDeBancas.Consulta;

namespace SistemasDeBancas
{
    public partial class RegistroUsuarios : Form
    {
        public RegistroUsuarios()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click_1(object sender, EventArgs e)
        {
            NombreTextBox.Enabled = true;
            ClaveTextBox.Enabled = true;
            ConfirmarTextBox.Enabled = true;
            GuardarButton.Enabled = true;

            PerfilComboBox.Enabled = true;

            NombreTextBox.Clear();
            ClaveTextBox.Clear();
            ConfirmarTextBox.Clear();
            PerfilComboBox.Text = "";
            NombreTextBox.Focus();


        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            if (!Validar())
                return;
            usuario.Tipo = PerfilComboBox.SelectedItem.ToString();
            usuario.Nombre = NombreTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Fecha = FechadateTimePicker.Value;
           
           
            if (UsuariosBLL.Guardar(usuario))
            {
                MessageBox.Show("Guardado.....");
                NombreTextBox.Clear();
                ClaveTextBox.Clear();
                ConfirmarTextBox.Clear();
                PerfilComboBox.Text = "";
            }  

             else
                    MessageBox.Show("Error al guardar");

            
        }


        private bool Validar()
        {
            bool retorno = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            errorProvider4.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text))
            {
                errorProvider1.SetError(NombreTextBox, "Debe introducir el nombre!!!");
                retorno = false;
                
            }
            else
            if (string.IsNullOrEmpty(ClaveTextBox.Text))
            {
                errorProvider2.SetError(ClaveTextBox, "Debe introducir una Contraseña!!!");
                retorno = false;
               
            }
            
            else
                if(ClaveTextBox.Text != ConfirmarTextBox.Text)
            {
                errorProvider4.SetError(ConfirmarTextBox, "Las Contraseñas no Coinciden!!!");
                retorno = false;
            }
            else
             if (string.IsNullOrEmpty(PerfilComboBox.Text))
            {
                errorProvider3.SetError(PerfilComboBox, "Debe introducir el Perfir!!!");
                retorno = false;

            }

            return retorno;
        }
      

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            ConsultaUsuarios cu = new ConsultaUsuarios();
            cu.Visible = true;
            Close();
           
        }
        
        private void RegistroUsuarios_Load(object sender, EventArgs e)
        {
           
            MaximizeBox = false;
            MinimizeBox = false;
            NombreTextBox.Focus();
        }

        private void PerfilComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClaveTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void ConfirmarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void PerfilComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void NombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ClaveTextBox.Focus();
                MessageBox.Show(e.KeyChar.ToString());
            }
           

        }
    }
}
