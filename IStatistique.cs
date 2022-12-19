using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    //interface pour les joueurs (Attaquant et Gardien)
    internal interface IStatistique
    {
        /// <summary>
        /// Ajoute un but
        /// </summary>
        /// <returns></returns>
        int AjouterBut();

        /// <summary>
        /// Calcul la moyenne de buts
        /// </summary>
        /// <returns></returns>
        double CalculerStats();
    }
}
