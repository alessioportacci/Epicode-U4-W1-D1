using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D1
{
    class Animale
    {
        public string Specie { get; set; }
        public string Colore { get; set; }
        public bool Vivo { get; set; }
        public bool HasEaten { get; set; }


        public void Muore()
        {
            Vivo = false;
        }
        public void Mangia()
        {
            HasEaten = true;
        }
        public void Affamato()
        {
            HasEaten = false;
        }


    }
}
