using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D1
{
    class Atleta
    {
        private int _velocita;
        public int Velocita { get { return _velocita; } set { _velocita = value; } }
        
        public void Accellera()
        {
            _velocita++;
        }
        public void Rallenta()
        {
            _velocita--;
        }
        public void Frena()
        {
            _velocita = 0;
        }
        public void Sprint()
        {
            _velocita+= 10;
        }

    }
}
