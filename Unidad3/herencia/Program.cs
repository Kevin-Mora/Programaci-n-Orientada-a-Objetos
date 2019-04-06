 using System;
using System.Collections.Generic;
namespace herencia
{
   
    class Comentario 
    {
        public string id;
        public string texto;
        public string autor;

        public Comentario(string texto, string autor)
        {
            id= Guid.NewGuid().ToString();
            this.texto= texto;
            this.autor= autor;
        }

        public override string ToString()
        {
            return String.Format ("id:{0} {1} {2}", id, autor, texto);
        }

    }
    class Contenido
    {

    }

    class Post
    {
        public string id;
        public DateTime fecha_hora;

        public string autor;

        public List<Comentario> comentarios;

        public Post(string autor)
        {
             id= Guid.NewGuid().ToString();
             fecha_hora= DateTime.Now;
             comentarios = new List<Comentarios>();
             this.autor= autor;
        }
    }

    class PostUbica: Post
    {
        public string ubicacion;
        public string texto;
         /// DOS PUNTOS BASE
         // EN LA PRIMERA PARENTESIS DECLARO Y EN LA SEGUNDA PASO EL PARAMETRO POR ESO NO PONGO STRING
        public PostUbica(string autor,string texto):base(autor)
        {
            this.texto= texto;
        }
        public override string ToString()
        {
            string comment = "";
            foreach (var comments in this.comentarios)
             comments+= comment + "\n";
           return String.Format("{1}está en  \n{0} \n{2} \n{3}", ubicacion, autor, comments, fecha_hora);
        }
    }

    class PostTexto: Post
    {
        public string texto;
         /// DOS PUNTOS BASE
         // EN LA PRIMERA PARENTESIS DECLARO Y EN LA SEGUNDA PASO EL PARAMETRO POR ESO NO PONGO STRING
        public PostTexto(string autor,string texto):base(autor)
        {
            this.texto= texto;
        }
        public override string ToString()
        {
            string comment = "";
            foreach (var comments in this.comentarios)
             comments+= comment + "\n";
           return String.Format("{0} \n{1} \n{2} \n{3}", texto, autor, comments, fecha_hora);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Post> muro = new List<Post>();
            string texto= "Hola, publicando desde el salón \n say hi!";
            string autor= "Kevin Mora";
            muro.Add(new PostTexto(texto, autor));
             muro.Add(new PostTexto("saludos", "att yo"));
             muro.Add( new PostUbica("Mariosky", "Tecnológivo de Tijuana"));

             muro[1].comentarios.Add(new Comentario ("Mariosky"),("Quien eres ?"));
             muro[1].comentarios.Add(new Comentario("Yo"), ("Yo"));
             muro[1].comentarios.Add(new Comentario("Alejandra",  "Yo tambien <3"));


             foreach (var post in muro)
             Console.WriteLine(post);
        }
    }
}
