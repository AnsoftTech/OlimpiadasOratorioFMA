using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace SistemaSeleccionReina
{
    public partial class FrmGanadora : Form
    {
        WindowsMediaPlayer AplausosSound = new WindowsMediaPlayer();

        public FrmGanadora()
        {
            InitializeComponent();
            lblGanador.Parent = pictureBox1;
            lblGanador.BackColor = Color.Transparent;

            AplausosSound.controls.play();

            AplausosSound.URL = @"D:\Personal\Proyectos\Angeluz\GitHub\OlimpiadasOratorioFMA\Olimpiadas\SistemaSeleccionReina\Sonidos\aplausos.mp3";

            //elimina los index que ya han sido seleccionados en algun otro sorteo
            for (int i = 0; i < Modulo.Modulo.Eliminados.Count; i++)            
                Modulo.Modulo.Candidatas.RemoveAt(Modulo.Modulo.Eliminados[i]);
            
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
            AplausosSound.controls.play();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Modulo.Modulo.Eliminados.Add(Modulo.Modulo.indexGanadora);
            
            var form = new FrmOlimpiadas();
            form.FormClosed += (s, arg) => Close();
            form.Show();
            Hide();
        }
    }
}
