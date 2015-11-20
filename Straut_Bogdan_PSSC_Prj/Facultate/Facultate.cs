using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class Facultate
    {
        public string nume { get; internal set; }
        public List<Profesor> profesor { get; internal set; }
        public List<Student> student { get; internal set; }

        public Facultate(string nume)
        {
            this.nume = nume;
        }

        public void AdaugaStudent(Student stud)
        {
            student.Add(stud);
        }

        public void AdaugaProfesor(Profesor prof)
        {
            profesor.Add(prof);
        }

        public void CalculeazaNoteleFinaleAleStudentilor()
        {

        }
    }
}
