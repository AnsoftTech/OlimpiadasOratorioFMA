using System;
using System.Windows.Forms;

namespace SistemaSeleccionReina
{
    public partial class FrmOlimpiadas : Form
    {   
        public FrmOlimpiadas()
        {
            InitializeComponent();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            llenarCandidatas();
            var form = new FrmCarga();
            form.Show();
            Hide();
        }

        void llenarCandidatas()
        {
            Modulo.Modulo.Candidatas.Add(txtInfancia.Text);
            Modulo.Modulo.Candidatas.Add(txtPrimeraA.Text);
            Modulo.Modulo.Candidatas.Add(txtPrimeraB.Text);
            Modulo.Modulo.Candidatas.Add(txtSegundaA.Text);
            Modulo.Modulo.Candidatas.Add(txtSegundaB.Text);
            Modulo.Modulo.Candidatas.Add(txtConfirmacionA.Text);
            Modulo.Modulo.Candidatas.Add(txtConfirmacionB.Text);
        }
    }
}
