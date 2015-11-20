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

        public void AdaugaStudent(Student stud_)
        {
            student.Add(stud_);
        }

        public float ObtineMediaGeneralaAUnuiStudent(Object s)
        {
            float medie_generala = 0;
            foreach (var stud_ in student)
            {
                if (stud_.Equals(s))
                {
                    medie_generala = stud_.medie_generala;
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
                    stud_.bursa = bursier.Da;
                }
                else
                {
                    stud_.bursa = bursier.Nu;
                }
                AdaugainBD(stud_);
            }
        }

        public void AdaugainBD(Student stud)
        {
            //adauga studentul in BD
        }

        public void UpdateStudent(Student stud_)
        {
            //Se face update in BD pe studentul primit ca parametru
        }
    }
}
