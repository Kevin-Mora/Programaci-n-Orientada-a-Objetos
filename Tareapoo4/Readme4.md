# Tarea4poo
## 1. Considera el siguiente fragmento de programa:
```c
using System;

class A

    {

    public int a;

    public A()

        {

        a = 10;

        }

    public _______ string Display()

      {

      return a.ToString();

      }

    }

class B:A

   {

   public int b;

   public B():base()

   {

    b = 15;

    // #########################################

  //  #  Después de contestar la pregunta 1                  

 //   #  Redefine el método Display( ) en este espacio,  debe regresar el campo b como string.

 //  #########################################

   }
   ```
## 1.1. ¿Qué valores imprimen las lineas (1) y (2) ?
Imprimen los valores establecidos para a  en el metodo display impuesto en ambos, en este caso **(10) y (10)**.

## 1.2.  Redefine el método Display en el espacio indicado,
###  una vez redefinido el método, ¿qué valores imprimen las lineas (1) y (2) ?.
Imprimen los valores establecidos para a y b en el metodo display impuesto en ambos, en este caso **(10) y (15)** respectivamente.

## 1.3. ¿Que palabra debes agregar en la linea (public _______ string Display()) al definir A.Display()?
 **Virtual**
## 2.1. Completa el programa.

```c
using System;
using System.Collections.Generic;

namespace Herencias
{

abstract class Musico

    {

    public string apodo;

    public Musico (string a)
        {
         apodo = a;
        }

   public abstract string  Afina();

   public abstract string  Apodo();   
   }

class Bajista: Musico
  {
    public string bajo;
        public Bajista (string n, string bajo ):base(n)
    {
        this.bajo=bajo;
    }

    public override string Apodo()
      {
          return String.Format("Hola, mi nombre es {0}",apodo);

      }
      public override string Afina()
     {
         return "afino mi bajo";
     }

 }

class Guitarrista: Musico
     {

     public string guitarra;

      // Falta el constructor y otras cosas??
     public Guitarrista(string nombre, string guitarra): base(nombre)
     {
         this.guitarra=guitarra;
     }
     public override string Apodo()
      {
          return String.Format("Hola, mi nombre es {0}",apodo);

      }
     public override string Afina()
     {
         return "afino mi guitarra";
     }
 }
class Program
 {
    static void Main()
   {
    Bajista a = new Bajista("Flea","bajo");
    Guitarrista c = new Guitarrista("Santana","guitarra");
     List<Musico>musicos=new List<Musico>();
    musicos.Add(a);
    musicos.Add(c);

  foreach (Musico m in musicos)
  {
      Console.WriteLine(m.Apodo());
      Console.WriteLine(m.Afina());

  }

 }
}
}
   ```

## 2.2. Hay un error en uno de los puntos (A)(B)(C)(D). ¿Cuál es y por qué?
(A) El metodo es abstracto pero la clase no.  
(B) En metodo abstracto, tiene la peculiaridad de que no necesariamente tiene que tener cuerpo.  
(C)   Regresa un dato pero no hay variable que lo reciba  
(D) Se creo un objeto de una clase abstracta

## 2.3. ¿Qué método se debe implementar obligatoriamente en ambas clases y por qué?
El metodo afina, por que ambos heredan de musica que es tipo abstracto.

## 2.4. ¿Por qué no se ponen las llaves en (B)?, ¿Cuando si se pondrían?
Por que es un metodo abstracto y no tiene cuerpo solo consta de las parentesis, solo puede existir en la clase abstracta y siempre termina en punto y coma. Si se podria si redefinieramos de abstracto, poniendo un cuerpo que se utilice tal cual o se pueda sobreescribir en caso de que sea virtual.



## 2.5. ¿Qué pasa si el método Afina() lo hacemos virtual en lugar de abstract?
En primer lugar se tiene que dar cuerpo, al hacerlo virtual las clases que hereden de Musico, pueden implementar el metodo original además de poder sobreescribirlo en cualquier clase derivada.

## 3. Implementa el programa utilizando interfaces en lugar de herencia.
```c
using System;
using System.Collections.Generic;

namespace Herencias
{



abstract class Musico

    {

    public string apodo;

    public Musico (string a)
        {
         apodo = a;
        }



   public abstract string  Apodo();   
   }
    interface IAfinar
{

     void  Afina();

}
class Bajista: Musico, IAfinar
  {
    public string bajo;
        public Bajista (string n, string bajo ):base(n)
    {
        this.bajo=bajo;
    }

    public override string Apodo()
      {
          return String.Format("Hola, mi nombre es {0}",apodo);

      }
      public void Afina()
     {
         Console.WriteLine("afino mi bajo ");
     }

 }

class Guitarrista: Musico, IAfinar
     {

     public string guitarra;

     public Guitarrista(string nombre, string guitarra): base(nombre)
     {
         this.guitarra=guitarra;
     }
     public override string Apodo()
      {
          return String.Format("Hola, mi nombre es {0}",apodo);

      }
     public void Afina()
     {
         Console.WriteLine("afino mi Guitarra  ");
     }
 }

 class Program
 {
    static void Main()
   {
    Bajista b = new Bajista("Flea","bajo");
    Guitarrista g = new Guitarrista("Santana","guitarra");
     List<Musico>musicos=new List<Musico>();
    musicos.Add(b);
    musicos.Add(g);

  foreach (Musico m  in musicos)
  {
      Console.WriteLine(m.Apodo());
      (m as IAfinar).Afina();

  }
 }
}
}
```
