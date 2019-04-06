using System;
using System.Collections.Generic;

namespace Interfaz
{
    interface IRenderizable
    {
       void Render();
    }
    class Image: IRenderizable
    {
        public void Render()
        {
            Console.WriteLine("Se renderiza la Imagen");
        }
        
    }
    class Video: IRenderizable
    {
        public void Render()
        {
            Console.WriteLine("Se renderiza el video");
        }
    }




    class Program
    {
        static void Main(string[] args)
        { 
            Dictionary<String, IRenderizable> dict = new Dictionary<String, IRenderizable>();
            dict.Add("intro.mov", new Video());
            dict.Add("Pedro01.png", new Image());
            dict.Add("endotro.mov", new Video());
            dict.Add("example01.png", new Image());
            dict.Add("presentacion.mov", new Video());

           // IRenderizable contenido;
           // if (dict.TryGetValue("intro.mov", out contenido ))Console.WriteLine(contenido );
            
            //else 
            //Console.WriteLine("No se encontro");

           foreach(string key in dict.Keys())
           {
               if (dict.TryGetValue("intro.mov", out contenido ))Console.WriteLine(contenido );
                contenido.Render();
            else 
            Console.WriteLine("No se encontro");

           }
            
        }
    }
}
