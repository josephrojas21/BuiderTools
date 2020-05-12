namespace BuilderTools
{
    partial class home
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar_Sesion = new System.Windows.Forms.Button();
            this.lblHome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAdministrador = new System.Windows.Forms.Label();
            this.ptbUsuario = new System.Windows.Forms.PictureBox();
            this.lblBuilderTools = new System.Windows.Forms.Label();
            this.lblCalcularObra = new System.Windows.Forms.Label();
            this.lblMisObras = new System.Windows.Forms.Label();
            this.lblSoporteTecnico = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnMisObras = new System.Windows.Forms.Button();
            this.btnCalcularObra = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnCerrar_Sesion);
            this.panel2.Controls.Add(this.lblHome);
            this.panel2.Location = new System.Drawing.Point(205, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 62);
            this.panel2.TabIndex = 1;
            // 
            // btnCerrar_Sesion
            // 
            this.btnCerrar_Sesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnCerrar_Sesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar_Sesion.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar_Sesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar_Sesion.Location = new System.Drawing.Point(460, 16);
            this.btnCerrar_Sesion.Name = "btnCerrar_Sesion";
            this.btnCerrar_Sesion.Size = new System.Drawing.Size(127, 32);
            this.btnCerrar_Sesion.TabIndex = 6;
            this.btnCerrar_Sesion.Text = "Cerrar sesión";
            this.btnCerrar_Sesion.UseVisualStyleBackColor = false;
            this.btnCerrar_Sesion.Click += new System.EventHandler(this.btnCerrar_Sesion_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(30, 21);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(97, 27);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.lblAdministrador);
            this.panel1.Controls.Add(this.ptbUsuario);
            this.panel1.Controls.Add(this.lblBuilderTools);
            this.panel1.Location = new System.Drawing.Point(-3, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 428);
            this.panel1.TabIndex = 0;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.AutoSize = true;
            this.lblAdministrador.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Location = new System.Drawing.Point(35, 207);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(151, 16);
            this.lblAdministrador.TabIndex = 2;
            this.lblAdministrador.Text = "Administrador";
            this.lblAdministrador.Click += new System.EventHandler(this.lblAdministrador_Click);
            // 
            // ptbUsuario
            // 
            this.ptbUsuario.Image = global::BuilderTools.Properties.Resources.usuariohome;
            this.ptbUsuario.Location = new System.Drawing.Point(52, 86);
            this.ptbUsuario.Name = "ptbUsuario";
            this.ptbUsuario.Size = new System.Drawing.Size(111, 109);
            this.ptbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbUsuario.TabIndex = 0;
            this.ptbUsuario.TabStop = false;
            // 
            // lblBuilderTools
            // 
            this.lblBuilderTools.AutoSize = true;
            this.lblBuilderTools.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuilderTools.Location = new System.Drawing.Point(16, 353);
            this.lblBuilderTools.Name = "lblBuilderTools";
            this.lblBuilderTools.Size = new System.Drawing.Size(190, 24);
            this.lblBuilderTools.TabIndex = 1;
            this.lblBuilderTools.Text = "BuilderTools";
            // 
            // lblCalcularObra
            // 
            this.lblCalcularObra.AutoSize = true;
            this.lblCalcularObra.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcularObra.Location = new System.Drawing.Point(252, 310);
            this.lblCalcularObra.Name = "lblCalcularObra";
            this.lblCalcularObra.Size = new System.Drawing.Size(138, 16);
            this.lblCalcularObra.TabIndex = 5;
            this.lblCalcularObra.Text = "Calcular obra";
            // 
            // lblMisObras
            // 
            this.lblMisObras.AutoSize = true;
            this.lblMisObras.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMisObras.Location = new System.Drawing.Point(463, 310);
            this.lblMisObras.Name = "lblMisObras";
            this.lblMisObras.Size = new System.Drawing.Size(98, 16);
            this.lblMisObras.TabIndex = 6;
            this.lblMisObras.Text = "Mis obras";
            // 
            // lblSoporteTecnico
            // 
            this.lblSoporteTecnico.AutoSize = true;
            this.lblSoporteTecnico.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoporteTecnico.Location = new System.Drawing.Point(630, 310);
            this.lblSoporteTecnico.Name = "lblSoporteTecnico";
            this.lblSoporteTecnico.Size = new System.Drawing.Size(158, 16);
            this.lblSoporteTecnico.TabIndex = 7;
            this.lblSoporteTecnico.Text = "Soporte técnico";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnAyuda.Image = global::BuilderTools.Properties.Resources.ayuda;
            this.btnAyuda.Location = new System.Drawing.Point(628, 149);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(160, 148);
            this.btnAyuda.TabIndex = 4;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // btnMisObras
            // 
            this.btnMisObras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnMisObras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMisObras.Image = global::BuilderTools.Properties.Resources.lista;
            this.btnMisObras.Location = new System.Drawing.Point(431, 149);
            this.btnMisObras.Name = "btnMisObras";
            this.btnMisObras.Size = new System.Drawing.Size(160, 148);
            this.btnMisObras.TabIndex = 3;
            this.btnMisObras.UseVisualStyleBackColor = false;
            this.btnMisObras.Click += new System.EventHandler(this.btnMisObras_Click);
            // 
            // btnCalcularObra
            // 
            this.btnCalcularObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnCalcularObra.Image = global::BuilderTools.Properties.Resources.calcular;
            this.btnCalcularObra.Location = new System.Drawing.Point(240, 149);
            this.btnCalcularObra.Name = "btnCalcularObra";
            this.btnCalcularObra.Size = new System.Drawing.Size(160, 148);
            this.btnCalcularObra.TabIndex = 2;
            this.btnCalcularObra.UseVisualStyleBackColor = false;
            this.btnCalcularObra.Click += new System.EventHandler(this.btnCalcularObra_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 405);
            this.Controls.Add(this.lblSoporteTecnico);
            this.Controls.Add(this.lblMisObras);
            this.Controls.Add(this.lblCalcularObra);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnMisObras);
            this.Controls.Add(this.btnCalcularObra);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "home";
            this.Text = "home";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbUsuario;
        private System.Windows.Forms.Label lblAdministrador;
        private System.Windows.Forms.Label lblBuilderTools;
        private System.Windows.Forms.Button btnCalcularObra;
        private System.Windows.Forms.Button btnMisObras;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Label lblCalcularObra;
        private System.Windows.Forms.Label lblMisObras;
        private System.Windows.Forms.Label lblSoporteTecnico;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Button btnCerrar_Sesion;
    }
}