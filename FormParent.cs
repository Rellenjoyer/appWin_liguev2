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
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouter formAdd = new FormAjouter();
            formAdd.MdiParent = this;
            formAdd.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistiques formstats = new FormStatistiques();
            formstats.MdiParent = this;
            formstats.Show();
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjoutMatch formMatch = new FormAjoutMatch();
            formMatch.MdiParent = this;
            formMatch.Show();
        }
    }
}
