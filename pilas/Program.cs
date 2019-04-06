using System;


namespace pilas
{
    public class Stack<T>//La t es de tipo

{

   readonly int m_Size; //m_size es el tamaño de mi pila

   int m_StackPointer = 0;//ocupamos un apuntador del stack(pila), es privado, entero, siempre sera igual a 0

   T[] m_Items;

   public Stack():this(100)//constructor por defecto, manda a llamar al constructor donde especificamos 

   {}

   public Stack(int size) //constructor donde especificamos el tamaño del espacio, despues de que se inicializa el //valor no se puede cambiar 

   {

      m_Size = size;

      m_Items = new T[m_Size];

   }

   public void Push(T item) //metodo push, no nos regresa nada, y nos regresa algo, en este caso no hemos         // no hemos especificado

   {

      if(m_StackPointer >= m_Size) 

         throw new StackOverflowException();

      m_Items[m_StackPointer] = item;

      m_StackPointer++;

   }

   public T Pop()

   {

      m_StackPointer--;// es -- por que es menos uno por queremos el anterior 

      if(m_StackPointer >= 0) // si es mayor o igual a 0, corre 

      {

         return m_Items[m_StackPointer];

      }

      else

      {

         m_StackPointer = 0;

         throw new InvalidOperationException("Cannot pop an empty stack"); //si en el stack no hay nada te dira que //pila vacia 

      }

   }
 }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<String> nombres= new Stack<String>();
            nombres.Push("Juan");
            nombres.Pop;

           
        }
    }
}
