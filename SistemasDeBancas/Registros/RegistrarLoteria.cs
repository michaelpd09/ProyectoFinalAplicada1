using BLL;
using Entidades;
using SistemasDeBancas.Consulta;
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
    public partial class RegistrarLoteria : Form
    {
        public RegistrarLoteria()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HabilitarRegistroLoteria();
            LimpiarCamposRegistroLoteria();

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            var consultaLoteria = new ConsultaLoteria();
            consultaLoteria.Visible = true;
            Close();

        }
        private void HabilitarRegistroLoteria()
        {
           
            NombretextBox.Enabled = true;
            MontoPrimeratextBox.Enabled = true;
            MontoTerceratextBox.Enabled = true;
            MontoPale2textBox.Enabled = true;
            MontoTripleta2textBox.Enabled = true;
            MaximoPaletextBox.Enabled = true;
            MontoSegundatextBox.Enabled = true;
            MontoPale1textBox.Enabled = true;
            MontoTripleta1textBox.Enabled = true;
            MaximoQuinielatextBox.Enabled = true;
            MaximoTripletatextBox.Enabled = true;
            HoraApecturadateTimePicker.Enabled = true;
            HoraCierredateTimePicker.Enabled = true;
            GuardarButton.Enabled = true;
            
            
        }
        private void DesabilitarRegistroLoteria()
        {

            NombretextBox.Enabled         = false;
            MontoPrimeratextBox.Enabled   = false;
            MontoTerceratextBox.Enabled   = false;
            MontoPale2textBox.Enabled     = false;
            MontoTripleta2textBox.Enabled = false;
            MaximoPaletextBox.Enabled     = false;
            MontoSegundatextBox.Enabled   = false;
            MontoPale1textBox.Enabled     = false;
            MontoTripleta1textBox.Enabled = false;
            MaximoQuinielatextBox.Enabled = false;
            MaximoTripletatextBox.Enabled = false;
            HoraApecturadateTimePicker.Enabled = false;
            HoraCierredateTimePicker.Enabled = false;
            GuardarButton.Enabled = false;


        }
        private void LimpiarCamposRegistroLoteria()
        {
            IdLoteriatextBox.Clear();
            NombretextBox.Clear();
            MontoPrimeratextBox.Clear();
            MontoTerceratextBox.Clear();
            MontoPale2textBox.Clear();
            MontoTripleta2textBox.Clear();
            MaximoPaletextBox.Clear();
            MontoSegundatextBox.Clear();
            MontoPale1textBox.Clear();
            MontoTripleta1textBox.Clear();
            MaximoQuinielatextBox.Clear();
            MaximoTripletatextBox.Clear();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var loteria = new Loterias();
            
            loteria.Nombre = NombretextBox.Text;
            loteria.MontoPrimera   = Utilidades.ToInt(MontoPrimeratextBox.Text);
            loteria.MontoTercera   = Utilidades.ToInt(MontoTerceratextBox.Text);
            loteria.MontoPale2     = Utilidades.ToInt(MontoPale2textBox.Text);
            loteria.MontoTripleta2 = Utilidades.ToInt(MontoTripleta2textBox.Text);
            loteria.MaximoPale     = Utilidades.ToInt(MaximoPaletextBox.Text);
            loteria.HoraApectura   =  HoraApecturadateTimePicker.Value;
            loteria.HoraCierre     =  HoraCierredateTimePicker.Value;
            loteria.MontoSegunda   = Utilidades.ToInt(MontoSegundatextBox.Text);
            loteria.MontoPale1     = Utilidades.ToInt(MontoPale1textBox.Text);
            loteria.MontoTripleta1 = Utilidades.ToInt(MontoTripleta1textBox.Text);
            loteria.MaximoQuiniela = Utilidades.ToInt(MaximoQuinielatextBox.Text);
            loteria.MaximoTripleta = Utilidades.ToInt(MaximoTripletatextBox.Text);
                                                  

            if (LoteriasBLL.Guardar(loteria))
            {
                MessageBox.Show("Guardardo...");
                LimpiarCamposRegistroLoteria();
                GuardarButton.Enabled = false;
                DesabilitarRegistroLoteria();
          //      EliminarButton.Enabled = true;
            }

            else
                MessageBox.Show("Error al guardar");
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConsultarLoteriabutton_Click(object sender, EventArgs e)
        {
            var consultaLoteria = new ConsultaLoteria();
            consultaLoteria.Show();
            Close();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            HabilitarRegistroLoteria();
            LimpiarCamposRegistroLoteria();
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            var loteria = new Loterias();

            loteria.Nombre = NombretextBox.Text;
            loteria.MontoPrimera = Utilidades.ToInt(MontoPrimeratextBox.Text);
            loteria.MontoTercera = Utilidades.ToInt(MontoTerceratextBox.Text);
            loteria.MontoPale2 = Utilidades.ToInt(MontoPale2textBox.Text);
            loteria.MontoTripleta2 = Utilidades.ToInt(MontoTripleta2textBox.Text);
            loteria.MaximoPale = Utilidades.ToInt(MaximoPaletextBox.Text);
            loteria.HoraApectura = HoraApecturadateTimePicker.Value;
            loteria.HoraCierre = HoraCierredateTimePicker.Value;
            loteria.MontoSegunda = Utilidades.ToInt(MontoSegundatextBox.Text);
            loteria.MontoPale1 = Utilidades.ToInt(MontoPale1textBox.Text);
            loteria.MontoTripleta1 = Utilidades.ToInt(MontoTripleta1textBox.Text);
            loteria.MaximoQuiniela = Utilidades.ToInt(MaximoQuinielatextBox.Text);
            loteria.MaximoTripleta = Utilidades.ToInt(MaximoTripletatextBox.Text);


            if (LoteriasBLL.Guardar(loteria))
            {
                MessageBox.Show("Guardardo...");
                LimpiarCamposRegistroLoteria();
                GuardarButton.Enabled = false;
                DesabilitarRegistroLoteria();
                //      EliminarButton.Enabled = true;
            }

            else
                MessageBox.Show("Error al guardar");
        }
    
    }
}
