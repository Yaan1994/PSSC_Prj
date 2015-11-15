using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class AdministratieCamin
    {
        private string nume { get; internal set; }
        private List<Student> student { get; internal set; }
        private int nr_locuri { get; internal set; }

        internal AdministratieCamin(string nume, int nr_locuri)
        {
            this.nume = nume;
            this.nr_locuri = nr_locuri;
            //citire din baza de date pentru studenti            
        }
    }
}
