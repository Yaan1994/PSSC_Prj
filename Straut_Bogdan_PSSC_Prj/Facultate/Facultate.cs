using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secretariat;

namespace Facultate
{
    public class Facultate
    {
        public string nume { get; internal set; }
        public List<Profesor> profesor { get; internal set; }
        public List<StudentFacultate> student { get; internal set; }

        public Secretariat.Secretariat secretariat;

        public Facultate(string nume)
        {
            this.nume = nume;
        }

        public bool FindProfesor(Profesor prof)
        {
            foreach (var p in profesor)
            {
                if (p.Equals(prof))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddProfesor(Profesor prof)
        {
            if (FindProfesor(prof))
            {
                return false;
            }
            else
            {
                profesor.Add(prof);
                return true;
            }
        }

        public bool RemoveProfesor(Profesor prof)
        {
            if (FindProfesor(prof))
            {
                profesor.Remove(prof);
                return true;
            }
            else
                return false;
        }

        public bool FindStudentFacultate(StudentFacultate stud)
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

        public bool AddStudentFacultate(StudentFacultate stud)
        {
            if (FindStudentFacultate(stud))
            {
                return false;
            }
            else
            {
                student.Add(stud);
                return true;
            }
        }

        public bool RemoveStudentFacultate(StudentFacultate stud)
        {
            if (FindStudentFacultate(stud))
            {
                student.Remove(stud);
                return true;
            }
            else
                return false;
        }

        public void CalculeazaNotaFinala()
        {
            foreach(var p in profesor)
                foreach(var dp in p.disciplina)
                    foreach(var s in student)
                        foreach(var ds in s.disciplina)
                            if (dp.GetID_materie() == ds.GetID_materie())
                                foreach(var sp in dp.student)
                                    if (s.GetIdentificator() == sp.GetIdentificator())
                                    {
                                        ds.UpdateNotaActivitate(sp.nota_activitate);
                                        ds.UpdateNotaExamen(sp.nota_examen);
                                        ds.CalculNotaFinala();
                                    }
        }

        public void UpdateBD()
        {
            //update database with the new data for students
        }

        public void InsertBD()
        {
            //insert into database the data for students
        }
    }
}
