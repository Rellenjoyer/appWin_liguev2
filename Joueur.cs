using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWin_liguev2
{
    //Classe parent pour les attaquants et les gardiens
    public abstract class Joueur
    {

        //attributs
        private string joueurID;
        private string equipeNom;
        private string nom;
        private string prenom;
        private string numChandail;


        //propriétés
        public string JoueurID
        {
            get { return this.joueurID; }
            set { this.joueurID = value; }
        }

        public string EquipeNom
        {
            get { return this.equipeNom; }
            set { this.equipeNom = value; }
        }

        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }

        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }

        public string NumChandail
        {
            get { return this.numChandail; }
            set { this.numChandail = value; }
        }

        //constructeur
        public Joueur(string p_joueurID = "", string p_equipeNom = "", string p_nom = "", string p_prenom = "", string p_numChandail = "")
        {
            this.joueurID = p_joueurID;
            this.equipeNom = p_equipeNom;
            this.nom = p_nom;
            this.prenom = p_prenom;
            this.numChandail = p_numChandail;
        }

        public abstract void AjouterMatch();
        
    }
}