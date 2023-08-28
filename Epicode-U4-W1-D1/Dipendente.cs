using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D1
{
    public class Dipendente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        private decimal _stipendio;

        public decimal Stipendio
        {
            get { return _stipendio; }
            set { _stipendio = value; }
        }

        public decimal Bonus { get; set; }

        //Proprieta che calcola in automatico lo stipendio con il bonus
        public decimal StipendioPiuBonus
        {
            get
            {
                return _stipendio * Bonus;
            }
        }

        public string getFullName()
        {
            return Nome + " " + Cognome;
        }

    }

}
