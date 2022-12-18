using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    public class Equipe
    {
        //attribut
        private string equipeNom;
        private int nbVictoire;
        private int nbDefaite;
        private int nbNulle;
        private int nbPoint;
        private int nbButPour;
        private int nbButContre;
        private int nbButDiff;

        //propriété



        public string EquipeNom
        {
            get { return this.equipeNom; }
            set { this.equipeNom = value; }
        }
        public int NbVictoire
        {
            get { return this.nbVictoire; }
            set { this.nbVictoire = value; }
        }
        public int NbDefaite
        {
            get { return this.nbDefaite; }
            set { this.nbDefaite = value; }
        }
        public int NbNulle
        {
            get { return this.nbNulle; }
            set { this.nbNulle = value; }
        }
        public int NbPoint
        {
            get { return this.nbPoint; }
            set { this.nbPoint = value; }
        }
        public int NbButPour
        {
            get { return this.nbButPour; }
            set { this.nbButPour = value; }
        }
        public int NbButContre
        {
            get { return this.nbButContre; }
            set { this.nbButContre = value; }
        }
        public int NbButDiff
        {
            get { return this.nbButDiff; }
            set { this.nbButDiff = value; }
        }


        //constructeur
        public Equipe(string p_equipeNom = "", int p_nbVictoire = 0, int p_nbDefaite = 0, int p_nbNulle = 0, int p_nbPoint = 0, int p_nbButPour = 0, int p_nbButContre = 0, int p_nbButDiff = 0)
        {

            this.equipeNom = p_equipeNom;
            this.nbVictoire = p_nbVictoire;
            this.nbDefaite = p_nbDefaite;
            this.nbNulle = p_nbNulle;
            this.nbPoint = p_nbPoint;
            this.nbButPour = p_nbButPour;
            this.NbButContre = p_nbButContre;
            this.NbButDiff = p_nbButDiff;

        }
    }
}
