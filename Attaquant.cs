using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    public class Attaquant : Joueur
    {
        //attribut
        private int nbBut;
        private int nbMatch;
        private float moyenneBut;

        //propriété
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

        public float MoyenneBut
        {
            get { return this.moyenneBut; }
            set { this.moyenneBut = value; }
        }


        //constructeur
        public Attaquant(string p_joueurID = "", string p_equipeID = "", string p_nom = "", string p_prenom = "", string p_numChandail = "", int p_nbBut = 0, int p_nbMatch = 0, float p_moyenneBut = 0)
            : base(p_joueurID, p_equipeID, p_nom, p_prenom, p_numChandail)
        {

            this.nbBut = p_nbBut;
            this.nbMatch = p_nbMatch;
            this.moyenneBut = p_moyenneBut;
        }
    }
}
