using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class Camin
    {
        public string nume { get; internal set; }
        public List<Student> student { get; internal set; }
        public int nr_locuri { get; internal set; }
        public int locuri_ocupate { get; internal set; }
        public float medie_de_intrare { get; internal set; }

        public Camin(string nume, int nr_locuri, float medie_de_intrare)
        {
            this.nume = nume;
            this.nr_locuri = nr_locuri;
            this.medie_de_intrare = medie_de_intrare;
        }

        public bool VerificareMedie(Student stud)
        {
            if (stud.medie > medie_de_intrare)
                return true;
            else
                return false;
        }

        public bool CazareStudentInCamin(Student stud)
        {
            bool confirmare = false;

            if (locuri_ocupate == null)
            {
                locuri_ocupate = 1;
                student.Add(stud);
                confirmare = true;
            }
            else
            {
                if (locuri_ocupate < nr_locuri)
                {
                    stud.stare = stare.Cazat;
                    student.Add(stud);                    
                    locuri_ocupate++;
                    confirmare = true;
                }
                else
                {
                    confirmare = false;
                }
            }

            return confirmare;
        }
    }
}
