using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    // classe pour les joueurs de types Gardiens
    public class Gardien : Joueur, IStatistique
    {
        //attributs
        private int nbButsAllouees;
        private int nbMatch;
        private float moyenneButsAllouees;

        //propriétés
        public int NbButsAllouees
        {
            get { return this.nbButsAllouees; }
            set { this.nbButsAllouees = value; }
        }

        public int NbMatch
        {
            get { return this.nbMatch; }
            set { this.nbMatch = value; }
        }

        public float MoyenneButsAllouees
        {
            get { return this.moyenneButsAllouees; }
            set { this.moyenneButsAllouees = value; }
        }


        //constructeur
        public Gardien(string p_joueurID = "", string p_equipeNom = "", string p_nom = "", string p_prenom = "", string p_numChandail = "", int p_nbButsAllouees = 0, int p_nbMatch = 0, float p_moyenneButsAllouees = 0)
            : base(p_joueurID, p_equipeNom, p_nom, p_prenom, p_numChandail)
        {

            this.nbButsAllouees = p_nbButsAllouees;
            this.nbMatch = p_nbMatch;
            this.moyenneButsAllouees = p_moyenneButsAllouees;
        }

        /// <summary>
        /// Ajoute un match
        /// </summary>
        public override void AjouterMatch()
        {
            this.nbMatch++;

        }

        /// <summary>
        /// Ajoute un but
        /// </summary>
        /// <returns></returns>
        public int AjouterBut()
        {
            this.nbButsAllouees++;
            return this.nbButsAllouees;
            
        }

        /// <summary>
        /// Calcul la moyenne de buts allouées
        /// </summary>
        /// <returns></returns>
        public double CalculerStats()
        {
            nbMatch = this.nbMatch;
            if (this.nbMatch == 0) 
            {
                nbMatch = 1;
            }

            this.moyenneButsAllouees = this.nbButsAllouees / nbMatch;
            return this.moyenneButsAllouees;
        }
    }
}
