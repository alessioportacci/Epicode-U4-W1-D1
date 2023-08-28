using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epicode_U4_W1_D1
{
    internal class Autovetture
    {
        private string _marca;

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        } 

        public int Velocita { get; set; }

        public void Accellera()
        {
            Velocita++;
        }
        public void Rallenta()
        {
            Velocita--;
        }
        public void Frena()
        {
            Velocita = 0;
        }

    }

    public class Autovetture2
    {
        public string Marca { get; set; }
    }

}
