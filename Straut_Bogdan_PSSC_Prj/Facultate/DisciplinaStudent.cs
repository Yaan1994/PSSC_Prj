using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class DisciplinaStudent:Disciplina
    {
        public float nota_activitate;
        public float nota_examen;
        public float nota_finala;

        public DisciplinaStudent(string nume, int ID_materie) : base(nume, ID_materie)
        {
        }

        public void UpdateNotaActivitate(float nota)
        {
            this.nota_activitate = nota;
        }

        public void UpdateNotaExamen(float nota)
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

        public void CalculNotaFinala()
        {
            this.nota_finala = (nota_examen * 2 + nota_activitate) / 3;
        }

        public float GetNotaFinala()
        {
            if (this.nota_finala == null)
                return 0;
            else
                return this.nota_finala;
        }
    }
}
