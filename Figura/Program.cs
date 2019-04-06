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

        public abstract void Dibuja();
    }

    class Color
    {
      //Enumeraciones o enum como palabra reservada son un tipo especial de variables 
      // que tienen la propiedad de que su rango de valores es un conjunto de constantes enteras denominadas 
      // constantes de enumeración, a cada una de las cuales se le asigna un valor
      public enum Name{White, Red, Green, Blue, Yellow, Brown, Purple, Pink, Black, Silver, Grey, none}

      //Declaracion de atributos
      public int R,G,B,I;

        //Recuerda que el punto es como poner el this
        public Color colorName;
        public Color name;

        public Color ColorName { get => colorName; set => colorName = value; }

        //Constructor de Color
        public Color(int r, int g, int b, int i=1)
           {
              r=R;g=G;b=B;i=1; this.ColorName= colorName;
           }

          
      


    }

    class Circulo : Figura
    {
     private int radio;
     public Circulo(Vector2d pos, int radio):base(pos)
     {
         this.radio= radio;
     }
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

     public override void Dibuja() 
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
            Console.WriteLine("Rectangulo rojo");
            figuras.Add(new Cuadrado(new Vector2d(150,200) ));
            figuras.Add(new Triangulo(new Vector2d(150,250) ));
            figuras.Add(new Decagono(new Vector2d(150,250) ));
            foreach(Figura f in figuras)
            f.Dibuja();
           
        }
    }
}

