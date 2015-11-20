using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat
{
    class Profesor
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }

        internal Profesor(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }
    }
}
