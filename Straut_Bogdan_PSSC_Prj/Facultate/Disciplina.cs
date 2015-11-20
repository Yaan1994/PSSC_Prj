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
        public float nota_activitate;
        public float nota_examen;
        public float nota_finala;

        public Disciplina(string nume, int ID_materie)
        {
            this.nume = nume;
            this.ID_materie = ID_materie;
        }

        internal void UpdateNotaActivitate(float nota)
        {
            this.nota_activitate = nota;
        }

        internal void UpdateNotaExamen(float nota)
        {
            if (this.nota_examen != null)
            {
                if (this.nota_examen < nota)
                {
                    this.nota_examen = nota;
                }
            }
            else
            {
                this.nota_examen = nota;
            }
        }
    }
}
