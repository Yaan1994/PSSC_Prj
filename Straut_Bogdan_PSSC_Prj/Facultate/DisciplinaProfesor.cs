using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class DisciplinaProfesor:Disciplina
    {
        public List<StudentProfesor> student { get; internal set;}

        public DisciplinaProfesor(string nume, int ID_materie)
            : base(nume, ID_materie)
        {

        }

        public bool FindStudent(StudentProfesor stud)
        {
            foreach (var s in student)
            {
                if (s.Equals(stud))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddStudent(StudentProfesor stud)
        {
            if (FindStudent(stud))
            {
                return false;
            }
            else
            {
                student.Add(stud);
                return true;
            }
        }

        public bool RemoveStudent(StudentProfesor stud)
        {
            if (FindStudent(stud))
            {
                student.Remove(stud);
                return true;
            }
            else
                return false;
        }
    }
}
