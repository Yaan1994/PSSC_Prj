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

        public void UpdateMedie_generala(float medie_generala)
        {
            this.medie_generala = medie_generala;
        }

        public float GetMedie_generala()
        {
            return this.medie_generala;
        }

        public void UpdateBursa(bursier bursa)
        {
            this.bursa = bursa;
        }

        public bursier GetBursa()
        {
            return this.bursa;
        }

        public stareCamin Getstarecamin()
        {
            return this.stare;
        }

        public void Updatestare(stareCamin stare)
        {
            this.stare = stare;
        }

        public float CalculMedieGenerala()
        {
            float medie = 0;

            if (disciplina != null)
            {
                foreach (var dis_ in disciplina)
                {
                    medie += (dis_.GetNota_examen() * 2 + dis_.GetNota_activitate()) / 3;
                }
                medie = medie / disciplina.Count;
            }

            return medie;
        }

        public bool FindDisciplina(Disciplina disc)
        {
            foreach (var d in disciplina)
            {
                if (d.Equals(disc))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddDisciplina(Disciplina disc)
        {
            if (FindDisciplina(disc))
            {
                return false;
            }
            else
            {
                disciplina.Add(disc);
                return true;
            }
        }

        public bool RemoveDisciplina(Disciplina disc)
        {
            if (FindDisciplina(disc))
            {
                disciplina.Remove(disc);
                return true;
            }
            else
                return false;
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
