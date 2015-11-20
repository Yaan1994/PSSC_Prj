using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class AdministratieCamin
    {
        public string nume { get; internal set; }
        public List<Student> student { get; internal set; }
        public int nr_locuri { get; internal set; }
        public int locuri_ocupate { get; internal set; }

        internal AdministratieCamin(string nume, int nr_locuri)
        {
            this.nume = nume;
            this.nr_locuri = nr_locuri;
            //citire din baza de date pentru studenti
            /*se presupune ca media generala pentru fiecare student este calculata
            in acest punct */
        }

        internal void SortareStudentiDupaMedie()
        {
            student.OrderBy(x => x.medie);
        }

        internal void CazareStudenti()
        {
            foreach (var stud_ in student)
            {
                if ((stud_.stare == stare.Interesat) && (locuri_ocupate < nr_locuri))
                {
                    stud_.stare = stare.Cazat;
                    locuri_ocupate++;
                }
            }
        }
    }
}
