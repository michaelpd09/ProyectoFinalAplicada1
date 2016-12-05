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

namespace SistemasDeBancas.Modificaciones
{
    public partial class ModificarLoteria : Form
    {
        public ModificarLoteria()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            LoteriasBLL.Modificar(new Loterias()
            {

                IdLoteria = Utilidades.ToInt(IdLoteriatextBox.Text),
                Nombre = NombretextBox.Text,
                MontoPrimera = Utilidades.ToInt(MontoPrimeratextBox.Text),
                MontoSegunda = Utilidades.ToInt(MontoSegundatextBox.Text),
                MontoTercera = Utilidades.ToInt(MontoTerceratextBox.Text),
                MontoPale1 = Utilidades.ToInt(MontoPale1textBox.Text),
                MontoPale2 = Utilidades.ToInt(MontoPale2textBox.Text),
                MontoTripleta1 = Utilidades.ToInt(MontoTripleta1textBox.Text),
                MontoTripleta2 = Utilidades.ToInt(MontoTripleta2textBox.Text),
                HoraApectura = HoraApecturadateTimePicker.Value,
                HoraCierre = HoraCierredateTimePicker.Value,
                MaximoQuiniela  = Utilidades.ToInt(MaximoQuinielatextBox.Text),
                MaximoPale      = Utilidades.ToInt(MaximoPaletextBox.Text),
                MaximoTripleta = Utilidades.ToInt(MaximoTripletatextBox.Text),
            });

            DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
            Close();
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoteriasBLL.Modificar(new Loterias()
            {

                IdLoteria = Utilidades.ToInt(IdLoteriatextBox.Text),
                Nombre = NombretextBox.Text,
                MontoPrimera = Utilidades.ToInt(MontoPrimeratextBox.Text),
                MontoSegunda = Utilidades.ToInt(MontoSegundatextBox.Text),
                MontoTercera = Utilidades.ToInt(MontoTerceratextBox.Text),
                MontoPale1 = Utilidades.ToInt(MontoPale1textBox.Text),
                MontoPale2 = Utilidades.ToInt(MontoPale2textBox.Text),
                MontoTripleta1 = Utilidades.ToInt(MontoTripleta1textBox.Text),
                MontoTripleta2 = Utilidades.ToInt(MontoTripleta2textBox.Text),
                HoraApectura = HoraApecturadateTimePicker.Value,
                HoraCierre = HoraCierredateTimePicker.Value,
                MaximoQuiniela = Utilidades.ToInt(MaximoQuinielatextBox.Text),
                MaximoPale = Utilidades.ToInt(MaximoPaletextBox.Text),
                MaximoTripleta = Utilidades.ToInt(MaximoTripletatextBox.Text),
            });

            DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoteriasBLL.Modificar(new Loterias()
            {

                IdLoteria = Utilidades.ToInt(IdLoteriatextBox.Text),
                Nombre = NombretextBox.Text,
                MontoPrimera = Utilidades.ToInt(MontoPrimeratextBox.Text),
                MontoSegunda = Utilidades.ToInt(MontoSegundatextBox.Text),
                MontoTercera = Utilidades.ToInt(MontoTerceratextBox.Text),
                MontoPale1 = Utilidades.ToInt(MontoPale1textBox.Text),
                MontoPale2 = Utilidades.ToInt(MontoPale2textBox.Text),
                MontoTripleta1 = Utilidades.ToInt(MontoTripleta1textBox.Text),
                MontoTripleta2 = Utilidades.ToInt(MontoTripleta2textBox.Text),
                HoraApectura = HoraApecturadateTimePicker.Value,
                HoraCierre = HoraCierredateTimePicker.Value,
                MaximoQuiniela = Utilidades.ToInt(MaximoQuinielatextBox.Text),
                MaximoPale = Utilidades.ToInt(MaximoPaletextBox.Text),
                MaximoTripleta = Utilidades.ToInt(MaximoTripletatextBox.Text),
            });

            DialogResult dialogo = MessageBox.Show("Datos Actualizados Correctamente");
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
