using System;
using System.Collections.Generic;
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
            form.FormClosed += (s, args) => Close();
            form.Show();
            Hide();            
        }

        private void setNombres(string _Nombres)
        {
            gbOpciones.Text = _Nombres;
            txtInfancia.Focus();
        }

        void llenarCandidatas()
        {
            Modulo.Modulo.Candidatas = new List<string>();
            Modulo.Modulo.Candidatas.Add(txtInfancia.Text);
            Modulo.Modulo.Candidatas.Add(txtPrimeraA.Text);
            Modulo.Modulo.Candidatas.Add(txtPrimeraB.Text);
            Modulo.Modulo.Candidatas.Add(txtSegundaA.Text);
            Modulo.Modulo.Candidatas.Add(txtSegundaB.Text);
            Modulo.Modulo.Candidatas.Add(txtConfirmacionA.Text);
            Modulo.Modulo.Candidatas.Add(txtConfirmacionB.Text);
        }

        private void rdCandidatas_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            setNombres("NOMBRES DE LAS CANDIDATAS");            
        }

        private void rdEquipo_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            setNombres("NOMBRES DE LOS EQUIPOS");            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            setNombres("MEJOR BARRA");            
            llenarCampos();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            limpiarCampos();
            setNombres("MEJOR PANCARTA");            
            llenarCampos();
        }

        private void llenarCampos()
        {
            txtInfancia.Text = label1.Text;
            txtPrimeraA.Text = label2.Text;
            txtPrimeraB.Text = label3.Text;
            txtSegundaA.Text = label4.Text;
            txtSegundaB.Text = label5.Text;
            txtConfirmacionA.Text = label6.Text;
            txtConfirmacionB.Text = label7.Text;
            btnSeleccion.Focus();
        }

        private void limpiarCampos()
        {
            foreach (var item in gbOpciones.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
            }
        }
    }
}
