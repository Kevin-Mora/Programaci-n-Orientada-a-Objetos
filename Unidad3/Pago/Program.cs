using System;
using System.Globalization;

namespace Pago
{
    interface IAutorizable
    {
        //no se necesita poner public, solo se pone el tipo de dato que va regresar 
        string autoriza(string PIN, string cuenta);
    }

    class Pago
    {
        //para poner el tipo de moneda
        public enum moneda {MXN , USD}
        public enum Tipo{Efectivo, TC}
        private double monto;
        private double tipoDeCambio;
        private string numTransaccion;

        private moneda tipoMoneda;
        private Tipo tipoPago;

        public Pago(string numTransaccion, Double monto):this(numTransaccion)
        {
           
        }

        public Pago(string numTransaccion, Double monto, Double tipoDeCambio, Moneda tipoMoneda, TimeoutException tipoPago )
        {
          this.numTransaccion= numTransaccion;
          this.monto=monto;
          this.tipoDeCambio= tipoDeCambio;
          this.tipoMoneda= tipoMoneda;
          this.tipoPago= Pago.Tipo.Efectivo;
          
        }
        
        public override ToString()
        {
            return String.Format("monto{0}{1} tipo:{2}", monto.ToString("C", CultureInfo.CurrentCulture), tipoMoneda, tipoPago);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pago p= new Pago("001",- 1234.56d);
            Pago p3= new Pago("003", 23.00d,Pago.moneda.USD, Pago.Tipo.Efectivo);
            Console.WriteLine(p);
            Console.WriteLine(p3);
        }
    }
}
