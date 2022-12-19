using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appWin_liguev2
{
    public partial class FormScoreMatch : Form
    {
        Adonet ado;
        public string nomEquipe1 = "";
        public string nomEquipe2 = "";

        Equipe equipe1 = new Equipe();
        Equipe equipe2 = new Equipe();
        List<Attaquant> ls_att1 = new List<Attaquant>();
        List<Attaquant> ls_att2 = new List<Attaquant>();
        Gardien gar1 = new Gardien();
        Gardien gar2 = new Gardien();

        
        public FormScoreMatch()
        {
            InitializeComponent();
        }

        private void FormScoreMatch_Load(object sender, EventArgs e)
        {
            labelEquipe1.Text = nomEquipe1;
            labelEquipe2.Text = nomEquipe2;
            
            
            Attaquant att;

            //Crée une liste d'objet attaquants à partir de la base de donnée
            ado = new Adonet();
            string query = "Select * from Attaquants";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                string nomEquipe = row["nomEquipe"].ToString();
                string joueurID = row["joueurID"].ToString();
                string nom = row["nom"].ToString();
                string prenom = row["prenom"].ToString();
                string numChandail = row["numChandail"].ToString();
                int nbBut = Convert.ToInt32(row["nbBut"]); 
                int nbMatch = Convert.ToInt32(row["nbMatch"]);
                float moyenneBut = float.Parse(row["moyenneBut"].ToString());


                if (nomEquipe == nomEquipe1)
                {
                    comboBoxNum1.Items.Add(row["numChandail"]);

                    att = new Attaquant(joueurID, nomEquipe, nom, prenom, numChandail, nbBut, nbMatch, moyenneBut);
                    ls_att1.Add(att);
                }
                if (nomEquipe == nomEquipe2)
                {
                    comboBoxNum2.Items.Add(row["numChandail"]);

                    att = new Attaquant(joueurID, nomEquipe, nom, prenom, numChandail, nbBut, nbMatch, moyenneBut);
                    ls_att2.Add(att);
                }
            }

            //Crée 2 objets équipes à partir de la base de donnée
            ado = new Adonet();
            query = "Select * from Equipes";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                string nomEquipe = row["nomEquipe"].ToString();
                int nbVictoire =  Convert.ToInt32(row["nbVictoire"]);
                int nbDefaite = Convert.ToInt32(row["nbDefaite"]);
                int nbNulle = Convert.ToInt32(row["nbNulle"]);
                int nbPoint = Convert.ToInt32(row["nbPoint"]);
                int nbButPour = Convert.ToInt32(row["nbButPour"]);
                int nbButContre = Convert.ToInt32(row["nbButContre"]);
                int nbButDiff = Convert.ToInt32(row["nbButDiff"]);


                if (nomEquipe == nomEquipe1)
                {

                    equipe1.EquipeNom= nomEquipe;
                    equipe1.NbVictoire= nbVictoire;
                    equipe1.NbDefaite= nbDefaite;
                    equipe1.NbNulle= nbNulle;
                    equipe1.NbPoint= nbPoint;
                    equipe1.NbButPour= nbButPour;
                    equipe1.NbButContre= nbButContre;
                    equipe1.NbButDiff= nbButDiff;
                }
                if (nomEquipe == nomEquipe2)
                {

                    equipe2.EquipeNom = nomEquipe;
                    equipe2.NbVictoire = nbVictoire;
                    equipe2.NbDefaite = nbDefaite;
                    equipe2.NbNulle = nbNulle;
                    equipe2.NbPoint = nbPoint;
                    equipe2.NbButPour = nbButPour;
                    equipe2.NbButContre = nbButContre;
                    equipe2.NbButDiff = nbButDiff;
                }
            }

            //Crée 2 objets gardiens à partir de la base de donnée
            ado = new Adonet();
            query = "Select * from Gardiens";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                string nomEquipe = row["nomEquipe"].ToString();
                string joueurID = row["joueurID"].ToString();
                string nom = row["nom"].ToString();
                string prenom = row["prenom"].ToString();
                string numChandail = row["numChandail"].ToString();
                int nbButContre = Convert.ToInt32(row["nbButContre"]);
                int nbMatch = Convert.ToInt32(row["nbMatch"]);
                float moyenneButContre = float.Parse(row["moyenneButContre"].ToString());


                if (nomEquipe == nomEquipe1)
                {

                    gar1.EquipeNom = nomEquipe;
                    gar1.JoueurID= joueurID;
                    gar1.Nom = nom;
                    gar1.Prenom = prenom;
                    gar1.NumChandail= numChandail;
                    gar1.NbButsAllouees = nbButContre;
                    gar1.NbMatch= nbMatch;
                    gar1.MoyenneButsAllouees= moyenneButContre;
                }
                if (nomEquipe == nomEquipe2)
                {

                    gar2.EquipeNom = nomEquipe;
                    gar2.JoueurID = joueurID;
                    gar2.Nom = nom;
                    gar2.Prenom = prenom;
                    gar2.NumChandail = numChandail;
                    gar2.NbButsAllouees = nbButContre;
                    gar2.NbMatch = nbMatch;
                    gar2.MoyenneButsAllouees = moyenneButContre;
                }
            }

        }

        private void comboBoxNum1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numJoueur = comboBoxNum1.SelectedItem.ToString();

            ado = new Adonet();
            string query = $"Select * from Attaquants";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                string nomEquipe = row["nomEquipe"].ToString();
                string numChandail = row["numChandail"].ToString();

                if (nomEquipe == nomEquipe1 && numChandail == numJoueur)
                {
                    labelNom1.Text = row["nom"].ToString() ;
                    labelPrenom1.Text = row["prenom"].ToString();
                }
                
            }

        }

        private void comboBoxNum2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numJoueur = comboBoxNum2.SelectedItem.ToString();

            ado = new Adonet();
            string query = $"Select * from Attaquants";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                string nomEquipe = row["nomEquipe"].ToString();
                string numChandail = row["numChandail"].ToString();

                if (nomEquipe == nomEquipe2 && numChandail == numJoueur)
                {
                    labelNom2.Text = row["nom"].ToString();
                    labelPrenom2.Text = row["prenom"].ToString();
                }

            }
        }

        private void buttonLocal_Click(object sender, EventArgs e)
        {
            if (comboBoxNum1.Text == "") 
            {
                MessageBox.Show("Veuillez sélectionner un joueur");
                return;
            }
            int nbButsLocal = Int32.Parse(labelScore1.Text);
            nbButsLocal += 1;
            labelScore1.Text = nbButsLocal.ToString();

            foreach (Attaquant a1 in ls_att1) 
            {
                if (a1.NumChandail == comboBoxNum1.Text) 
                {
                    a1.AjouterBut();
                    gar2.AjouterBut();
                }
            }
        }

        private void buttonVisiteur_Click(object sender, EventArgs e)
        {
            if (comboBoxNum2.Text == "")
            {
                MessageBox.Show("Veuillez sélectionner un joueur");
                return;
            }
            int nbButsVisiteur = Int32.Parse(labelScore2.Text);
            nbButsVisiteur += 1;
            labelScore2.Text = nbButsVisiteur.ToString();
            foreach (Attaquant a2 in ls_att2)
            {
                
                if (a2.NumChandail == comboBoxNum2.Text)
                {
                    a2.AjouterBut();
                    gar1.AjouterBut();
                }
            }
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            int nbButLocal = Int32.Parse(labelScore1.Text);
            int nbButVisiteur = Int32.Parse(labelScore2.Text);

            GestionMatch.FinMatch(equipe1, nbButLocal, equipe2, nbButVisiteur);

            string query;

            //ado pour la table Attaquant
            Adonet ado = new Adonet();
            query = "Select * from Attaquants";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows) 
            {
                if (row["nomEquipe"].ToString() == equipe1.EquipeNom || row["nomEquipe"].ToString() == equipe2.EquipeNom)
                {
                    row.Delete();
                }
            }

            try
            {

                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //ado pour la table Gardiens
            ado = new Adonet();
            query = "Select * from Gardiens";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                if (row["nomEquipe"].ToString() == equipe1.EquipeNom || row["nomEquipe"].ToString() == equipe2.EquipeNom)
                {
                    row.Delete();
                }
            }

            try
            {

                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //ado pour la table équipe
            ado = new Adonet();
            query = "Select * from Equipes";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                if (row["nomEquipe"].ToString() == equipe1.EquipeNom || row["nomEquipe"].ToString() == equipe2.EquipeNom)
                {
                    row.Delete();
                }
            }

            try
            {

                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ///////////////

            DataRow UneEquipe = ado.DtEquipe.NewRow();
            UneEquipe[0] = equipe1.EquipeNom;
            UneEquipe[1] = equipe1.NbVictoire;
            UneEquipe[2] = equipe1.NbDefaite;
            UneEquipe[3] = equipe1.NbNulle;
            UneEquipe[4] = equipe1.NbPoint;
            UneEquipe[5] = equipe1.NbButPour;
            UneEquipe[6] = equipe1.NbButContre;
            UneEquipe[7] = equipe1.NbButDiff;
            ado.DtEquipe.Rows.Add(UneEquipe);

            DataRow UneEquipe2 = ado.DtEquipe.NewRow();
            UneEquipe2[0] = equipe2.EquipeNom;
            UneEquipe2[1] = equipe2.NbVictoire;
            UneEquipe2[2] = equipe2.NbDefaite;
            UneEquipe2[3] = equipe2.NbNulle;
            UneEquipe2[4] = equipe2.NbPoint;
            UneEquipe2[5] = equipe2.NbButPour;
            UneEquipe2[6] = equipe2.NbButContre;
            UneEquipe2[7] = equipe2.NbButDiff;
            ado.DtEquipe.Rows.Add(UneEquipe2);

            try
            {

                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //ado pour la table Gardiens
            ado = new Adonet();
            query = "Select * from Gardiens";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            gar1.AjouterMatch();
            gar1.CalculerStats();
            gar2.AjouterMatch();
            gar2.CalculerStats();

            DataRow UnGardien = ado.DtEquipe.NewRow();
            UnGardien[0] = gar1.JoueurID;
            UnGardien[1] = gar1.EquipeNom;
            UnGardien[2] = gar1.Nom;
            UnGardien[3] = gar1.Prenom;
            UnGardien[4] = gar1.NumChandail;
            UnGardien[5] = gar1.NbButsAllouees;
            UnGardien[6] = gar1.NbMatch;
            UnGardien[7] = gar1.MoyenneButsAllouees;
            ado.DtEquipe.Rows.Add(UnGardien);

            DataRow UnGardien2 = ado.DtEquipe.NewRow();
            UnGardien2[0] = gar2.JoueurID;
            UnGardien2[1] = gar2.EquipeNom;
            UnGardien2[2] = gar2.Nom;
            UnGardien2[3] = gar2.Prenom;
            UnGardien2[4] = gar2.NumChandail;
            UnGardien2[5] = gar2.NbButsAllouees;
            UnGardien2[6] = gar2.NbMatch;
            UnGardien2[7] = gar2.MoyenneButsAllouees;
            ado.DtEquipe.Rows.Add(UnGardien2);

            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //ado pour la table Attaquants
            ado = new Adonet();
            query = "Select * from Attaquants";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (Attaquant a1 in ls_att1) 
            {
                a1.AjouterMatch();
                a1.CalculerStats();

                DataRow UnAttaquant = ado.DtEquipe.NewRow();
                UnAttaquant[0] = a1.JoueurID;
                UnAttaquant[1] = a1.EquipeNom;
                UnAttaquant[2] = a1.Nom;
                UnAttaquant[3] = a1.Prenom;
                UnAttaquant[4] = a1.NumChandail;
                UnAttaquant[5] = a1.NbBut;
                UnAttaquant[6] = a1.NbMatch;
                UnAttaquant[7] = a1.MoyenneBut;
                ado.DtEquipe.Rows.Add(UnAttaquant);
            }

            foreach (Attaquant a2 in ls_att2)
            {
                a2.AjouterMatch();
                a2.CalculerStats();

                DataRow UnAttaquant2 = ado.DtEquipe.NewRow();
                UnAttaquant2[0] = a2.JoueurID;
                UnAttaquant2[1] = a2.EquipeNom;
                UnAttaquant2[2] = a2.Nom;
                UnAttaquant2[3] = a2.Prenom;
                UnAttaquant2[4] = a2.NumChandail;
                UnAttaquant2[5] = a2.NbBut;
                UnAttaquant2[6] = a2.NbMatch;
                UnAttaquant2[7] = a2.MoyenneBut;
                ado.DtEquipe.Rows.Add(UnAttaquant2);
            }

            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("Match terminé");
            this.Close();
           
            
        }
    }
}
