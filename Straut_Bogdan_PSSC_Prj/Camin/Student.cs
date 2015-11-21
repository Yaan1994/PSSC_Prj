using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Camin
{
    public enum stareCamin { Neinteresat = 0, Interesat, Cazat, Fara_loc };

    public class Student
    {
        public string nume { get; internal set; }
        public string prenume { get; internal set; }
        public int nr_matricol { get; internal set; }
        public float medie { get; internal set; }
        public stareCamin stare { get; internal set; }

        public Student(string nume, string prenume, int nr_matricol, stareCamin stare)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.nr_matricol = nr_matricol;
            this.stare = stare;
        }

        public Student(int nr_matricol)
        {
            this.nr_matricol = nr_matricol;
        }

        public int GetIdentificator()
        {
            return this.nr_matricol;
        }

        public void GetMedieFromBD()
        {
            //preia media pentru student din BD
        }

        public override bool Equals(object obj)
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
