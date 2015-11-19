using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretariat_
{
    public class Secretariat
    {
        public List<Student> student { get; internal set; }

        internal Secretariat()
        {
            //populeaza lista studenti din baza de date
        }

        internal float ObtineMediaGeneralaAUnuiStudent(Object s)
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

        internal void ClarificareBursa()
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
            }
        }
    }
}
