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
            this.components = new System.ComponentModel.Container();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            this.prbConteo = new System.Windows.Forms.ProgressBar();
            this.pnlFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.prbConteo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(302, 235);
            this.pnlFondo.TabIndex = 0;
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Interval = 1000;
            // 
            // prbConteo
            // 
            this.prbConteo.Location = new System.Drawing.Point(47, 144);
            this.prbConteo.Name = "prbConteo";
            this.prbConteo.Size = new System.Drawing.Size(220, 23);
            this.prbConteo.TabIndex = 0;
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
            this.Load += new System.EventHandler(this.FrmCarga_Load);
            this.pnlFondo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Timer tmrTiempo;
        private System.Windows.Forms.ProgressBar prbConteo;
    }
}