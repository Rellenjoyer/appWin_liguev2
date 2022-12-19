using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appWin_liguev2
{
    public partial class FormStatistiques : Form
    {
        Adonet ado;
        public FormStatistiques()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplie le dataGridView avec les équipes lors de l'ouverture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormStatistiques_Load(object sender, EventArgs e)
        {
            //ado pour les équipes
            ado = new Adonet();
            string query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];
            this.dataGridView1.DataSource = ado.DtEquipe;

            // initialise le nombre de but max à 999 pour que toutes les équipes soient inclus de bases
            numericUpDownMax.Maximum = 999;
            numericUpDownMax.Minimum = 0;
            numericUpDownMax.Value = 999;
        }

        /// <summary>
        /// Bouton qui permet de faire une recheche avec les filtres actuelles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            //input de recherche
            string inputRecherche = comboBoxFiltre.Text;
            decimal min = numericUpDownMin.Value;
            decimal max = numericUpDownMax.Value;


            //query de base si rien n'est sélectionné dans le comboBox (retourne les équipes)
            string query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes " +
                    $"where nbButPour Between {min} and {max}";

            if (inputRecherche == "Équipes")
            {
                query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes " +
                    $"where nbButPour Between {min} and {max}";
            }

            if (inputRecherche == "Attaquants")
            {
                query = "Select nom as 'Nom', prenom as 'Prénom', numChandail as 'Numéro', nomEquipe as 'Équipe', nbBut as 'Nombre de Buts', " +
                    "nbMatch as 'Nombre de match', moyenneBut as 'Buts par match' from Attaquants " +
                    $"where nbBut Between {min} and {max}";
            }

            if (inputRecherche == "Gardiens")
            {
                query = "Select nom as 'Nom', prenom as 'Prénom', numChandail as 'Numéro', nomEquipe as 'Équipe', nbButContre as 'Buts allouées', " +
                    "nbMatch as 'Nombre de match', moyenneButContre as 'Buts allouées par match' from Gardiens " +
                    $"where nbButContre Between {min} and {max}";

            }

            //ado qui s'adapte selon le query
            ado = new Adonet();
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];
            this.dataGridView1.DataSource = ado.DtEquipe;
        }

        //Réinitialise la base de donnée pour une nouvelle saison
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Adonet ado;
            string query;

            //ado pour la table Attaquant
            ado = new Adonet();
            query = "Select * from Attaquants";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                row.Delete();
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
                row.Delete();
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
                row.Delete();

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

            MessageBox.Show("Nouvelle saison");

            //réinitialise l'affichage
            ado = new Adonet();
            query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];
            this.dataGridView1.DataSource = ado.DtEquipe;
        }
    }
}
