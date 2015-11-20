using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class Disciplina
    {
        public string nume;
        public int ID_materie;

        public Disciplina(string nume, int ID_materie)
        {
            this.nume = nume;
            this.ID_materie = ID_materie;
        }

        public void UpdateNumeDisciplina(string nume)
        {
            this.nume = nume;
        }
    }
}
