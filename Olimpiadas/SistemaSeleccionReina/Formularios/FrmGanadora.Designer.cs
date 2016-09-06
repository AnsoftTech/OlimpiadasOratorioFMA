namespace SistemaSeleccionReina
{
    partial class FrmGanadora
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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnOtra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGanador = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.btnNuevo);
            this.pnlFondo.Controls.Add(this.btnOtra);
            this.pnlFondo.Controls.Add(this.lblGanador);
            this.pnlFondo.Controls.Add(this.pictureBox1);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(691, 324);
            this.pnlFondo.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(618, 272);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(73, 40);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nueva Votación";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnOtra
            // 
            this.btnOtra.Location = new System.Drawing.Point(618, 3);
            this.btnOtra.Name = "btnOtra";
            this.btnOtra.Size = new System.Drawing.Size(73, 40);
            this.btnOtra.TabIndex = 3;
            this.btnOtra.Text = "Otra Selección";
            this.btnOtra.UseVisualStyleBackColor = true;
            this.btnOtra.Click += new System.EventHandler(this.btnOtra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaSeleccionReina.Properties.Resources._52064_Fuegos_Artificiales_Mensajes_Tarjetas_Y_Im_genes_Con_Fuegos_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblGanador
            // 
            this.lblGanador.AutoSize = true;
            this.lblGanador.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanador.ForeColor = System.Drawing.Color.White;
            this.lblGanador.Location = new System.Drawing.Point(123, 99);
            this.lblGanador.Name = "lblGanador";
            this.lblGanador.Size = new System.Drawing.Size(232, 54);
            this.lblGanador.TabIndex = 1;
            this.lblGanador.Text = "Ganadora";
            this.lblGanador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmGanadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 324);
            this.Controls.Add(this.pnlFondo);
            this.Name = "FrmGanadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganadora";
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblGanador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnOtra;
        private System.Windows.Forms.Button btnNuevo;
    }
}