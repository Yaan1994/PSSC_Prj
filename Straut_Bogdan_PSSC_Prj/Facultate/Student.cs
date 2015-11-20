using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class Student
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public int nr_matricol { get; internal set; }
        public List<DisciplinaStudent> disciplina { get; internal set; }

        public Student(string nume, string prenume, int nr_matricol)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_matricol = nr_matricol;
        }

        public Student(int nr_matricol)
        {
            this.nr_matricol = nr_matricol;
        }

        public void InserareMaterie(string nume_materie, int ID_materie)
        {
            disciplina.Add(new DisciplinaStudent(nume_materie, ID_materie));
        }

        public void CalculeazaNotaFinalaPtOMaterie(int ID_materie)
        {
            foreach (var disc in disciplina)
            {
                if (disc.GetID_materie() == ID_materie)
                {
                    disc.CalculNotaFinala();
                }
            }
        }

        public bool ConstatareMaterie(int ID_materie)
        {
            foreach (var dis in disciplina)
            {
                if (dis.ID_materie == ID_materie)
                    return true;
            }

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
