namespace SistemasDeBancas.Modificaciones
{
    partial class ModificarBanca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarBanca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rnctextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BancaIDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TelefonomaskedTextBox);
            this.groupBox1.Controls.Add(this.FechadateTimePicker);
            this.groupBox1.Controls.Add(this.rnctextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SalirButton);
            this.groupBox1.Controls.Add(this.GuardarButton);
            this.groupBox1.Controls.Add(this.DireccionTextBox);
            this.groupBox1.Controls.Add(this.NombreTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BancaIDTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(35, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 312);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Usuario";
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(180, 156);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(307, 23);
            this.TelefonomaskedTextBox.TabIndex = 20;
            // 
            // rnctextBox
            // 
            this.rnctextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rnctextBox.ForeColor = System.Drawing.Color.Blue;
            this.rnctextBox.Location = new System.Drawing.Point(182, 193);
            this.rnctextBox.Name = "rnctextBox";
            this.rnctextBox.Size = new System.Drawing.Size(305, 26);
            this.rnctextBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(109, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "RNC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(74, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefono:";
            // 
            // SalirButton
            // 
            this.SalirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirButton.BackgroundImage")));
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalirButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SalirButton.Location = new System.Drawing.Point(316, 246);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(136, 48);
            this.SalirButton.TabIndex = 13;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarButton.BackgroundImage")));
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.GuardarButton.Location = new System.Drawing.Point(73, 246);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(136, 48);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DireccionTextBox.ForeColor = System.Drawing.Color.Blue;
            this.DireccionTextBox.Location = new System.Drawing.Point(180, 116);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(307, 26);
            this.DireccionTextBox.TabIndex = 6;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.ForeColor = System.Drawing.Color.Blue;
            this.NombreTextBox.Location = new System.Drawing.Point(180, 76);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(307, 26);
            this.NombreTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(69, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(80, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // BancaIDTextBox
            // 
            this.BancaIDTextBox.Enabled = false;
            this.BancaIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BancaIDTextBox.ForeColor = System.Drawing.Color.Blue;
            this.BancaIDTextBox.Location = new System.Drawing.Point(180, 36);
            this.BancaIDTextBox.Name = "BancaIDTextBox";
            this.BancaIDTextBox.Size = new System.Drawing.Size(81, 26);
            this.BancaIDTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(74, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Banca ID:";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(271, 36);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(216, 23);
            this.FechadateTimePicker.TabIndex = 22;
            this.FechadateTimePicker.Value = new System.DateTime(2016, 11, 25, 0, 0, 0, 0);
            this.FechadateTimePicker.Visible = false;
            // 
            // ModificarBanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModificarBanca";
            this.Text = "ModificarBanca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker FechadateTimePicker;
        public System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        public System.Windows.Forms.TextBox rnctextBox;
        public System.Windows.Forms.TextBox DireccionTextBox;
        public System.Windows.Forms.TextBox NombreTextBox;
        public System.Windows.Forms.TextBox BancaIDTextBox;
    }
}