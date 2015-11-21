using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class StudentProfesor:Student
    {
        public float nota_activitate { get; internal set; }
        public float nota_examen { get; internal set; }

        public void UpdateNotaActivitate(float nota_activitate)
        {
            this.nota_activitate = nota_activitate;
        }

        public float GetNotaActivitate()
        {
            return this.nota_activitate;
        }

        public void UpdateNotaExamen(float nota_examen)
        {
            this.nota_examen = nota_examen;
        }

        public float GetNotaExamen()
        {
            return this.nota_examen;
        }
    }
}
