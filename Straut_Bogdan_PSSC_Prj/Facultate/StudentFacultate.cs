using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class StudentFacultate:Student
    {
        public string nume {get; internal set;}
        public string prenume { get; internal set; }
        public List<DisciplinaStudent> disciplina { get; internal set; }

        public StudentFacultate(string nume, string prenume, int nr_matricol)
            : base(nr_matricol)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public bool FindDisciplina(DisciplinaStudent disc)
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

        public bool AddDisciplina(DisciplinaStudent disc)
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

        public bool RemoveDisciplina(DisciplinaStudent disc)
        {
            if (FindDisciplina(disc))
            {
                disciplina.Remove(disc);
                return true;
            }
            else
                return false;
        }
    }
}
