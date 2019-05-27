using System;
using System.Collections.Generic;
using System.IO;

namespace proyecto
{
    
    public class Producto
    {
        //Atributos
        public string Codigo;
        public string Descripcion;
        public decimal Precio;
        public int Departamento;
        public int Likes;

        public Producto()
        {
        }

        //Método
        public Producto(string Codigo, string Descripcion, decimal Precio, int Departamento, int Likes)
        {
            this.Codigo=Codigo;
            this.Descripcion=Descripcion;
            this.Precio=Precio;
            this.Departamento=Departamento;
            this.Likes=Likes;
         
        }
        public void GetDepartament(int Departamento)
        {
            //if(Nump==1)
            //{
                
            //}
            Console.WriteLine("Codigo:{0}|Descripción:{1}|Precio:${2}",Codigo,Descripcion,Precio);
            
        }
        
        
    }

    class ProductoDB
    {
        public static void Save(string path,List<Producto>productos)
        {
            StreamWriter  txtOut=new StreamWriter(new FileStream("Productos.txt",FileMode.Create,FileAccess.Write));
            foreach (Producto producto in productos)
            {
                txtOut.Write(producto.Codigo+"|");
                txtOut.Write(producto.Descripcion+"|");
                txtOut.Write(producto.Precio);
                txtOut.Write(producto.Departamento+"|");
                txtOut.WriteLine(producto.Likes+"|");
            }
            txtOut.Close();
           
            //Binario     
            BinaryWriter binaryOut= new BinaryWriter(new FileStream(path,FileMode.Create,FileAccess.Write));
            foreach(Producto producto in productos)
            {
                binaryOut.Write(producto.Codigo);
                binaryOut.Write(producto.Descripcion);
                binaryOut.Write(producto.Precio);
                binaryOut.Write(producto.Departamento);
                binaryOut.Write(producto.Likes);
            }
            binaryOut.Close();
        }

    }
    class Program
    {
        

        static void Main(string[] args)
        {
             //Departamento
            Console.WriteLine("Introduza número de departamento");
            int num=1;
            string captura;
            List<Producto>productos= new List<Producto>();

    
            try
            {
                captura=Console.ReadLine();
                num= Int32.Parse(captura);

                if (num>=4)
                {
                Console.WriteLine("El departamento no existe");
                
                }
               else if (num==1)
               {
                  
            productos.Add(new Producto("AA11000","Blusa rosa",100,1,50));
            productos.Add(new Producto("AA12000","Blusa blanca",100,1,52));
            productos.Add(new Producto("AA13000","Blusa blusa negra",100,1,60));  
            foreach(Producto p in productos)
            p.GetDepartament(1);

                }
                else if(num==2)
                {
                productos.Add(new Producto("BB11000","Pluma negra",5,2,81));
                productos.Add(new Producto("BB12000","Pluma azul",5,2,58));
                productos.Add(new Producto("BB13000","Pluma roja",5,2,12));
                foreach(Producto p in productos)
                p.GetDepartament(2);

                }
                else if(num==3)
                {
                    productos.Add(new Producto("CC11000","Jugo de manzana",15,3,13));
                    productos.Add(new Producto("CC12000","Jugo de durazno",15,3,11));
                    productos.Add(new Producto("CC13000","Jugo de mango",15,3,1));
                    productos.Add(new Producto("CC14000","Jugo de piña",15,3,48));
                    foreach(Producto p in productos)
                    p.GetDepartament(3);
                }

    
            }
            catch( System.OverflowException)
            {
                Console.WriteLine("Overflow");
            }
            catch(Exception e)
            {
              Console.Write(e.Message);

            }
            finally
            {
                Console.WriteLine();
            }

            
            //Para crear carpetas
          string dir= @"C:\Users\KEVIN\Desktop\Productos";
          
          if(!Directory.Exists(dir)) 
          Directory.CreateDirectory(dir);

          //Para crear archivos
          string path=dir + "Producto.txt";
          if(File.Exists(path))
          File.Delete(path);
            
            

            
           
           

            


            //2. Para binario
            
            BinaryReader binaryIn=new BinaryReader(new FileStream(path,FileMode.OpenOrCreate,
            FileAccess.Read));

            List<Producto>Productos=new List<Producto>();
            while(binaryIn.PeekChar()!=-1)
            {
                Producto producto=new Producto();
                producto.Codigo=binaryIn.ReadString();
                producto.Descripcion=binaryIn.ReadString();
                producto.Precio=binaryIn.ReadDecimal();
                producto.Departamento=binaryIn.ReadInt32();
                producto.Likes=binaryIn.ReadInt32();
                productos.Add(producto);
            }

           
        }
    }
}