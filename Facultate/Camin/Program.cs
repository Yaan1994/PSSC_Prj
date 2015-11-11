using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camin
{
    class Student
    {
        private String nume { get; set; }
        private String prenume { get; set; }
        private int nr_matricol { get; set; }
        private float medie { get; set; }
    }

    class AdministratieCamin
    {
        private String nume { get; set; }
        private List<Student> student;
    }
}
