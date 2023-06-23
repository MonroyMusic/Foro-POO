using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foro.Estudiantes
{
    public class App
    {

        List<Estudiante> students = new();
        List<Sistemas> systems = new();
        List<Lenguas> lenguagesl = new();

        public App()
        {

            bool exit = false;

            Console.WriteLine("Registro de Estudiantes");

            while (!exit)
            {

                Console.WriteLine("\n¿Que acción desea realizar?");
                Console.WriteLine("1. Registrar un Estudiante");
                Console.WriteLine("2. Mostrar Estudiantes Registrados");
                Console.WriteLine("3. Eliminar un Estudiante");
                Console.WriteLine("4. Vaciar la lista de Estudiantes");
                Console.WriteLine("5. Salir");

                Console.WriteLine("Ingrese el número de la Opción: ");

                int opt = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch(opt) 
                {

                    case 1:
                        AddStudent();
                        break;

                    case 2:
                        ShowStudents();
                        break;

                    case 3:
                        DeleteStudent();
                        break;

                    case 4:
                        ClearList();
                        break;

                    case 5:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;

                }

            }

            
        }

        private void AddStudent()
        {
            
            Console.Write("Ingrese la carrera que cursa el estudiante");
            Console.Write("1/Ing. en Sistemas   2/Lic. en Lenguas Extranjeras");
            int car = Convert.ToInt32(Console.ReadLine());

            switch(car){

                case 1: Sistemas sistemas = new Sistemas();
                    Console.WriteLine("Ingrese el Nombre del estudiante");
                    string name = Console.ReadLine();

                    Console.WriteLine("Ingrese el codigo del estudiante");
                    string code = Console.ReadLine();

                    Console.WriteLine("Ingrese la edad del estudiante");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Cual es el lenguaje de programación que deséa estudiar " +
                        "el estudiante?");

                    string lenguagesp = Console.ReadLine();

                    sistemas.setName(name);
                    sistemas.setCode(code);
                    sistemas.setAge(age);
                    sistemas.setLenguagesp(lenguagesp);

                    students.Add(sistemas);
                    systems.Add(sistemas);

                    Console.WriteLine("Estudiante agregada exitosamente");

                    break;

                case 2:
                    Lenguas lenguas = new Lenguas();
                    Console.WriteLine("Ingrese el Nombre del estudiante");
                    string namel = Console.ReadLine();

                    Console.WriteLine("Ingrese el codigo del estudiante");
                    string codel = Console.ReadLine();

                    Console.WriteLine("Ingrese la edad del estudiante");
                    int agel = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Cual es el lenguaje que deséa estudiar " +
                        "el estudiante?");

                    string lenguages = Console.ReadLine();

                    lenguas.setName(namel);
                    lenguas.setCode(codel);
                    lenguas.setAge(agel);
                    lenguas.setLenguages(lenguages);

                    students.Add(lenguas);
                    lenguagesl.Add(lenguas);

                    Console.WriteLine("Estudiante agregada exitosamente");

                    break;

                default: Console.WriteLine("El número ingresado no corresponde a ninguna carrera");
                        break;

            }
                        
        }

        private void ShowStudents()
        {
            
            if (students.Count == 0)
            {

                Console.WriteLine("No hay Estudiantes en la lista");

            }
            else
            {

                Console.WriteLine("Elija de que carrera desea ver la lista 1/Ing. Sistemas" +
                    "  2/Lic. en Lenguas  3/En General");

                int opt = Convert.ToInt32(Console.ReadLine());

                switch (opt)
                {

                    case 1: Console.WriteLine("Lista de Estudiantes de Ing en sistemas");

                        foreach (var student in systems)
                        {

                            Console.WriteLine($"Nombre: {student.getName()}, " +
                                $"Código: {student.getCode()}, " +
                                $"Edad: {student.getAge()}, " +
                                $"Lenguaje a Aprender: {student.getLenguagesp()}");

                        }

                        break;

                    case 2: Console.WriteLine("Lista de Estudiantes de Lic. en Lenguas");

                        foreach (var student in lenguagesl)
                        {

                            Console.WriteLine($"Nombre: {student.getName()}, " +
                                $"Código: {student.getCode()}, " +
                                $"Edad: {student.getAge()}, " +
                                $"Lenguaje a Aprender: {student.getLenguages()}");

                        }

                        break;

                    case 3: Console.WriteLine("Lista de Estudiantes");

                        foreach (var student in students)
                        {

                            Console.WriteLine($"Nombre: {student.getName()}, " +
                                $"Código: {student.getCode()}, " +
                                $"Edad: {student.getAge()}");

                        }

                        break;

                    default: Console.WriteLine("La opción no es valida");
                        break;

                }

                

            }

        }

        private void DeleteStudent()
        {

            Console.WriteLine("Ingrese el código del estudiante a eliminar: ");
            string code = Console.ReadLine();

            bool findedStudent = false;

            for (int i = 0; i < students.Count; i++)
            {

                if (students[i].getCode() == code)
                {

                    students.RemoveAt(i);
                    findedStudent = true;

                    Console.WriteLine("Estudiante Eliminado");

                    break;

                }

            }

            if (!findedStudent)
            {

                Console.WriteLine("No se encontro el código del estudiante en la lista");

            }

        }

        private void ClearList()
        {

            students.Clear();
            systems.Clear();
            lenguagesl.Clear();

            Console.WriteLine("Lista de Estudiantes borrado");

        }
    }
}
