using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SistemaSeleccionReina
{
    public partial class FrmCarga : Form
    {
        WindowsMediaPlayer TamboresSound = new WindowsMediaPlayer();
        System.Timers.Timer timer = new System.Timers.Timer(4000);

        public FrmCarga()
        {
            InitializeComponent();
            TamboresSound.URL = @"D:\Personal\Proyectos\Angeluz\GitHub\OlimpiadasOratorioFMA\Olimpiadas\SistemaSeleccionReina\Sonidos\tabores.mp3";
            
            timer.Enabled = true;
            timer.Elapsed += Timer_Elapsed;            
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            TamboresSound.controls.play();
            timer.Enabled = false;
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            timer.Stop();
            var form = new FrmGanadora();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
            Hide();
        }
    }
}
