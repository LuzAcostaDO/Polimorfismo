using System;

namespace polimorfismo
{
    abstract class Persona
    {
        public string nombre;
        public string prof;
        public virtual void Saludar()
        {
            Console.WriteLine("Mi nombre es: " + nombre);
            Console.WriteLine("Soy: " + prof);
            Console.WriteLine("");
        }
    }

    class Empleado : Persona
    {
        public Empleado()
        {
            nombre = "Jessica";
            prof = "Empleado";
        }
    }

    class Alumno : Persona
    {
        public Alumno()
        {
            nombre = "Jules";
            prof = "Alumno";
        }
    }

    class main
    {
        static void Main(string[] args)
        {
        Empleado stu = new Empleado();
        Alumno emp = new Alumno();
        
        Persona[] ppl  = {stu, emp};
        foreach(Persona x in ppl)
        {
            x.Saludar();
            x.Saludar();
        }
        }
    }
}
