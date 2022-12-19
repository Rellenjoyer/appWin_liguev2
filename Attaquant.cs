using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    //Classe des joueurs de type Attaquants
    public class Attaquant : Joueur, IStatistique
    {
        //attributs
        private int nbBut;
        private int nbMatch;
        private double moyenneBut;

        //propriétés
        public int NbBut
        {
            get { return this.nbBut; }
            set { this.nbBut = value; }
        }

        public int NbMatch
        {
            get { return this.nbMatch; }
            set { this.nbMatch = value; }
        }

        public double MoyenneBut
        {
            get { return this.moyenneBut; }
            set { this.moyenneBut = value; }
        }


        //constructeur
        public Attaquant(string p_joueurID = "", string p_equipeID = "", string p_nom = "", string p_prenom = "", string p_numChandail = "", int p_nbBut = 0, int p_nbMatch = 0, double p_moyenneBut = 0)
            : base(p_joueurID, p_equipeID, p_nom, p_prenom, p_numChandail)
        {

            this.nbBut = p_nbBut;
            this.nbMatch = p_nbMatch;
            this.moyenneBut = p_moyenneBut;
        }

        /// <summary>
        /// Ajoute un but
        /// </summary>
        public void AjouterMatch()
        {
            this.nbMatch++;
            
        }

        /// <summary>
        /// Ajoute un match
        /// </summary>
        /// <returns></returns>
        public int AjouterBut()
        {
            this.nbBut+= 1;
            return this.nbBut;
            
        }

        /// <summary>
        /// Calcul la moyenne de but
        /// </summary>
        /// <returns></returns>
        public double CalculerStats()
        {
            nbMatch = this.nbMatch;
            if (this.nbMatch == 0)
            {
                nbMatch = 1;
            }

            this.moyenneBut = this.nbBut / nbMatch;
            return this.moyenneBut;
            
        }
    }
}
