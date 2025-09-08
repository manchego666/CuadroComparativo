//===================================
// PROGRAMA: Cuadro Comparativo
// Autor: ZORRODEV (ChrisDG) - UAS Virtual - 2025
// Fecha: 2025-09-08
// Clase : CapaLogica / LogicaComparar
// Descripción:
//  Utilidades de validación para el juego de cuadro comparativo.
//  Ofrece dos estrategias de corrección:
//   1) Por índice   -> Tag de cada ComboBox guarda el índice correcto (int).
//   2) Por texto    -> Tag de cada ComboBox guarda el texto correcto (string).
//  Ambas funciones recorren todos los ComboBox del formulario (y de sus
//  contenedores) y devuelven el número de errores detectados.
//===================================

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CuadroComparativo.CapaLogica
{
    public static class LogicaComparar
    {
        /// <summary>
        /// Valida TODOS los ComboBox del formulario comparando por ÍNDICE.
        /// Requiere que cada ComboBox tenga en Tag el índice (int) de la opción correcta.
        /// Suma 1 error si:
        ///  - No hay selección (SelectedIndex < 0)
        ///  - Tag es nulo
        ///  - Tag no es un entero válido
        ///  - SelectedIndex != índice correcto guardado en Tag
        /// Marca en MistyRose los que fallen; restaura el color en los correctos.
        /// </summary>
        /// <param name="root">Formulario o contenedor raíz desde donde buscar ComboBox.</param>
        /// <returns>Número total de errores.</returns>
        public static int ContarErroresPorIndice(Control root)
        {
            int errores = 0;

            foreach (var cb in GetAllCombos(root))
            {
                // 1) Sin selección
                if (cb.SelectedIndex < 0) { PintarError(cb, ref errores); continue; }

                // 2) Tag nulo
                if (cb.Tag == null) { PintarError(cb, ref errores); continue; }

                // 3) Tag no convertible a int
                if (!int.TryParse(cb.Tag.ToString(), out int idxCorrecto))
                {
                    PintarError(cb, ref errores); continue;
                }

                // 4) Índice elegido distinto al índice correcto
                if (cb.SelectedIndex != idxCorrecto) { PintarError(cb, ref errores); continue; }

                // OK
                cb.BackColor = SystemColors.Window;
            }

            return errores;
        }

        /// <summary>
        /// Valida TODOS los ComboBox del formulario comparando por TEXTO.
        /// Requiere que cada ComboBox tenga en Tag el TEXTO EXACTO de la respuesta correcta.
        /// Suma 1 error si:
        ///  - No hay selección
        ///  - Tag es nulo
        ///  - Texto seleccionado != texto correcto (Tag)
        /// Ventaja: si cambias el orden de los Items, NO necesitas actualizar Tag.
        /// </summary>
        /// <param name="root">Formulario o contenedor raíz desde donde buscar ComboBox.</param>
        /// <returns>Número total de errores.</returns>
        public static int ContarErroresPorTexto(Control root)
        {
            int errores = 0;

            foreach (var cb in GetAllCombos(root))
            {
                if (cb.SelectedIndex < 0) { PintarError(cb, ref errores); continue; }
                if (cb.Tag == null) { PintarError(cb, ref errores); continue; }

                string elegido = (cb.Text ?? string.Empty).Trim();
                string correcto = (cb.Tag.ToString() ?? string.Empty).Trim();

                if (!string.Equals(elegido, correcto, System.StringComparison.Ordinal))
                {
                    PintarError(cb, ref errores); continue;
                }

                cb.BackColor = SystemColors.Window;
            }

            return errores;
        }

        /// <summary>
        /// Devuelve cuántos ComboBox hay en el formulario (se buscan recursivamente).
        /// Útil para calcular aciertos: aciertos = TotalCombos - errores.
        /// </summary>
        public static int TotalCombos(Control root) => GetAllCombos(root).Count;

        /// <summary>
        /// Recorre recursivamente el árbol de controles y devuelve todos los ComboBox.
        /// </summary>
        private static List<ComboBox> GetAllCombos(Control root)
        {
            var list = new List<ComboBox>();

            void Walk(Control c)
            {
                foreach (Control child in c.Controls)
                {
                    if (child is ComboBox cb) list.Add(cb);
                    Walk(child); // recursión: baja a contenedores anidados
                }
            }

            Walk(root);
            return list;
        }

        /// <summary>
        /// Marca un ComboBox con color de error y aumenta el contador.
        /// </summary>
        private static void PintarError(ComboBox cb, ref int errores)
        {
            cb.BackColor = Color.MistyRose;
            errores++;
        }
    }
}
