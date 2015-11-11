using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class Student
    {
        private string nume;
        private string prenume;
        private int nr_matricol;
        private float medie;

        public Student(string nume, string prenume, int nr_matricol)
        {
            setNume(nume);
            setPrenume(prenume);
            setNr_matricol(nr_matricol);
        }

        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getNume()
        {
            return nume;
        }

        public void setPrenume(string prenume)
        {
            this.prenume = prenume;
        }

        public string getPrenume()
        {
            return prenume;
        }

        public void setNr_matricol(int nr_matricol)
        {
            this.nr_matricol = nr_matricol;
        }

        public int getNr_matricol()
        {
            return nr_matricol;
        }

        public void setMedie(float medie)
        {
            this.medie = medie;
        }

        public float getMedie()
        {
            return medie;
        }
    }

    class AdministratieCamin
    {
        private string nume;
        private List<Student> student;

        public void setNume(string nume)
        {
            this.nume = nume;
        }

        public string getNume()
        {
            return nume;
        }

        public AdministratieCamin(string nume)
        {
            setNume(nume);
        }
    }
}
