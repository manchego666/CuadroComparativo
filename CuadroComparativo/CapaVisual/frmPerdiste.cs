//===================================
// PROGRAMA: Cuadro Comparativo
// Autor: ZORRODEV (ChrisDG) - UAS Virtual - 2025
// Fecha: 2025-09-08
// Clase : CapaVisual / frmInicio
// Descripción:
//  Formulario que se muestra al perder el juego.
//  Permite reintentar el juego o salir de la aplicación.
//===================================

using System;
using System.Windows.Forms;

namespace CuadroComparativo.CapaVisual
{
    public partial class frmPerdiste : Form
    {
        public frmPerdiste(int aciertos, int total)
        {
            InitializeComponent();
            lblAciertos.Text = $"ACIERTOS: {aciertos}/{total}";
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            new frmJuego().Show();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
