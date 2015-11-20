using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat
{
    class Disciplina
    {
        public string nume { get; internal set; }
        public Profesor profesor { get; internal set; }
        public float nota_activitate { get; internal set; }
        public float nota_examen { get; internal set; }
        public float nota_finala { get; set { nota_finala = (nota_activitate * 2 + nota_examen) / 3; } }

        internal Disciplina(string nume, Profesor profesor)
        {
            this.nume = nume;
            this.profesor = profesor;
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
