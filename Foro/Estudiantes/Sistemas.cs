using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Estudiantes
{
    public class Sistemas : Estudiante
    {

        private string lenguagesp;

        public void setLenguagesp(string lenguagesp)
        {

            this.lenguagesp = lenguagesp;

        }

        public string getLenguagesp()
        {

            return this.lenguagesp;

        }

    }
}
