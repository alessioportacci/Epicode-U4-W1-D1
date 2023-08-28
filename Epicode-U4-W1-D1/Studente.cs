using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D1
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string MateriaPreferita { get; set;}
        public int Media { get; set; }
        public int Eta { get; set;}

        public void Compleanno()
        {
            Eta++;
        }
        public string getFullNome()
        {
            return string.Concat(Nome, " ", Cognome);
        }
        public void AlzaMedia()
        { 
            Media++;
        }
        public void AbbassaMedia()
        {
            Media--;
        }

    }
}
