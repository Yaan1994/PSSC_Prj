using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class Student
    {
        private string nume {get; internal set;}
        private string prenume { get; internal set; }
        private int nr_matricol { get; internal set; }
        private float medie { get; internal set; }
        private bool cazare { get; internal set; }

        internal Student(string nume, string prenume, int nr_matricol, bool cazare)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_matricol = nr_matricol;
            this.cazare = cazare;
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
