using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat
{
    public class Secretariat
    {
        public List<Student> student { get; internal set; }

        public Secretariat()
        {
        }

        public bool FindStudent(Student stud)
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

        public bool AddStudent(Student stud)
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

        public bool RemoveStudent(Student stud)
        {
            if (FindStudent(stud))
            {
                student.Remove(stud);
                return true;
            }
            else
                return false;
        }

        public void CalculMedieGenerala()
        {
            foreach (var s in student)
            {
                float medie = 0;
                foreach (var d in s.disciplina)
                {
                    medie += (d.GetNota_examen() * 2 + d.GetNota_activitate()) / 3;
                }
                s.UpdateMedie_generala(medie);
            }
        }       

        public float ObtineMediaGeneralaAUnuiStudent(Student s)
        {
            float medie_generala = 0;
            foreach (var stud_ in student)
            {
                if (stud_.Equals(s))
                {
                    medie_generala = stud_.GetMedie_generala();
                }
            }
            return medie_generala;
        }

        public void ClarificareBursa()
        {
            foreach (var stud_ in student)
            {
                if (ObtineMediaGeneralaAUnuiStudent(stud_) > 8.00f)
                {
                    stud_.UpdateBursa(bursier.Da);
                }
                else
                {
                    stud_.UpdateBursa(bursier.Nu);
                }
                AdaugaStudentinBD(stud_);
            }
        }

        public void AdaugaStudentinBD(Student stud)
        {
            //adauga studentul in BD
        }

        public void UpdateStudentinBD(Student stud_)
        {
            //Se face update in BD pe studentul primit ca parametru
        }
    }
}
