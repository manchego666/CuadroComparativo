//===================================
// PROGRAMA: Cuadro Comparativo
// Autor: ZORRODEV (ChrisDG) - UAS Virtual - 2025
// Fecha: 2025-09-08
// Clase : CapaVisual / frmInicio
// Descripción:
//  Formulario de inicio del juego.
//  Permite iniciar una nueva partida o salir de la aplicación.
// Tiene música de fondo que se reproduce en bucle.
// La música se detiene al cerrar el formulario.
// este formulario se oculta al iniciar el juego y se muestra el formulario del juego y la música sigue sonando.
//===================================


using System.Media;
using CuadroComparativo.CapaVisual;
using CuadroComparativo.Properties;

namespace CuadroComparativo
{
    public partial class frmInicio : Form
    {
        private SoundPlayer musica;
        public frmInicio()
        {
            InitializeComponent();
            musica = new SoundPlayer(Properties.Resources.musica);
            musica.PlayLooping();
        }
        private void btnJugar_Click(object sender, EventArgs e)
        {
            new frmJuego().Show();
            Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close(); // o Application.Exit();
        }
    }
}
