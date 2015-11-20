using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat
{
    enum bursier { Nu = 0, Da };
    enum stareCamin { Neinteresat = 0, Interesat, Cazat, Fara_loc };

    class Student
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public int nr_matricol { get; internal set; }
        public bursier bursa { get; internal set; }
        public float medie_generala { get; internal set; }
        public List<Disciplina> disciplina { get; internal set; }
        public stareCamin stare { get; internal set; }

        public Student(string nume, string prenume, int nr_matricol, stareCamin stare)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_matricol = nr_matricol;
            this.stare = stare;
        }

        public void InserareMaterie(string nume_materie, int ID_materie)
        {
            disciplina.Add(new Disciplina(nume_materie, ID_materie));
        }

        public void CalculMedieGenerala()
        {
            float media_generala = 0;

            if (disciplina != null)
            {
                foreach (var dis_ in disciplina)
                {
                    media_generala += (dis_.nota_examen * 2 + dis_.nota_activitate) / 3;
                }
                this.medie_generala = media_generala / disciplina.Count;
            }
        }

        public override bool Equals(object obj)
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
