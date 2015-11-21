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

        public bool FindCamin(Camin Cam)
        {
            foreach (var c in camin)
            {
                if (c.Equals(Cam))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddCamin(Camin Cam)
        {
            if (FindCamin(Cam))
            {
                return false;
            }
            else
            {
                camin.Add(Cam);
                return true;
            }
        }

        public bool RemoveCamin(Camin Cam)
        {
            if (FindCamin(Cam))
            {
                camin.Remove(Cam);
                return true;
            }
            else
                return false;
        }

        internal void Cazare(Student stud)
        {
            foreach (var c in camin)
            {
                bool verifica_cazare = false;
                if (stud.stare == stareCamin.Interesat || stud.stare == stareCamin.Fara_loc)
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
