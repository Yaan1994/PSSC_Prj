using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    public class Profesor
    {
        public int ID { get; internal set; }
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public List<DisciplinaProfesor> disciplina { get; internal set; }

        public Profesor(int ID, string nume, string prenume)
        {
            this.ID = ID;
            this.nume = nume;
            this.prenume = prenume;
        }

        public bool FindDisciplina(DisciplinaProfesor disc)
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

        public bool AddDisciplina(DisciplinaProfesor disc)
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

        public bool RemoveDisciplina(DisciplinaProfesor disc)
        {
            if (FindDisciplina(disc))
            {
                disciplina.Remove(disc);
                return true;
            }
            else
                return false;
        }

        public int GetIDProfesor()
        {
            return this.ID;
        }

        public override bool Equals(object obj)
        {
            var profesor = (Profesor)obj;
            if (profesor != null)
            {
                if (profesor.GetIDProfesor() == this.GetIDProfesor())
                {
                    return true;
                }
            }
            return false;
        }
    }

   /* class Profesor
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public List<Disciplina> disciplina { get; internal set; }
        public List<StudentFacultate> student { get; internal set; }

        public Profesor(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public void AdaugaMaterieProfesorului(string nume, int ID_disciplina)
        {
            disciplina.Add(new Disciplina(nume, ID_disciplina));
        }

        public void AdaugaStudentProfesorului(StudentFacultate stud)
        {
            foreach (var dis in disciplina)
            {
                if (stud.ConstatareMaterie(dis.ID_materie))
                {
                    student.Add(stud);
                }
            }
        }
    }*/
}
