# Tarea 2
### 2.1 Declaración de clases: atributos, métodos, encapsulamiento.
En Common Type System en . net, class y struct son dos tipos de encapsulamientos básicos con los cuales se hacen  las abstracciones de objetos con todos sus comportamientos, métodos y atributos.Cuando declaramos una clase hacemos uso de un plano de objeto en tiempo de ejecución, pudiendo crear más de una del mismo tipo de objeto.

La clase en sí misma es una referencia, si se crea una variable asignándole el valor de tu clase solo hay una referencia a la memoria donde está la clase, son especialmente utilizadas para comportamientos más complejos

En programación el encapsulamiento se le suele tomar como la primera  fase dado que con ella haces las referencias, quien puede acceder a sus atributos y así limitar errores y/o ataques cibernéticos.Todos los atributos sean métodos, propiedades, constantes o eventos se declarar en un tipo (type) así sea un punto de entrada.

Existe el código de cliente que es cuando pueden ser invocados los métodos y/o propiedades, a la vez que otros son lo contrario y solo se utilizan localmente, se debe tener cuidado saber las herramientas para tener seguros los datos.

![Imagen representativa](https://i.blogs.es/5a328c/aprender-informatica/450_1000.jpg)

También existen las herencias para poder usar atributos bases de una clase a otras, de igual forma se pueden declarar abstract si no utilizaremos todas las singularidades de la clase que hereda, pudiendo incluso heredar todos los tipos de métodos definidos en la interfaz.

El  tipo estático hace referencia a clases que solo contienen integrantes estáticos , se les hace referencia a ellos a través del nombre de la clase.

Las clases se pueden anidar dentro de clases o estructuras. De igual forma  puedes definir  parte de estructuras, clases o métodos en partes, haciendo una en un archivo y otra parte en otra.

Al igual que existen las clases referenciales, existen las clases que no queremos que conserven sus valores ya que serán cambiantes a estos se les conoce como tipo anónimos.Si ocupamos agrandar una clase sin necesidad de crear una hija, podemos hacer una independiente donde sus métodos se les pueden llamar como si fueran de la original.

##     2.2 Instanciación de una clase.

Cuando nos referimos al operador new, hacemos referencia al espacio de almacenamiento persistente, con este operador podemos crear objetos de cualquier tipo incluso los hechos por nosotros.

Al decir que es persistente, decimos que su vida, de ese objeto creado con new, es desde su creación, hasta que el usuario finalice el programa o lo elimine con delete.

El en operador new podemos puede aceptar un inicializador opcional, para que rellene el valor reservado, con el que le implantemos.

![new](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuYGRFpsw9dhXy6OpvQ9TSHxvqXlprP4ujKEoq1vXN5NJoTRuvuw)

Este operador new suele es de utilidad a la hora de crear 1 o mas objetos, asignandole los atributos  de la clase padre en el momento, sea string nombre, string apellido, int edad,por dar un ejemplo, poniendo la referencia de ese nuevo objeto, dandole el transfondo que tendra igualandolo a la clase que queremos que tome de referencia, por ejemplo:

{  
  Console new P = Persona("Pedro", "Quezada", 13 );  
}

##   2.3 Referencia al objeto actual.  
La palabra clave this hace referencia a la instancia actual de la clase.

Escribe un programa donde utilices this para obtener acceso a miembros con el fin de evitar ambigüedades con nombres similares.  
Escribe un programa donde se utilice this como parámetro.

### This utilizado para acceder a miembros
```CSharp
namespace THISPOO  
{  
    class Jugador   
    {  
        public string nombre;  
        public string Num_Jugador;


        public Jugador ()
       {
          this.nombre = nombre;
          this.Num_Jugador = Num_Jugador;
       }

       public void imprime()
       {
           Console.WriteLine(nombre);
           Console.WriteLine(Num_Jugador);

       }

    }


    class Program
    {
        static void Main()
        {
            Jugador z = new Jugador();
            z.nombre = ("pepe");
            z.Num_Jugador=("008");

             z.imprime();

           Console.WriteLine();
           Console.ReadKey();

        }
    }
}
```

### This como parametro

```csharp namespace this_parametros
       {
         class this1_parametros
         {
             public string this1;

             public this1_parametros(string s)
             {
               this1=s
             }
             public static (this string s)
             {
               return="listo"
             }

         }


       }
       ``

### 2.4 Métodos: declaración, mensajes, paso de parámetros, retorno de valores.
Cuando nos refrimos a parametros declarados en un metodo, no necesesariamente tiene que llevar in, ref o out, en ese caso se traladan al metodo por valor, en el cual el valor del parametro se puede modificar, y para modificar ese comportamiento se utiliza, params, in, ref, out.

#### Params
Con Params se especifica un parametro de un metodo que toma un número variable de argumentos, puediendo enviar listas de este tipo separadas por una coma. Es una matriz unidimencional, y si ya se declaro esta palabra clave en el metodo, no se puede volver a delclarar.

#### out
Se utiliza de dos formas, como modificador de un parametro, que permite enviar valores mediante una referencia, y para declaracionde tipo generico, que es especifica que un parametro de tipo es covariante.

#### Ref, in, out(Referencia de c#)
Ref indica el valor que se ha pasado mediante la referencia, es utilizado en estas 4 situaciones.

1. En una firma de metodo y en una llamada de metodo.
2. En una firma de metodo.
3. En un cuerpo de miembro.
4. En una declaracion struct.

Si ref se utiliza en una lista de parametros del metodo, señala que se paso mediante referencia no por valor, tiene el inconveniente que si se cambia en la raiz, se cambiara en todos los que hicieron referencia de el.
Si utilizamos ref, es necesario usar la palbra clave(ref).

Un argumento que se pasa a "ref" o "in" deve inicializarse antes de pasarlo para que no de error.De igual forma si un metodo utiliza un ref(in o out) puede pasarlo a otro que tenga un parametro de valor.

Ref, in, out no se pueden utilizar en metodos asincronicos y metodos de iterador.

Ref se puede utilizar igualmente para pasar tipos de referencia mediante referencias.Los valores que se  devuelven de el tipo ref, son valores de referencia al autor de la llamada, puede igual ser readonly para exigir a este que llama no poder modificar el valor devuelto.

Las variables locales del tipo ref se utilizan para referenciar a los valores devueltos con  "return ref".

Existen varios de tipos de estructura de referencia que sirven para poder evitar siertos errores que te pueden provocar errores de confusión  e igualmente combinado modificacores como, ya sea readonly ref, readonly ref struct, ref struct y readonly struct.
![Modificadores](http://2.bp.blogspot.com/-qoce4cdaTg8/UkC7D_4yStI/AAAAAAAAGJY/Mbz_y4SYKOU/s1600/Dev+-+CSharp+5.0+in+a+Nutshell+-+Chapter+02+-+Tabla+1.+Modificadores+de+par%C3%A1metros.png)








### 2.5 Constructores y destructores: declaración, uso y aplicaciones
Los constructores , son metodos de clase que tienen el mismo nombre de la clase,suelen ser publicos y  por lo general inicializan los valores. Hay diferentes tipos de constructores como el que no toma parametros a este se le llama constructor predeterminado.

Para evitar que se creen instancias con los constructores puede hacerce privado. De igual forma los constructores para tipos struct no se les puede crear un constructor predeterminado explicito, ya que por defecto se les crea uno automaticamente. Para contrarrestar esto existe la alternativa de inicializar objetos basados en struct.

Es importante saber que sean clases o struct pueden definir constructores que acepten parametros, ya sea a base de new o "base", y cualquier constructor puede utilizar la palabra reservada "base" para invocar al constructor de una clase base.

Tambien existen las clases derivadas en donde si no llama explicitamente al constructor de la clase base mediante "base", se llamara solo constructor predeterminado, si tienes alguno.

![Constructor](https://www.monografias.com/trabajos107/programacion-orientada-objetos-java/Diapositiva10.png)



###  2.7 Sobrecarga de operadores: Concepto y utilidad, operadores unarios y binarios.
```CSharp
 using System;


//Programa que determina el dado de mayor puntuaje, cuando 3 jugadores lanzan uno
namespace Programa_Dados
{

//Clase dado
    class Dado
    {
        public string color;
        public int puntos;

        //Sobrecarga de la clase dado
        public Dado(int puntos, string color)
        {
            this.puntos = puntos;
            this.color = color;
        }

        //Imprime
        public void Imprime()
        {
            Console.WriteLine("Puntos: {0}-Color: {1}", puntos, color);
        }
        // Operadores de desigualdad sobrecargados

       public static bool operator >=(Dado a, Dado b)
        {
            return (a.puntos.CompareTo(b.puntos) > 0);
        }

        public static bool operator <=(Dado a, Dado b)
        {
            return a.puntos < b.puntos;
        }

    }
    class Program
    {

        // Declaracion de objetos y sus atributos.
        static void Main()
        {

            Dado x=new Dado(3,"Plateado");
            Dado y=new Dado(6,"Negro");
            Dado z=new Dado(2,"Morado");

            if (z >= y && z>=x )
            {
              z.Imprime();
            }
            else if (y >= x && y>=z)
            {
               y.Imprime();
            }
            else if (x >= y && x>=z)
            {
              x.Imprime();
            }


            Console.ReadKey();
        }
    }
} ```
