using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void FormStatistiques_Load(object sender, EventArgs e)
        {
            ado = new Adonet();
            string query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];
            this.dataGridView1.DataSource = ado.DtEquipe;
        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            string inputRecherche = comboBoxFiltre.Text;


            string query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes";

            if (inputRecherche == "Équipes") 
            {
                query = "Select nomEquipe as 'Équipe', nbVictoire as 'Nombre de victoires', nbDefaite as 'Nombre de défaites', nbNulle as 'Nombre de nulles'," +
                    "\"nbPoint as 'Points', nbButPour as 'Nombre de buts', nbButContre as 'Buts allouées', nbButDiff as 'Différentiel' from Equipes";
            }

            if (inputRecherche == "Attaquants")
            {
                query = "Select nom as 'Nom', prenom as 'Prénom', numChandail as 'Numéro', nomEquipe as 'Équipe', nbBut as 'Nombre de Buts', " +
                    "nbMatch as 'Nombre de match', moyenneBut as 'Buts par match' from Attaquants";
            }

            if (inputRecherche == "Gardiens")
            {
                query = "Select nom as 'Nom', prenom as 'Prénom', numChandail as 'Numéro', nomEquipe as 'Équipe', nbButContre as 'Buts allouées', " +
                    "nbMatch as 'Nombre de match', moyenneButContre as 'Buts allouées par match' from Gardiens";
            }

            ado = new Adonet();
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];
            this.dataGridView1.DataSource = ado.DtEquipe;
        }
    }
}
