using System;

namespace Departamental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza número de departamento");
            int num=1;
            string captura;

    
            try
            {
                captura=Console.ReadLine();
                num= Int32.Parse(captura);

                if (num>5)
                {
                Console.WriteLine("El departamento no existe");
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
        }
    }
}
