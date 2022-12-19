using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appWin_liguev2
{
    public partial class FormAjouter : Form
    {
        Adonet ado;

        public FormAjouter()
        {
            InitializeComponent();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormAjouter_Load(object sender, EventArgs e)
        {
            ado = new Adonet();
            string query = "Select * from Equipes;";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];
        }

        private void buttonAjouterJoueur_Click(object sender, EventArgs e)
        {
            //variable pour le regex
            string patternNum = @"^[0-9]{2,2}$";
            string patternNom = @"^[A-Z][a-z]{1,20}$";

            //variable pour les input
            string inputNum = textBoxNum.Text;
            string inputNom = textBoxNom.Text;
            string inputPrenom = textBoxPrenom.Text;
            string inputPosition = comboBoxPosition.Text;
            

            //vérifie que tous les inputs sont corrects
            Match matchNum = Regex.Match(inputNum, patternNum);
            if (!(matchNum.Success)) { MessageBox.Show("Veuillez entrer un numéro à 2 chiffres"); }

            Match matchNom = Regex.Match(inputNom, patternNom);
            if (!(matchNom.Success)) { MessageBox.Show("Veuillez entrer un nom avec une majuscule et moins de 21 lettres"); }

            Match matchPrenom = Regex.Match(inputPrenom, patternNom);
            if (!(matchPrenom.Success)) { MessageBox.Show("Veuillez entrer un prénom avec une majuscule et moins de 21 lettres"); }

            if (inputPosition != "Attaquant" && inputPosition != "Gardien") { MessageBox.Show("Veuillez entrer une position valide"); }


            //Si tous les inputs sont corrects
            else if (matchNum.Success && matchNom.Success && matchPrenom.Success)
            {
                //i est le compteur d'attaquant
                int i = 0;
                //i est le compteur de gardien
                int j = 0;
                //i est le compteur de joueur
                int k = 0;
                //vérifie que le numéro d'étudiant n'existe pas
                foreach (ListViewItem item in listViewJoueur.Items)
                {

                    if (item.SubItems[1].Text == "Attaquant" && inputPosition == "Attaquant") 
                    { 
                        i++;
                        if (i == 5)
                        {
                            MessageBox.Show("Il doit y avoir seulement 5 attaquants");
                            return;
                        }
                    }

                    if (item.SubItems[1].Text == "Gardien" && inputPosition == "Gardien") 
                    { 
                        j++;
                        if (j == 1) 
                        {
                            MessageBox.Show("Il doit y avoir seulement 1 gardien");
                            return;
                        }
                    }

                    if (item.SubItems[0].Text == inputNum) 
                    {
                        MessageBox.Show("Ce numéro de joueur dest déjà utilisé");
                        return;
                    }
                }

                ListViewItem lv1 = new ListViewItem(inputNum);
                lv1.SubItems.Add(inputPosition);
                lv1.SubItems.Add(inputPrenom);
                lv1.SubItems.Add(inputNom);
                
                listViewJoueur.Items.Add(lv1);
                MessageBox.Show("Le joueur a bien été ajouté");

                foreach (ListViewItem item in listViewJoueur.Items) 
                {
                    k++;
                    if (k == 6) { MessageBox.Show("Il y a 5 attaquants et 1 gardien, donc l'équipe est complète"); }
                }
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            //variable pour le regex
            string patternNum = @"^[0-9]{2,2}$";

            //variable pour les input
            string inputNum = textBoxNum.Text;

            //vérifie que tous les inputs sont corrects
            Match matchNum = Regex.Match(inputNum, patternNum);
            if (!(matchNum.Success)) { MessageBox.Show("Veuillez entrer un numéro à 2 chiffres"); }

            else 
            {
                foreach (ListViewItem item in listViewJoueur.Items)
                {

                    if (item.SubItems[0].Text == inputNum)
                    {
                        listViewJoueur.Items.Remove(item);
                        MessageBox.Show("Le joueur a bien été retiré");
                        return;
                    }
                }
                MessageBox.Show("Aucun joueur n'a ce numéro");
            }

        }

        private void buttonComplet_Click(object sender, EventArgs e)
        {
            //variable pour le regex
            string patternNom = @"^[A-Z][a-z]{1,20}$";

            //variable pour les input
            string inputNomEquipe = textBoxNomEquipe.Text;


            Match matchNom = Regex.Match(inputNomEquipe, patternNom);
            if (!(matchNom.Success)) { MessageBox.Show("Veuillez entrer un nom avec une majuscule et moins de 21 lettres"); }

            else
            {
                //i est le compteur d'attaquant
                int i = 0;
                //i est le compteur de gardien
                int j = 0;
                //i est le compteur de joueur
                int k = 0;
                foreach (ListViewItem item in listViewJoueur.Items)
                {

                    if (item.SubItems[1].Text == "Attaquant")
                    {
                        i++;
                    }

                    if (item.SubItems[1].Text == "Gardien")
                    {
                        j++;
                    }
                }

                if (i != 5)
                {
                    MessageBox.Show("Il doit y avoir 5 attaquants pour compléter la création de l'équipe");
                    return;
                }

                if (j != 1)
                {
                    MessageBox.Show("Il doit y avoir 1 gardien pour compléter la création de l'équipe");
                    return;
                }

                //vérifie que le nom de l'équipe n'existe pas encore
                ado = new Adonet();
                string query = $"Select * from Equipes;";
                ado.Command.CommandText = query;
                ado.Command.Connection = ado.Connection;
                ado.Adapter.SelectCommand = ado.Command;
                ado.Adapter.Fill(ado.DsLigue);
                ado.DtEquipe = ado.DsLigue.Tables[0];
                
                foreach(DataRow row in ado.DtEquipe.Rows) 
                {
                    string nomEquipe = row[0].ToString();
                    if (nomEquipe == inputNomEquipe) 
                    {
                        MessageBox.Show("Ce nom d'équipe existe déjà");
                        return;
                    }
                }

                if (j == 1 && i == 5)
                {
                    MessageBox.Show("L'équipe à bien été créé");
                    

                    //ado pour la table équipe
                    Adonet ado = new Adonet();
                    string queryEquipe = "Select * from Equipes;";
                    ado.Command.CommandText = queryEquipe;
                    ado.Command.Connection = ado.Connection;
                    ado.Adapter.SelectCommand = ado.Command;
                    ado.Adapter.Fill(ado.DsLigue);
                    ado.DtEquipe = ado.DsLigue.Tables[0];
                    
                    //ajout de l'équipe à la table
                    Equipe e1 = new Equipe(inputNomEquipe);
                    DataRow UneEquipe = ado.DtEquipe.NewRow();
                    UneEquipe[0] = e1.EquipeNom;
                    UneEquipe[1] = e1.NbVictoire;
                    UneEquipe[2] = e1.NbDefaite;
                    UneEquipe[3] = e1.NbNulle;
                    UneEquipe[4] = e1.NbPoint;
                    UneEquipe[5] = e1.NbButPour;
                    UneEquipe[6] = e1.NbButContre;
                    UneEquipe[7] = e1.NbButDiff;
                    ado.DtEquipe.Rows.Add(UneEquipe);

                    //sauvegarde équipe
                    try
                    {

                        SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                        ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    //ado pour les attaquants
                    ado = new Adonet();
                    string queryAtt = "Select * from Attaquants;";
                    ado.Command.CommandText = queryAtt;
                    ado.Command.Connection = ado.Connection;
                    ado.Adapter.SelectCommand = ado.Command;
                    ado.Adapter.Fill(ado.DsLigue);
                    ado.DtEquipe = ado.DsLigue.Tables[0];

                    DataRow UnAttaquant = ado.DtEquipe.NewRow();

                    //ajout des attaquants à la table
                    foreach (ListViewItem item in listViewJoueur.Items)
                    {
                        if (item.SubItems[1].Text == "Attaquant")
                        {
                            string joueurID = inputNomEquipe.Substring(0, 3) + item.SubItems[0].Text;
                            Attaquant a1 = new Attaquant(joueurID, inputNomEquipe, item.SubItems[3].Text, item.SubItems[2].Text, item.SubItems[0].Text);

                            UnAttaquant = ado.DtEquipe.NewRow();
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
                    }

                    //sauvegarde attaquants
                    try
                    {

                        SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                        ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    //ado pour le gardien
                    ado = new Adonet();
                    string queryGar = "Select * from Gardiens;";
                    ado.Command.CommandText = queryGar;
                    ado.Command.Connection = ado.Connection;
                    ado.Adapter.SelectCommand = ado.Command;
                    ado.Adapter.Fill(ado.DsLigue);
                    ado.DtEquipe = ado.DsLigue.Tables[0];

                    DataRow UnGardien = ado.DtEquipe.NewRow();

                    //ajout du gardien à la table
                    foreach (ListViewItem item in listViewJoueur.Items)
                    {
                        if (item.SubItems[1].Text == "Gardien")
                        {
                            string joueurID = inputNomEquipe.Substring(0, 3) + item.SubItems[0].Text;
                            Gardien g1 = new Gardien(joueurID, inputNomEquipe, item.SubItems[3].Text, item.SubItems[2].Text, item.SubItems[0].Text);

                            UnGardien = ado.DtEquipe.NewRow();
                            UnGardien[0] = g1.JoueurID;
                            UnGardien[1] = g1.EquipeNom;
                            UnGardien[2] = g1.Nom;
                            UnGardien[3] = g1.Prenom;
                            UnGardien[4] = g1.NumChandail;
                            UnGardien[5] = g1.NbButsAllouees;
                            UnGardien[6] = g1.NbMatch;
                            UnGardien[7] = g1.MoyenneButsAllouees;
                            ado.DtEquipe.Rows.Add(UnGardien);
                        }
                    }

                    //sauvegarde gardiens
                    try
                    {

                        SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);

                        ado.Adapter.Update(ado.DsLigue, ado.DtEquipe.ToString());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    listViewJoueur.Items.Clear();
                }
            }
        }

        
    }
}
