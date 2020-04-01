namespace BuilderTools
{
    partial class Lista_Obras
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
            this.lblObrasCalculadas = new System.Windows.Forms.Label();
            this.ptbObrasCalculadas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presupuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptbObrasCalculadas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblObrasCalculadas
            // 
            this.lblObrasCalculadas.AutoSize = true;
            this.lblObrasCalculadas.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrasCalculadas.Location = new System.Drawing.Point(48, 21);
            this.lblObrasCalculadas.Name = "lblObrasCalculadas";
            this.lblObrasCalculadas.Size = new System.Drawing.Size(250, 24);
            this.lblObrasCalculadas.TabIndex = 0;
            this.lblObrasCalculadas.Text = "Obras calculadas";
            // 
            // ptbObrasCalculadas
            // 
            this.ptbObrasCalculadas.Image = global::BuilderTools.Properties.Resources.lista;
            this.ptbObrasCalculadas.Location = new System.Drawing.Point(304, 3);
            this.ptbObrasCalculadas.Name = "ptbObrasCalculadas";
            this.ptbObrasCalculadas.Size = new System.Drawing.Size(91, 54);
            this.ptbObrasCalculadas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbObrasCalculadas.TabIndex = 1;
            this.ptbObrasCalculadas.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(23)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.ptbObrasCalculadas);
            this.panel1.Controls.Add(this.lblObrasCalculadas);
            this.panel1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(40, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 312);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Presupuesto,
            this.Fecha});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(23, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 87);
            this.dataGridView1.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre obra";
            this.Nombre.Name = "Nombre";
            // 
            // Presupuesto
            // 
            this.Presupuesto.HeaderText = "Presupuesto sugerido";
            this.Presupuesto.Name = "Presupuesto";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Creación";
            this.Fecha.Name = "Fecha";
            // 
            // Lista_Obras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(484, 381);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Lista_Obras";
            this.Text = "Lista_Obras";
            ((System.ComponentModel.ISupportInitialize)(this.ptbObrasCalculadas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblObrasCalculadas;
        private System.Windows.Forms.PictureBox ptbObrasCalculadas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presupuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}