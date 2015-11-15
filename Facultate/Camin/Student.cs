using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Camin
{
    //ACEST ENUM AR TREBUI DEFINIT CA O CLASA NOUA!
    enum stare { Neinteresat = 0, Interesat, Cazat, Fara_loc };

    class Student
    {
        private string nume {get; internal set;}
        private string prenume { get; internal set; }
        private int nr_matricol { get; internal set; }
        private float medie { get; internal set; }
        private stare stare { get; internal set; } 

        internal Student(string nume, string prenume, int nr_matricol, stare stare)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_matricol = nr_matricol;
            this.stare = stare;
            //apeleaza secretariat pentru medie
        }

        internal override bool Equals(object obj)
        {
            var student = (Student)obj;
            if (student != null)
            {
                if (student.nr_matricol == this.nr_matricol)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
