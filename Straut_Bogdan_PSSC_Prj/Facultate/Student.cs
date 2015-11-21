using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate
{
    class Student
    {
        public int nr_matricol { get; internal set; }
        
        public Student(int nr_matricol)
        {
            this.nr_matricol = nr_matricol;
        }

        public int GetIdentificator()
        {
            return this.nr_matricol;
        }

        public override bool Equals(object obj)
        {
            var student = (Student)obj;
            if (student != null)
            {
                if (student.GetIdentificator() == this.GetIdentificator())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
