//===================================
// PROGRAMA: Cuadro Comparativo
// Autor: ZORRODEV (ChrisDG) - UAS Virtual - 2025
// Fecha: 2025-09-08
// Clase : CapaVisual / frmInicio
// Descripción:
//  Formulario principal del juego.
//  Permite comprobar las respuestas o salir de la aplicación.
// si quieres usar el metodo de contar errores por índice, descomenta la línea correspondiente y comenta la de contar errores por texto.
// tendras que asegurarte de que los tags de los combobox sean enteros (índices) en lugar de cadenas (textos).
// tendras que ajustar los tags en el diseñador o en el código al inicializar los combobox de manera adecuada. ( la respuesta correcta esta en el primero entonces el tag sera 0, si es el segundo sera 1, etc)
//===================================


using System;
using System.Windows.Forms;
using CuadroComparativo.CapaLogica;

namespace CuadroComparativo.CapaVisual
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int total = LogicaComparar.TotalCombos(this);
            //int errores = LogicaComparar.ContarErroresPorIndice(this);
            int errores = LogicaComparar.ContarErroresPorTexto(this);
            int aciertos = total - errores;

            if (errores == 0)
            {
                new frmGanaste().Show();
                Hide();
            }
            else
            {
                new frmPerdiste(aciertos, total).Show();
                Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

