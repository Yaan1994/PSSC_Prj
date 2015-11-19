using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat_
{
    enum bursier { Nu = 0, Da };

    class Student
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public int nr_matricol { get; internal set; }
        public bursier bursa { get; internal set; }
        public float medie_generala { get; internal set; }
        public List<Disciplina> disciplina { get; internal set; }

        internal Student(string nume, string prenume, int nr_matricol)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_matricol = nr_matricol;
        }

        public void InserareMaterie(string nume_materie, Profesor profesor)
        {
            disciplina.Add(new Disciplina(nume_materie, profesor));
        }

        internal float CalculMedieGenerala()
        {
            float media_generala = 0;

            if (disciplina != null)
            {
                foreach (var dis_ in disciplina)
                {
                    media_generala = dis_.nota_finala;
                }
            }
            return (media_generala / disciplina.Count);
        }

        internal override bool Equals(object obj)
        {
            var student = (Student)obj;
            if (student != null)
            {
                if (student.nr_matricol == this.nr_matricol)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
