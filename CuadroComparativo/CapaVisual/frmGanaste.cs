//===================================
// PROGRAMA: Cuadro Comparativo
// Autor: ZORRODEV (ChrisDG) - UAS Virtual - 2025
// Fecha: 2025-09-08
// Clase : CapaVisual / frmInicio
// Descripción:
//  Formulario que se muestra al ganar el juego.
//  Permite salir de la aplicación.
//===================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuadroComparativo.CapaVisual
{
    public partial class frmGanaste : Form
    {
        public frmGanaste()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
