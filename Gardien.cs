using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    public class Gardien : Joueur
    {
        //attribut
        private int nbButsAllouees;
        private int nbMatch;
        private float moyenneButsAllouees;

        //propriété
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
    }
}
