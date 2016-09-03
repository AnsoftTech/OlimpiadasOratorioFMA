using System;
using System.Windows.Forms;

namespace SistemaSeleccionReina
{
    public partial class FrmGanadora : Form
    {
        public FrmGanadora()
        {
            InitializeComponent();
            seleccionGanadora();
            
        }

        void seleccionGanadora()
        {
            var rand = new Random();
            Modulo.Modulo.indexGanadora = rand.Next(0, Modulo.Modulo.Candidatas.Count);
            lblGanador.Text = Modulo.Modulo.Candidatas[Modulo.Modulo.indexGanadora];
        }

        private void btnOtra_Click(object sender, EventArgs e)
        {
            seleccionGanadora();
        }
    }
}
