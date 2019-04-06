using System;
using System.Collections.Generic;
namespace interfaz2
{
    //le hacemos que implemente Icomparable
    class Persona:IComparable
    {
        string Nombre {get;set;}
        DateTime FechaNacimiento {get;set;}

        public Persona (string n, DateTime fn)
        {
            Nombre=n; FechaNacimiento =fn;
        }

        public override string ToString()
        {
            return String.Format("{0} ({1})", Nombre, FechaNacimiento.ToString("dd/MM/yyyy"));
        }
       
       //es int, por que comparan con un entero
        public int CompareTo(object obj)
        {
           return Nombre.CompareTo((obj as Persona).Nombre);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("ana", new DateTime(2001,1,13)));
             personas.Add(new Persona("zoe", new DateTime(2002,1,13)));
              personas.Add(new Persona("tom", new DateTime(2004,1,13)));
               personas.Add(new Persona("bob", new DateTime(1992,1,13)));
               
               //sort es para ordenar los objetos como tu quieras
               personas.Sort();

               foreach(var p in personas)

            Console.WriteLine(p);

        }
    }
}
