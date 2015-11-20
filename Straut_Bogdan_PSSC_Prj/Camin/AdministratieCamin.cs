using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class AdministratieCamin
    {
        public List<Camin> camin { get; internal set; }

        internal AdministratieCamin()
        {
            /*se presupune ca media generala pentru fiecare student este calculata
            in acest punct */
        }

        internal void AdaugaCamin(string nume, int nr_locuri, float medie_de_intrare)
        {
            camin.Add(new Camin(nume, nr_locuri, medie_de_intrare));
        }

        internal void Cazare(Student stud)
        {
            foreach (var c in camin)
            {
                bool verifica_cazare = false;
                if (stud.stare == stare.Interesat || stud.stare == stare.Fara_loc)
                {
                    if (c.VerificareMedie(stud))
                    {
                        if (c.CazareStudentInCamin(stud))
                        {
                            verifica_cazare = true;
                        }
                    }
                }

                if (verifica_cazare == true)
                {
                    break;
                }
            }
        }
    }
}
