using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class Profesor
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public List<Disciplina> disciplina { get; internal set; }
        public List<Student> student { get; internal set; }

        public Profesor(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public void AdaugaMaterieProfesorului(string nume, int ID_disciplina)
        {
            disciplina.Add(new Disciplina(nume, ID_disciplina));
        }

        public void AdaugaStudentProfesorului(Student stud)
        {
            foreach (var dis in disciplina)
            {
                if (stud.ConstatareMaterie(dis.ID_materie))
                {
                    student.Add(stud);
                }
            }
        }
    }
}
