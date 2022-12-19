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
    public partial class FormAjoutMatch : Form
    {
        Adonet ado;

        public FormAjoutMatch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Remplie les comboBox avec les nom des équipes au chargement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAjoutMatch_Load(object sender, EventArgs e)
        {
            ado = new Adonet();
            string query = "Select nomEquipe from Equipes";
            ado.Command.CommandText = query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsLigue);
            ado.DtEquipe = ado.DsLigue.Tables[0];

            foreach (DataRow row in ado.DtEquipe.Rows)
            {
                string nomEquipe = row[0].ToString();
                comboBoxEquipe1.Items.Add(nomEquipe);
                comboBoxEquipe2.Items.Add(nomEquipe);

            }
        }

        /// <summary>
        /// Confirme la création de match et ouvre un nouveau form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            string equipe1 = comboBoxEquipe1.Text;
            string equipe2 = comboBoxEquipe2.Text;

            if ( equipe1!="" && equipe2!="" && equipe1 != equipe2 ) 
            {
                // transfert le nom des équipes au prochain form
                FormScoreMatch formScore = new FormScoreMatch();
                formScore.MdiParent = this.MdiParent;
                formScore.nomEquipe1 = comboBoxEquipe1.Text;
                formScore.nomEquipe2 = comboBoxEquipe2.Text;
                formScore.Show();


                this.Close();
            }
            //si les équipes ne sont pas valides
            else 
            {
                MessageBox.Show("Veuillez choisir 2 équipes différentres");
            }
        }


    }
}
