  #Tareapoo3
  ## Tarea3
  ### 1.Define: Clase Base, Clase Derivada y Herencia
  #### Herencia
  Herencia, es un término que ya hemos comentado antes, pero en este caso indispensable para poder entender lo que son tanto la clase base como la clase derivada, por ende daré un breve resumen.

  La herencia en términos de programación es muy parecida a lo que hace referencia en términos de obtener las responsabilidades y/o bienes de alguien más, teniendo el derecho y/o obligación de cumplir con las responsabilidades que esto trae consigo, esta definición en programación quiere decir prácticamente lo mismo. En programación orientada a objetos hace referencia a que clases son creadas en base a otras clases ya existentes, es este caso las superclases o también llamadas clases padres.

  Las clases además de heredar las características también pueden heredar conductas (atributos y métodos), esto funcional en las abstracción de objetos para hacerlos aún más exactos y prácticos, muy útil cuando trabajamos con objetos con una cierta familiaridad, digamos autos, bicicletas, motocicletas, o hasta algo más abstracto como lo sería una clase llanta, sabiendo con anterioridad que hay una amplia gama y variedad de las mismas.

  Esto abre la posibilidad y ventaja de la reutilización de código que ya escribimos, evitando así una mala práctica la cual sería estar haciendo lo mismo una y otra vez sabiendo que objetos pertenecen a una misma familia de la cual podemos hacer una clase padre y de ahí las mismas mas prácticamente, así ahorrando tiempo, haciendo el trabajo más armonioso y limpio, y ahorrando dinero ya que de otra forma dificulta varios aspectos aumentando el esfuerzo y recursos que tienes que dedicarle y por ende el costo del mismo.

  ### Clase Base
  Una vez que sabemos que es la herencia, entenderemos que es la clase base, como vimos las clases hijas o subclases se hacen a forma de una clase base, de la cual heredan los ya sean atributos y metodos que contenga, teniendo asi ya atributos y metodos por defecto que no tiene que declarar directamente.

  Las clase base se dan por la necesidad de no tener que poner todos los atributos y metodos que tienen en comun una familia de clases, como por ejemplo para hacer un una clase baterista, guitarrista ó bajista no es necesario repetir las caracteristicas que los hacen musicos, por lo cual puede haber una clase musico ya sea abstracta o no que contenga las caracteristicas en comun de estos tres tipos de musicos.

  ### Clase derivada
  La clase derivada como su nombre lo dice, es derivada por que deriva de otra clase en este caso derivan de otras clases ya existentes no necesariamente clase base pueden heredar de otra clase derivada, pero no de dos clases distintas al mismo tiempo en la mayoria de lenguajes, para eso existen las interfaces.

  Un ejemplo claro que ello podrian ser un cuadrado, circulo y rombo, todas ellas son derivadas, en este caso de una clase figura mas generalizada que conserva todos sus aspectos en comun, como lo serian sus cordenadas dibujadas, sus contornos, o colores dependiendo el caso y la cantidad de atributos y metodos que queramos darles.

  ## 2. UML De clase base figura, con derivada de clase circulo y clase rectangulo
  ![](\Users\KEVIN\Programaci-n-Orientada-a-Objetos\Tareapoo3\Imagenes\uml figura.PNG)


  ## 3. Indica cuales son las clases base y las derivadas
  Indicados con la sintaxis de **:Figura**

  ## 4 ¿Que es herencia simple y herencia múltiple? ¿En c# se puede hacer herencia múltiple?
  ### Qué es herecia simple?
  Cuando hacemos referencia a la herencia simple, nos referimos a una clase derivada que solo tiene una clase base, aunque esto no quiere decir que la clase base no pueda tener mas de una clase que derive de ella como muestra la siguiente imagen:

  ![Imagen de ejemplo](http://3.bp.blogspot.com/-tSEKWRbTcts/VardeY5cwEI/AAAAAAAAAmI/2li6YYL0Vxs/s1600/herencia%2Bbasica.jpg)

  ### Qué es una herencia multiple?
  La herencia multiple es cuando es a una clase que hereda de mas de una clase base, esto se aplica de igual forma que cuando solo hereda de una con la sintaxis:  
  **class Derivada : public Base1, public Base2, public BaseN**

  La palabra reservada public hace referencia a su vez que esta heredando tanto metodos como atributos de cada una de esas clases que hacen de base de la clase derivada.

  De igual forma existe la herencia niveles multiples que hace referencia a una clase derivada que deriva de otra derivada que a su vez deriva de una clase base, teniendo un acomodo jerarquico por niveles.

  ### ¿En c# se puede hacer herencia múltiple?
  **En c# no hay herencia multiple de clase** se utilizan metodos de encapsulamiento y enlazado si tienes un modelo que llegara a ocupar herencia multiple, aunque si hablaramos de interfaz si se podria.

  ### 5. Escribe el programa de Figura como vimos en clase, donde agregues varios tipos de figuras a una lista y recorre la lista llamando a un metodo de las figuras, además :

  ##### 5.1 Se sobrecarguen los constructores y se acceda a los constructores de la clase base
  Aplicado

  ##### 5.2 Explica para que nos sirve la palabra base.
  Aplicado
  La palabra reservada base nos sirve acceder a los miembros de la clase base desde una clase derivada,
   llamar a un metodo de la clas ebase base que haya sido redefinido por otro metodo, señalar el
   constructor exacto al que se hace referencia cuando creamos instancias en otras clases derivadas.
  ##### 5.3  Haz el método Dibuja() que sea virtual y redefinelo en solo una de las clases derivadas.  
  aplicado


  ```c
   using System;
   using System.Collections.Generic;

   namespace Figura2
   {
       class Vector2d
       {
           public int x, y;
           public Vector2d(int x, int y)
           {
               this.x=x; this.y=y;
           }
           public override string ToString()
           {
               return String.Format("{0},{1}", x, y);
           }
       }
       abstract class Figura
       {
           public Vector2d position;
           public string fill ,border;

             //Constructor por defecto
           public Figura():this( new Vector2d(100, 100))
           {

           }
           //constructor de figura
           public Figura(Vector2d pos)
           {
               position= pos;
               fill= "white";
               border= "black";
           }

           public virtual void Dibuja()
           {

           }
       }

       class Circulo : Figura
       {
        private int radio;
        public Circulo(Vector2d pos, int radio):base(pos)
        {
            this.radio= radio;
        }
        //La palabra reservada base nos sirve acceder a los miembros de la clase base desde una clase derivada,
        // llamar a un metodo de la clas ebase base que haya sido redefinido por otro metodo, señalar el
        // constructor exacto al que se hace referencia cuando creamos instancias en otras clases derivadas.
        public Circulo ():base()
        {
            this.radio= 10;
        }

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un circulo en {0} de color {1}", position, fill);
        }
       }

       class Rectangulo : Figura
       {

        public Rectangulo(Vector2d pos):base(pos)
        {

        }
        public Rectangulo ():base()
        {

        }

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Rectangulo en {0} de color {1}", position, fill);
        }
       }

       class Cuadrado : Figura
       {

        public Cuadrado(Vector2d pos):base(pos)
        {

        }
        public Cuadrado ():base()
        {

        }

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Cuadrado en {0} de color {1}", position, fill);
        }
       }

        class Triangulo : Figura
       {

        public Triangulo(Vector2d pos):base(pos)
        {

        }
        public Triangulo ():base()
        {

        }

        public override void Dibuja()
        {
            Console.WriteLine("Se dibuja un Triangulo en {0} de color {1}", position, fill);
        }
       }

       class Decagono : Figura
       {

        public Decagono(Vector2d pos):base(pos)
        {

        }
        public Decagono ():base()
        {

        }

   //Metodo dibuja redefinido
        public virtual void Dibuja()
        {
            Console.WriteLine("Se dibuja un Decagono en {0} de color {1}", position, fill);
        }
       }



       class Program
       {
           static void Main(string[] args)
           {

               List<Figura> figuras = new List<Figura>();
               figuras.Add(new Circulo());
               figuras.Add(new Rectangulo(new Vector2d(200,200) ));
               figuras.Add(new Cuadrado(new Vector2d(150,200) ));
               figuras.Add(new Triangulo(new Vector2d(150,250) ));
               figuras.Add(new Decagono(new Vector2d(150,250) ));
               foreach(Figura f in figuras)
               f.Dibuja();

           }
       }
   }

  ```
