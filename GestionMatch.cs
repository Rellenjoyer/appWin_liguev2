using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    //Classe pouur facilité la gestion de fin de match
    public static class GestionMatch
    {
        /// <summary>
        /// Calcul les nouvelles stats des équipes à partir du résultat du match
        /// </summary>
        /// <param name="p_equipe1">équipe locale</param>
        /// <param name="p_nbBut1">Nombre de buts de l'équipe locale</param>
        /// <param name="p_equipe2">Équipe visiteure</param>
        /// <param name="p_nbBut2">Nombre de but de l'équipe visiteure</param>
        /// <returns></returns>
        public static int FinMatch(Equipe p_equipe1, int p_nbBut1, Equipe p_equipe2, int p_nbBut2) 
        {
            p_equipe1.AjouterButsPour(p_nbBut1);
            p_equipe1.AjouterButsContre(p_nbBut2);

            p_equipe2.AjouterButsPour(p_nbBut2);
            p_equipe2.AjouterButsContre(p_nbBut1);

            if (p_nbBut1 > p_nbBut2) 
            {
                p_equipe1.AjouterVictoire();
                p_equipe2.AjouterDefaite();
            }

            if (p_nbBut1 < p_nbBut2)
            {
                p_equipe1.AjouterDefaite();
                p_equipe2.AjouterVictoire();
            }

            if (p_nbBut1 == p_nbBut2)
            {
                p_equipe1.AjouterNulle();
                p_equipe2.AjouterNulle();
            }

            p_equipe1.CalculerButDiff();
            p_equipe2.CalculerButDiff();
            p_equipe1.CalculerPoint();
            p_equipe2.CalculerPoint();

            return 1;
        }
    }
}
