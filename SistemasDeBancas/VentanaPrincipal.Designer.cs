namespace SistemasDeBancas
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.VentagroupBox = new System.Windows.Forms.GroupBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.TicketIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreLoteriatextBox = new System.Windows.Forms.TextBox();
            this.IdLoteriatextBox = new System.Windows.Forms.TextBox();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.JugadatextBox = new System.Windows.Forms.TextBox();
            this.MontotextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumerogroupBox = new System.Windows.Forms.GroupBox();
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.NombredataGridView = new System.Windows.Forms.DataGridView();
            this.UsuarioSistema = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.DatosdataGridView = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpcionesgroupBox = new System.Windows.Forms.GroupBox();
            this.Detallebutton = new System.Windows.Forms.Button();
            this.Loteriabutton = new System.Windows.Forms.Button();
            this.ReporteButton = new System.Windows.Forms.Button();
            this.UsuarioButton = new System.Windows.Forms.Button();
            this.ReimprimirButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.AnularButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.VentagroupBox.SuspendLayout();
            this.NumerogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombredataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).BeginInit();
            this.OpcionesgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // VentagroupBox
            // 
            this.VentagroupBox.BackColor = System.Drawing.Color.Transparent;
            this.VentagroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VentagroupBox.Controls.Add(this.FechadateTimePicker);
            this.VentagroupBox.Controls.Add(this.label4);
            this.VentagroupBox.Controls.Add(this.Hora);
            this.VentagroupBox.Controls.Add(this.Buscarbutton);
            this.VentagroupBox.Controls.Add(this.TicketIdTextBox);
            this.VentagroupBox.Controls.Add(this.label1);
            this.VentagroupBox.Controls.Add(this.NombreLoteriatextBox);
            this.VentagroupBox.Controls.Add(this.IdLoteriatextBox);
            this.VentagroupBox.Controls.Add(this.Agregarbutton);
            this.VentagroupBox.Controls.Add(this.JugadatextBox);
            this.VentagroupBox.Controls.Add(this.MontotextBox);
            this.VentagroupBox.Controls.Add(this.label7);
            this.VentagroupBox.Controls.Add(this.label3);
            this.VentagroupBox.Controls.Add(this.label2);
            this.VentagroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentagroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.VentagroupBox.Location = new System.Drawing.Point(12, 2);
            this.VentagroupBox.Name = "VentagroupBox";
            this.VentagroupBox.Size = new System.Drawing.Size(583, 164);
            this.VentagroupBox.TabIndex = 32;
            this.VentagroupBox.TabStop = false;
            this.VentagroupBox.Text = "Venta";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(347, 23);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(216, 23);
            this.FechadateTimePicker.TabIndex = 48;
            this.FechadateTimePicker.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(273, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Fecha";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.BackColor = System.Drawing.Color.Transparent;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Hora.Location = new System.Drawing.Point(344, 27);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(0, 17);
            this.Hora.TabIndex = 35;
            this.Hora.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.AccessibleName = "";
            this.Buscarbutton.BackColor = System.Drawing.Color.White;
            this.Buscarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.BackgroundImage")));
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.Location = new System.Drawing.Point(216, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(48, 41);
            this.Buscarbutton.TabIndex = 30;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // TicketIdTextBox
            // 
            this.TicketIdTextBox.AccessibleName = "";
            this.TicketIdTextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TicketIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketIdTextBox.ForeColor = System.Drawing.Color.White;
            this.TicketIdTextBox.Location = new System.Drawing.Point(86, 17);
            this.TicketIdTextBox.Name = "TicketIdTextBox";
            this.TicketIdTextBox.Size = new System.Drawing.Size(124, 38);
            this.TicketIdTextBox.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(5, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Ticket Id";
            // 
            // NombreLoteriatextBox
            // 
            this.NombreLoteriatextBox.AccessibleName = "";
            this.NombreLoteriatextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NombreLoteriatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLoteriatextBox.ForeColor = System.Drawing.Color.White;
            this.NombreLoteriatextBox.Location = new System.Drawing.Point(216, 60);
            this.NombreLoteriatextBox.Name = "NombreLoteriatextBox";
            this.NombreLoteriatextBox.ReadOnly = true;
            this.NombreLoteriatextBox.Size = new System.Drawing.Size(338, 38);
            this.NombreLoteriatextBox.TabIndex = 44;
            // 
            // IdLoteriatextBox
            // 
            this.IdLoteriatextBox.AccessibleName = "";
            this.IdLoteriatextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.IdLoteriatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLoteriatextBox.ForeColor = System.Drawing.Color.White;
            this.IdLoteriatextBox.Location = new System.Drawing.Point(86, 59);
            this.IdLoteriatextBox.Name = "IdLoteriatextBox";
            this.IdLoteriatextBox.Size = new System.Drawing.Size(124, 38);
            this.IdLoteriatextBox.TabIndex = 43;
            this.IdLoteriatextBox.TextChanged += new System.EventHandler(this.IdLoteriatextBox_TextChanged);
            this.IdLoteriatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.AccessibleName = "";
            this.Agregarbutton.BackColor = System.Drawing.Color.White;
            this.Agregarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.BackgroundImage")));
            this.Agregarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Agregarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Agregarbutton.Location = new System.Drawing.Point(506, 101);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(48, 41);
            this.Agregarbutton.TabIndex = 28;
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Agregarbutton.UseVisualStyleBackColor = false;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // JugadatextBox
            // 
            this.JugadatextBox.AccessibleName = "";
            this.JugadatextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.JugadatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JugadatextBox.ForeColor = System.Drawing.Color.White;
            this.JugadatextBox.Location = new System.Drawing.Point(290, 103);
            this.JugadatextBox.Name = "JugadatextBox";
            this.JugadatextBox.Size = new System.Drawing.Size(210, 38);
            this.JugadatextBox.TabIndex = 37;
            this.JugadatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumerotextBox_KeyPress);
            // 
            // MontotextBox
            // 
            this.MontotextBox.AccessibleName = "";
            this.MontotextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.MontotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontotextBox.ForeColor = System.Drawing.Color.White;
            this.MontotextBox.Location = new System.Drawing.Point(86, 101);
            this.MontotextBox.Name = "MontotextBox";
            this.MontotextBox.Size = new System.Drawing.Size(124, 38);
            this.MontotextBox.TabIndex = 35;
            this.MontotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MontotextBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(19, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 38;
            this.label7.Text = "Loteria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(215, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "Jugada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(22, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "Monto";
            // 
            // NumerogroupBox
            // 
            this.NumerogroupBox.BackColor = System.Drawing.Color.Transparent;
            this.NumerogroupBox.Controls.Add(this.Usuariolabel);
            this.NumerogroupBox.Controls.Add(this.NombredataGridView);
            this.NumerogroupBox.Controls.Add(this.UsuarioSistema);
            this.NumerogroupBox.Controls.Add(this.label9);
            this.NumerogroupBox.Controls.Add(this.TotaltextBox);
            this.NumerogroupBox.Controls.Add(this.DatosdataGridView);
            this.NumerogroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumerogroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.NumerogroupBox.Location = new System.Drawing.Point(12, 167);
            this.NumerogroupBox.Name = "NumerogroupBox";
            this.NumerogroupBox.Size = new System.Drawing.Size(583, 334);
            this.NumerogroupBox.TabIndex = 33;
            this.NumerogroupBox.TabStop = false;
            this.NumerogroupBox.Text = "Detalle";
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Location = new System.Drawing.Point(92, 281);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(0, 17);
            this.Usuariolabel.TabIndex = 38;
            // 
            // NombredataGridView
            // 
            this.NombredataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NombredataGridView.Location = new System.Drawing.Point(7, 370);
            this.NombredataGridView.Name = "NombredataGridView";
            this.NombredataGridView.ReadOnly = true;
            this.NombredataGridView.Size = new System.Drawing.Size(10, 10);
            this.NombredataGridView.TabIndex = 37;
            // 
            // UsuarioSistema
            // 
            this.UsuarioSistema.AutoSize = true;
            this.UsuarioSistema.BackColor = System.Drawing.Color.Transparent;
            this.UsuarioSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioSistema.Location = new System.Drawing.Point(110, 375);
            this.UsuarioSistema.Name = "UsuarioSistema";
            this.UsuarioSistema.Size = new System.Drawing.Size(0, 20);
            this.UsuarioSistema.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(7, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Usuario:";
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.AccessibleName = "";
            this.TotaltextBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.TotaltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotaltextBox.ForeColor = System.Drawing.Color.White;
            this.TotaltextBox.Location = new System.Drawing.Point(410, 274);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(144, 44);
            this.TotaltextBox.TabIndex = 31;
            // 
            // DatosdataGridView
            // 
            this.DatosdataGridView.AllowUserToAddRows = false;
            this.DatosdataGridView.AllowUserToDeleteRows = false;
            this.DatosdataGridView.AllowUserToOrderColumns = true;
            this.DatosdataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DatosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Jugada,
            this.Monto});
            this.DatosdataGridView.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.DatosdataGridView.Location = new System.Drawing.Point(11, 18);
            this.DatosdataGridView.Name = "DatosdataGridView";
            this.DatosdataGridView.ReadOnly = true;
            this.DatosdataGridView.RowHeadersWidth = 20;
            this.DatosdataGridView.Size = new System.Drawing.Size(543, 250);
            this.DatosdataGridView.TabIndex = 36;
            this.DatosdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosdataGridView_CellContentClick);
            this.DatosdataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatosdataGridView_CellMouseClick);
            this.DatosdataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DatosdataGridView_MouseClick);
            this.DatosdataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DatosdataGridView_MouseDoubleClick);
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Jugada
            // 
            this.Jugada.HeaderText = "Jugada";
            this.Jugada.Name = "Jugada";
            this.Jugada.ReadOnly = true;
            this.Jugada.ToolTipText = "Las Quinielas";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // OpcionesgroupBox
            // 
            this.OpcionesgroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpcionesgroupBox.Controls.Add(this.Detallebutton);
            this.OpcionesgroupBox.Controls.Add(this.Loteriabutton);
            this.OpcionesgroupBox.Controls.Add(this.ReporteButton);
            this.OpcionesgroupBox.Controls.Add(this.UsuarioButton);
            this.OpcionesgroupBox.Controls.Add(this.ReimprimirButton);
            this.OpcionesgroupBox.Controls.Add(this.SalirButton);
            this.OpcionesgroupBox.Controls.Add(this.Cancelarbutton);
            this.OpcionesgroupBox.Controls.Add(this.AnularButton);
            this.OpcionesgroupBox.Controls.Add(this.GuardarButton);
            this.OpcionesgroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpcionesgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpcionesgroupBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.OpcionesgroupBox.Location = new System.Drawing.Point(622, 2);
            this.OpcionesgroupBox.Name = "OpcionesgroupBox";
            this.OpcionesgroupBox.Size = new System.Drawing.Size(203, 492);
            this.OpcionesgroupBox.TabIndex = 34;
            this.OpcionesgroupBox.TabStop = false;
            this.OpcionesgroupBox.Text = "Opciones";
            // 
            // Detallebutton
            // 
            this.Detallebutton.AccessibleName = "";
            this.Detallebutton.BackColor = System.Drawing.Color.White;
            this.Detallebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Detallebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detallebutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Detallebutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Detallebutton.Location = new System.Drawing.Point(35, 332);
            this.Detallebutton.Name = "Detallebutton";
            this.Detallebutton.Size = new System.Drawing.Size(136, 48);
            this.Detallebutton.TabIndex = 29;
            this.Detallebutton.Text = "Banca";
            this.Detallebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Detallebutton.UseVisualStyleBackColor = false;
            this.Detallebutton.Click += new System.EventHandler(this.Detallebutton_Click);
            // 
            // Loteriabutton
            // 
            this.Loteriabutton.AccessibleName = "";
            this.Loteriabutton.BackColor = System.Drawing.Color.White;
            this.Loteriabutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Loteriabutton.BackgroundImage")));
            this.Loteriabutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Loteriabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loteriabutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Loteriabutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Loteriabutton.Location = new System.Drawing.Point(35, 284);
            this.Loteriabutton.Name = "Loteriabutton";
            this.Loteriabutton.Size = new System.Drawing.Size(136, 48);
            this.Loteriabutton.TabIndex = 28;
            this.Loteriabutton.Text = "Loterias";
            this.Loteriabutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Loteriabutton.UseVisualStyleBackColor = false;
            this.Loteriabutton.Click += new System.EventHandler(this.Loteriabutton_Click);
            // 
            // ReporteButton
            // 
            this.ReporteButton.AccessibleName = "";
            this.ReporteButton.BackColor = System.Drawing.Color.White;
            this.ReporteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReporteButton.BackgroundImage")));
            this.ReporteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReporteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReporteButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ReporteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReporteButton.Location = new System.Drawing.Point(35, 236);
            this.ReporteButton.Name = "ReporteButton";
            this.ReporteButton.Size = new System.Drawing.Size(136, 48);
            this.ReporteButton.TabIndex = 27;
            this.ReporteButton.Text = "Reportes";
            this.ReporteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReporteButton.UseVisualStyleBackColor = false;
            // 
            // UsuarioButton
            // 
            this.UsuarioButton.AccessibleName = "";
            this.UsuarioButton.BackColor = System.Drawing.Color.White;
            this.UsuarioButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsuarioButton.BackgroundImage")));
            this.UsuarioButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsuarioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UsuarioButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.UsuarioButton.Location = new System.Drawing.Point(35, 380);
            this.UsuarioButton.Name = "UsuarioButton";
            this.UsuarioButton.Size = new System.Drawing.Size(136, 48);
            this.UsuarioButton.TabIndex = 26;
            this.UsuarioButton.Text = "Usuarios";
            this.UsuarioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UsuarioButton.UseVisualStyleBackColor = false;
            this.UsuarioButton.Click += new System.EventHandler(this.UsuarioButton_Click_1);
            // 
            // ReimprimirButton
            // 
            this.ReimprimirButton.AccessibleName = "";
            this.ReimprimirButton.BackColor = System.Drawing.Color.White;
            this.ReimprimirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReimprimirButton.BackgroundImage")));
            this.ReimprimirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReimprimirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReimprimirButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.ReimprimirButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReimprimirButton.Location = new System.Drawing.Point(35, 140);
            this.ReimprimirButton.Name = "ReimprimirButton";
            this.ReimprimirButton.Size = new System.Drawing.Size(136, 48);
            this.ReimprimirButton.TabIndex = 24;
            this.ReimprimirButton.Text = "Reimprimir";
            this.ReimprimirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReimprimirButton.UseVisualStyleBackColor = false;
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.White;
            this.SalirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirButton.BackgroundImage")));
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SalirButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SalirButton.Location = new System.Drawing.Point(35, 428);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(136, 48);
            this.SalirButton.TabIndex = 25;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click_1);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.AccessibleName = "";
            this.Cancelarbutton.BackColor = System.Drawing.Color.White;
            this.Cancelarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.BackgroundImage")));
            this.Cancelarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Cancelarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelarbutton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(35, 92);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(136, 48);
            this.Cancelarbutton.TabIndex = 23;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Nuevobutton_Click_1);
            // 
            // AnularButton
            // 
            this.AnularButton.AccessibleName = "";
            this.AnularButton.BackColor = System.Drawing.Color.White;
            this.AnularButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnularButton.BackgroundImage")));
            this.AnularButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AnularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnularButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.AnularButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnularButton.Location = new System.Drawing.Point(35, 188);
            this.AnularButton.Name = "AnularButton";
            this.AnularButton.Size = new System.Drawing.Size(136, 48);
            this.AnularButton.TabIndex = 22;
            this.AnularButton.Text = "Anular";
            this.AnularButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnularButton.UseVisualStyleBackColor = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.AccessibleName = "";
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarButton.BackgroundImage")));
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(35, 44);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(136, 48);
            this.GuardarButton.TabIndex = 21;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // VentanaPrincipal
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 529);
            this.Controls.Add(this.OpcionesgroupBox);
            this.Controls.Add(this.NumerogroupBox);
            this.Controls.Add(this.VentagroupBox);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Ventas de Loterias";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.VentagroupBox.ResumeLayout(false);
            this.VentagroupBox.PerformLayout();
            this.NumerogroupBox.ResumeLayout(false);
            this.NumerogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombredataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosdataGridView)).EndInit();
            this.OpcionesgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox VentagroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox NumerogroupBox;
        private System.Windows.Forms.Label UsuarioSistema;
        public System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox MontotextBox;
        public System.Windows.Forms.Button GuardarButton;
        public System.Windows.Forms.Button AnularButton;
        public System.Windows.Forms.Button Cancelarbutton;
        public System.Windows.Forms.Button ReimprimirButton;
        private System.Windows.Forms.Button SalirButton;
        public System.Windows.Forms.Button UsuarioButton;
        public System.Windows.Forms.Button ReporteButton;
        public System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.GroupBox OpcionesgroupBox;
        private System.Windows.Forms.Label Hora;
        public System.Windows.Forms.Button Loteriabutton;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TextBox NombreLoteriatextBox;
        public System.Windows.Forms.TextBox IdLoteriatextBox;
        private System.Windows.Forms.DataGridView DatosdataGridView;
        private System.Windows.Forms.DataGridView NombredataGridView;
        public System.Windows.Forms.TextBox JugadatextBox;
        public System.Windows.Forms.Button Detallebutton;
        public System.Windows.Forms.TextBox TicketIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label Usuariolabel;
    }
}