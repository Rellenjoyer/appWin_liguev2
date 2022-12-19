using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appWin_liguev2
{
    //classe pour facilité la gestion de la base de données
    internal class Adonet
    {
        //attributs
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private string connectionString;
        private DataSet dsLigue;
        private DataTable dtEquipe;



        public SqlConnection Connection { get => connection; set => connection = value; }
        public SqlCommand Command { get => command; set => command = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public string ConnactionString { get => connectionString; set => connectionString = value; }
        public DataSet DsLigue { get => dsLigue; set => dsLigue = value; }
        public DataTable DtEquipe { get => dtEquipe; set => dtEquipe = value; }



        public Adonet()
        {
            //connection string varie selon le serveur
            connectionString = "Data Source=LENEVO-LEGION-Y; Initial Catalog=Ligue; User ID=simon;Password=sql";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            adapter = new SqlDataAdapter();
            dsLigue = new DataSet();
            dtEquipe = new DataTable();

        }
    }
}
