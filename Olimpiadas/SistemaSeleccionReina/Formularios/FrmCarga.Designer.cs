namespace SistemaSeleccionReina
{
    partial class FrmCarga
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
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.btnSeleccion);
            this.pnlFondo.Controls.Add(this.pictureBox1);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(302, 235);
            this.pnlFondo.TabIndex = 0;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.Location = new System.Drawing.Point(215, 28);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccion.TabIndex = 0;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = true;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaSeleccionReina.Properties.Resources.patricio_redoble;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 235);
            this.Controls.Add(this.pnlFondo);
            this.Name = "FrmCarga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionando";
            this.pnlFondo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}