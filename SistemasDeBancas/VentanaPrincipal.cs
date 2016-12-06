using BLL;
using Entidades;
using SistemasDeBancas;
using SistemasDeBancas.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemasDeBancas
{
    public partial class VentanaPrincipal : Form
    {
        Tickets ticket;
        public VentanaPrincipal()
        {
            InitializeComponent();
            ticket = new Tickets();   
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Tripleta_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

           


        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
           
            MaximizeBox = false;
            timer1.Enabled = true;
            IdLoteriatextBox.Focus();

        }
       

        private void AbrirVentas_Click(object sender, EventArgs e)
        {

           
            
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ya Gurado papa!!!!!!!");
        }

        private void UsuarioButton_Click(object sender, EventArgs e)
        {
            RegistroUsuarios rg = new RegistroUsuarios();
            rg.Visible = true;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            

            
        }

        private void SalirButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void UsuarioButton_Click_1(object sender, EventArgs e)
        {
            
            RegistroUsuarios rg = new RegistroUsuarios();
            rg.Visible = true;
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
       
            MontotextBox.Clear();
            JugadatextBox.Clear();
            IdLoteriatextBox.Clear();
            NombreLoteriatextBox.Clear();
            TotaltextBox.Clear();
            TicketIdTextBox.Clear();
         
            Usuariolabel.Text = "";
            DatosdataGridView.DataSource = null;
            DatosdataGridView.Columns[0].Visible = true;
            DatosdataGridView.Columns[2].Visible = true;
            DatosdataGridView.Columns[1].Visible = true;
            IdLoteriatextBox.Focus();

        }
        int total = 0;
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
           
           

            if ((JugadatextBox.Text).Length > 0 && ((JugadatextBox.Text).Length < 3))
            {
                string tipo = "Quiniela";
                GuardarDetalleData(tipo);
            }
            else
            if ((JugadatextBox.Text).Length >= 3 && (JugadatextBox.Text).Length < 5)
            {
                string tipo = "Pale";
                GuardarDetalleData(tipo);
            }
            else
                  if ((JugadatextBox.Text).Length >= 5 && (JugadatextBox.Text).Length < 7)
            {
                string tipo = "Tripleta";
                GuardarDetalleData(tipo);
            }
            else
            {
                MessageBox.Show("Error en el Formato");
                MontotextBox.Focus();
            }
               

                
        }
        int id = 1;
        public void GuardarDetalleData(string Tipo)
        {
            this.DatosdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.DatosdataGridView.MultiSelect = false;
            var detalle = new Detalles();

            DatosdataGridView.Rows.Add();
            int cantFilas = DatosdataGridView.Rows.Count - 1;
            DatosdataGridView[0, cantFilas].Value = Tipo;
            DatosdataGridView[1, cantFilas].Value = JugadatextBox.Text;
            DatosdataGridView[2, cantFilas].Value = MontotextBox.Text;
            total = total + Utilidades.ToInt(MontotextBox.Text);
          //  detalle.IdLoteria = Utilidades.ToInt(Loteriabutton.Text);
            detalle.Jugada = Utilidades.ToInt(JugadatextBox.Text);
            detalle.Precio = Utilidades.ToInt(MontotextBox.Text);
            detalle.Tipo = Tipo.ToString();

        
            if (DetallesBLL.Guardar(detalle))
            {
               
                id++;
     // ticket.detalles.Add(DetallesBLL.Buscar((int)ServiciosComboBox.SelectedValue));
                ticket.detalles.Add(DetallesBLL.Buscar(id));
                TotaltextBox.Clear();
                JugadatextBox.Clear();
                MontotextBox.Clear();
                TotaltextBox.Text = total.ToString();
                MontotextBox.Focus();
            }
            else
                MessageBox.Show("Error en guardar los datos intente de nuevo");


        }

        private int Length(string text)
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString();
        }

        private void Loteriabutton_Click(object sender, EventArgs e)
        {
            var RL = new Registros.RegistrarLoteria();
            RL.Visible = true;
        }

        public List<Loterias> lista = new List<Loterias>();

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
      
                this.NombredataGridView.MultiSelect = false;
                this.NombredataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
                if (!String.IsNullOrEmpty(IdLoteriatextBox.Text))
                    lista = LoteriasBLL.GetListaLoteriaID(Utilidades.ToInt(IdLoteriatextBox.Text));
                else
                    lista = LoteriasBLL.GetListaLoteriaID(1);

                NombredataGridView.DataSource = lista;
                if (NombredataGridView.CurrentRow != null)
                {
                    NombreLoteriatextBox.Text = NombredataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    MontotextBox.Focus();

                }
                else
                {
                    MessageBox.Show("Esta loteria no Existe");
                    NombreLoteriatextBox.Clear();
                    IdLoteriatextBox.Clear();
                    IdLoteriatextBox.Focus();
                }
                   


            }

        }

        private void IdLoteriatextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MontotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
              JugadatextBox.Focus();
        }

        private void NumerotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Agregarbutton.Focus();
        }

        private void DatosdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatosdataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DatosdataGridView_MouseClick(object sender, MouseEventArgs e)
        {
           
            this.DatosdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
           
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {

            int Id;
            int.TryParse(TicketIdTextBox.Text, out Id);
            ticket.IdLoteria = Utilidades.ToInt(IdLoteriatextBox.Text);
            ticket.Fecha = FechadateTimePicker.Value;
            ticket.Usuario = "Juan peres";
            ticket.Nulo = false;
            ticket.Total = Utilidades.ToInt(TotaltextBox.Text);
            ticket.IdDetalle = 1;
            ticket.IdTicket = Id;
            ticket.NombreLoteria = NombreLoteriatextBox.Text;

            if (TicketsBLL.Guardar(ticket))
            {
                MessageBox.Show("Guardado");
                DatosdataGridView.DataSource = null;
                MontotextBox.Clear();
                JugadatextBox.Clear();
                IdLoteriatextBox.Clear();
                NombreLoteriatextBox.Clear();
                TotaltextBox.Clear();
                TicketIdTextBox.Clear();
                Usuariolabel.Text = "";
                DatosdataGridView.DataSource = null;
                DatosdataGridView.Columns[0].Visible = true;
                DatosdataGridView.Columns[2].Visible = true;
                DatosdataGridView.Columns[1].Visible = true;
               
                IdLoteriatextBox.Focus();

            }
           

        }

        private void Detallebutton_Click(object sender, EventArgs e)
        {
            var rb = new Registros.RegistroDeLaBanca();
            rb.Show();
        }

        public List<Detalles> listaDetalles = new List<Detalles>();

        private void DatosdataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (DatosdataGridView.CurrentRow != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Querido Usuario", "Borrarando Usuarios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int detalleId = Convert.ToInt32( DatosdataGridView.CurrentRow.Cells["IdDetalle"].Value);
                   DetallesBLL.Eliminar(detalleId);
                    DatosdataGridView.DataSource = null;
                    DatosdataGridView.DataSource = ticket.detalles;
                    DatosdataGridView.Columns[0].Visible = false;
                    DatosdataGridView.Columns[1].Visible = false;
                    DatosdataGridView.Columns[2].Visible = false;
                }
            }
            else
            {
                MessageBox.Show("No hay Juagada!!!");
            }

            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TicketIdTextBox.Text))
            {
                MessageBox.Show("LLena el campo con el numero de Ticket");
            }
            else
            {
                var ticket = TicketsBLL.Buscar(Convert.ToInt32(TicketIdTextBox.Text));
                if (ticket != null)
                {

                    IdLoteriatextBox.Text = (ticket.IdLoteria).ToString();
                    NombreLoteriatextBox.Text = (ticket.NombreLoteria).ToString();
                    FechadateTimePicker.Text = (ticket.Fecha).ToString();
                    Usuariolabel.Text = ticket.Usuario.ToString();
                    TotaltextBox.Text = ticket.Total.ToString();
                    DatosdataGridView.DataSource = null;
                    DatosdataGridView.DataSource = ticket.detalles;
                    DatosdataGridView.Columns[0].Visible = false;
                    DatosdataGridView.Columns[1].Visible = false;
                    DatosdataGridView.Columns[2].Visible = false;
                }
                else
                {
                    MessageBox.Show("Este Ticket no Existe");
                   
                    MontotextBox.Clear();
                    JugadatextBox.Clear();
                    IdLoteriatextBox.Clear();
                    NombreLoteriatextBox.Clear();
                    TotaltextBox.Clear();
                    TicketIdTextBox.Clear();
                    DatosdataGridView.DataSource = null;
                    DatosdataGridView.Columns[0].Visible = true;
                    DatosdataGridView.Columns[2].Visible = true;
                    DatosdataGridView.Columns[1].Visible = true;
                    TicketIdTextBox.Focus();
                }
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (TicketIdTextBox != null)
            {
                DialogResult dialogo = MessageBox.Show("Desea Borrar el Ticket", "Borrarando Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogo == DialogResult.Yes)
                {
                    int TicketId = Utilidades.ToInt(TicketIdTextBox.Text);
                    TicketsBLL.Eliminar(TicketId);

                  
                    MontotextBox.Clear();
                    JugadatextBox.Clear();
                    IdLoteriatextBox.Clear();
                    NombreLoteriatextBox.Clear();
                    TotaltextBox.Clear();
                    TicketIdTextBox.Clear();
                    DatosdataGridView.DataSource = null;
                    TicketIdTextBox.Focus();
                    DatosdataGridView.Columns[0].Visible = true;
                    DatosdataGridView.Columns[2].Visible = true;
                    DatosdataGridView.Columns[1].Visible = true;
                    TicketIdTextBox.Focus();


                }
            }
            else
            {
                MessageBox.Show("Inserte el Ticket a Borrar");
                TicketIdTextBox.Focus();

            }
           
        }
    }
}
