namespace SolucionTeamsPagina2
{
    partial class Pagina2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagina2));
            this.LblTituloP2 = new System.Windows.Forms.Label();
            this.BtnContP2 = new System.Windows.Forms.Button();
            this.BtnSalirP2 = new System.Windows.Forms.Button();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.PBFondoP2 = new System.Windows.Forms.PictureBox();
            this.LblContrasena = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.BtnAtrP2 = new System.Windows.Forms.Button();
            this.LblContinuar = new System.Windows.Forms.Label();
            this.PBLogoP2 = new System.Windows.Forms.PictureBox();
            this.PBPieP2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBFondoP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPieP2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloP2
            // 
            this.LblTituloP2.AutoSize = true;
            this.LblTituloP2.Font = new System.Drawing.Font("Arial Black", 13F, System.Drawing.FontStyle.Bold);
            this.LblTituloP2.Location = new System.Drawing.Point(12, 44);
            this.LblTituloP2.Name = "LblTituloP2";
            this.LblTituloP2.Size = new System.Drawing.Size(449, 26);
            this.LblTituloP2.TabIndex = 5;
            this.LblTituloP2.Text = "Ingrese Usuario y Contraseña Administrador";
            // 
            // BtnContP2
            // 
            this.BtnContP2.Enabled = false;
            this.BtnContP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnContP2.Location = new System.Drawing.Point(489, 369);
            this.BtnContP2.Name = "BtnContP2";
            this.BtnContP2.Size = new System.Drawing.Size(70, 20);
            this.BtnContP2.TabIndex = 4;
            this.BtnContP2.Text = "Continuar";
            this.BtnContP2.UseVisualStyleBackColor = true;
            this.BtnContP2.Click += new System.EventHandler(this.BtnContP2_Click);
            // 
            // BtnSalirP2
            // 
            this.BtnSalirP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnSalirP2.Location = new System.Drawing.Point(565, 369);
            this.BtnSalirP2.Name = "BtnSalirP2";
            this.BtnSalirP2.Size = new System.Drawing.Size(70, 20);
            this.BtnSalirP2.TabIndex = 3;
            this.BtnSalirP2.Text = "Salir";
            this.BtnSalirP2.UseVisualStyleBackColor = true;
            this.BtnSalirP2.Click += new System.EventHandler(this.BtnSalirP2_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.LblUsuario.Location = new System.Drawing.Point(10, 161);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(174, 17);
            this.LblUsuario.TabIndex = 6;
            this.LblUsuario.Text = "Ingrese Nombre de Usuario";
            // 
            // PBFondoP2
            // 
            this.PBFondoP2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PBFondoP2.BackColor = System.Drawing.Color.White;
            this.PBFondoP2.Image = global::SolucionTeams.Properties.Resources.Fondo11;
            this.PBFondoP2.ImageLocation = "";
            this.PBFondoP2.Location = new System.Drawing.Point(-2, 79);
            this.PBFondoP2.Name = "PBFondoP2";
            this.PBFondoP2.Size = new System.Drawing.Size(665, 288);
            this.PBFondoP2.TabIndex = 2;
            this.PBFondoP2.TabStop = false;
            // 
            // LblContrasena
            // 
            this.LblContrasena.AutoSize = true;
            this.LblContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblContrasena.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold);
            this.LblContrasena.ForeColor = System.Drawing.Color.Black;
            this.LblContrasena.Location = new System.Drawing.Point(10, 221);
            this.LblContrasena.Name = "LblContrasena";
            this.LblContrasena.Size = new System.Drawing.Size(124, 15);
            this.LblContrasena.TabIndex = 7;
            this.LblContrasena.Text = "Ingrese Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TxtUsuario.Location = new System.Drawing.Point(10, 187);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(113, 23);
            this.TxtUsuario.TabIndex = 8;
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(10, 250);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(113, 20);
            this.TxtContrasena.TabIndex = 9;
            this.TxtContrasena.UseSystemPasswordChar = true;
            // 
            // BtnValidar
            // 
            this.BtnValidar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnValidar.Location = new System.Drawing.Point(156, 218);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(64, 20);
            this.BtnValidar.TabIndex = 10;
            this.BtnValidar.Text = "Validar";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // BtnAtrP2
            // 
            this.BtnAtrP2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnAtrP2.Location = new System.Drawing.Point(413, 369);
            this.BtnAtrP2.Name = "BtnAtrP2";
            this.BtnAtrP2.Size = new System.Drawing.Size(70, 20);
            this.BtnAtrP2.TabIndex = 11;
            this.BtnAtrP2.Text = "Atras";
            this.BtnAtrP2.UseVisualStyleBackColor = true;
            this.BtnAtrP2.Click += new System.EventHandler(this.BtnAtrP2_Click);
            // 
            // LblContinuar
            // 
            this.LblContinuar.AutoSize = true;
            this.LblContinuar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.LblContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContinuar.Location = new System.Drawing.Point(152, 218);
            this.LblContinuar.Name = "LblContinuar";
            this.LblContinuar.Size = new System.Drawing.Size(348, 20);
            this.LblContinuar.TabIndex = 12;
            this.LblContinuar.Text = "Usuario y Contraseña Correctos Continuar";
            this.LblContinuar.Visible = false;
            // 
            // PBLogoP2
            // 
            this.PBLogoP2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PBLogoP2.Image = global::SolucionTeams.Properties.Resources.LogoSonda1;
            this.PBLogoP2.ImageLocation = "";
            this.PBLogoP2.Location = new System.Drawing.Point(483, 0);
            this.PBLogoP2.Name = "PBLogoP2";
            this.PBLogoP2.Size = new System.Drawing.Size(145, 70);
            this.PBLogoP2.TabIndex = 0;
            this.PBLogoP2.TabStop = false;
            this.PBLogoP2.Click += new System.EventHandler(this.PBLogoP2_Click);
            // 
            // PBPieP2
            // 
            this.PBPieP2.Image = global::SolucionTeams.Properties.Resources.PiedePagina1;
            this.PBPieP2.ImageLocation = "";
            this.PBPieP2.Location = new System.Drawing.Point(-9, 395);
            this.PBPieP2.Name = "PBPieP2";
            this.PBPieP2.Size = new System.Drawing.Size(651, 13);
            this.PBPieP2.TabIndex = 1;
            this.PBPieP2.TabStop = false;
            // 
            // Pagina2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(643, 410);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblContinuar);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.LblContrasena);
            this.Controls.Add(this.BtnAtrP2);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.PBLogoP2);
            this.Controls.Add(this.PBPieP2);
            this.Controls.Add(this.BtnSalirP2);
            this.Controls.Add(this.BtnContP2);
            this.Controls.Add(this.LblTituloP2);
            this.Controls.Add(this.PBFondoP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pagina2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solucion Teams";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pagina2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PBFondoP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogoP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBPieP2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTituloP2;
        private System.Windows.Forms.Button BtnContP2;
        private System.Windows.Forms.Button BtnSalirP2;
        private System.Windows.Forms.PictureBox PBFondoP2;
        private System.Windows.Forms.PictureBox PBPieP2;
        private System.Windows.Forms.PictureBox PBLogoP2;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblContrasena;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.Button BtnAtrP2;
        private System.Windows.Forms.Label LblContinuar;
    }
}

