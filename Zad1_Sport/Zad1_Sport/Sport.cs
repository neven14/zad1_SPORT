using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1_Sport
{
    public class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
            BrojIgraca = brojIgraca;
        }
    }
}
