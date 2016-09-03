using System;
using System.Windows.Forms;

namespace SistemaSeleccionReina
{
    public partial class FrmCarga : Form
    {
        public FrmCarga()
        {
            InitializeComponent();
        }

        private void FrmCarga_Load(object sender, EventArgs e)
        {
            tmrTiempo.Interval = 5000;
            tmrTiempo.Enabled = true;
            tmrTiempo.Start();
            tmrTiempo.Tick += TmrTiempo_Tick;
            prbConteo.Step = 2;
            prbConteo.Value = 2;
            prbConteo.Minimum = 1;
            prbConteo.Maximum = 100;
        }

        private void TmrTiempo_Tick(object sender, EventArgs e)
        {
            
            prbConteo.PerformStep();
            if (prbConteo.Maximum.Equals(100))
            {
                var form = new FrmGanadora();
                form.Show();
                tmrTiempo.Stop();
                Hide();
            }
        }
    }
}
