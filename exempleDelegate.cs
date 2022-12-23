using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appWin_liguev2
{
    internal class exempleDelegate
    {
        public delegate void Delegate1(string text);

        public Delegate1 exemple;


        public void Salutation(string nom)
        {
            Console.WriteLine("Bonjour" + nom);
        }

        public void Aurevoir(string nom) 
        {
            Console.WriteLine("Au revoir" + nom);
        }

        

        public void Main()
        {
            exemple = Salutation;
            exemple += Aurevoir;

            exemple("Simon");

            
            Delegate1 message = (string text) => { Console.WriteLine(text); };

            message("Ceci est un message");

        }
    }
}
