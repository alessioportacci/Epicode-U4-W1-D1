using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D1
{
    class Prodotto
    {
        private string _nome;
        private int _prezzo;
        private int _quantita;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public int Prezzo { get { return _prezzo; } set { _prezzo = value; } }
        public int Quantita { get { return _quantita; } set { _quantita = value; } }

        public int getTotale()
        {
            return Prezzo * Quantita;
        }
    }
}
