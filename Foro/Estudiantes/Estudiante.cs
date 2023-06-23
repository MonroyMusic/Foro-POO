using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Estudiantes
{
    public class Estudiante
    {

        private string name;

        private string code;

        private int age;

        public void setName(string name)
        {

            this.name = name;

        }

        public string getName() 
        { 
            
            return this.name; 
        
        }

        public void setCode(string code)
        {

            this.code = code;

        }

        public string getCode()
        {

            return this.code;

        }

        public void setAge(int age)
        {

            this.age = age;

        }

        public int getAge()
        {

            return this.age;

        }

        public Estudiante(string name, string code, int age)
        {
            
            this.name = name;

            this.code = code;

            this.age = age;

        }

        public Estudiante()
        {
            
        }

    }
}
