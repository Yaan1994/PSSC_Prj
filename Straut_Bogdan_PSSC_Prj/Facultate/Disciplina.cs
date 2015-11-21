using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class Disciplina
    {
        public string nume { get; internal set; }
        public int ID_materie { get; internal set; }

        public Disciplina(string nume, int ID_materie)
        {
            this.nume = nume;
            this.ID_materie = ID_materie;
        }

        public int GetID_materie()
        {
            return this.ID_materie;
        }

        public void UpdateNumeDisciplina(string nume)
        {
            this.nume = nume;
        }

        public override bool Equals(object obj)
        {
            var disciplina = (Disciplina)obj;
            if (disciplina != null)
            {
                if (disciplina.GetID_materie() == this.GetID_materie())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
