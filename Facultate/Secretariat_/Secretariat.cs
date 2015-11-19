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

        internal float CalculeazaMediaGeneralaAStudentilor(Object s)
        {
            float medie_generala = 0;
            foreach (var stud_ in student)
            {
                if (stud_.Equals(s))
                {
                    medie_generala = stud_.CalculMedieGenerala();
                }
            }
            return medie_generala;
        }
    }
}
