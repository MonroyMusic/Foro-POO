using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Estudiantes
{
    public class Lenguas : Estudiante
    {

        private string lenguages;

        
        public void setLenguages(string lenguages)
        {

            this.lenguages = lenguages;

        }

        public string getLenguages()
        {

            return this.lenguages;

        }

    }
}
