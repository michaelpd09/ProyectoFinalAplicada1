using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace SistemasDeBancas
{
    
    public partial class Login : Form
    {

        public static bool ok = false;
        public Login()
        {
            
            InitializeComponent();
           
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
           
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            if (!ValidarVacio() && !ok)
                MessageBox.Show("Contraseña Incorrecta");
            else
                if(ok)
                    Close();
                
        }
        public bool ValidarVacio()
        {
            bool retorno = false;
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (string.IsNullOrEmpty(Usuario.Text))
            {
                errorProvider1.SetError(Usuario, "Debe introducir el nombre");
                retorno = true;
            }
            else
                if (string.IsNullOrEmpty(Clave.Text))
                {
                    errorProvider2.SetError(Clave, "Debe introducir La Contraseña");
                    retorno = true;
                 } 
            else
            {    
                if(!retorno)
                    if (ValidarSeccion() == DialogResult.OK)
                        ok = true;
            }   
            return retorno;
        }
           
        public static bool Validar()
        {
            Login l = new Login();
            l.ShowDialog();
            return ok;
        }
        public DialogResult ValidarSeccion()
        {
            if (validarUsuario() == true && validarContrasena() == true)
            {
                return DialogResult.OK;
            }

            return DialogResult.Cancel;
        }
        public bool validarUsuario()
        {
            if (UsuariosBLL.GetListaUsuario(Usuario.Text).Count() != 0)
            {
                return true;

            }

            return false;
        }

        public bool validarContrasena()
        {
            if (UsuariosBLL.GetListaContrasena(Clave.Text).Count() != 0)
            {
                return true;
            }

            return false;
        }
        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Clave_TextChanged(object sender, EventArgs e)
        {

        }
    }

   
}
