using System;
using System.Collections.Generic;

namespace cuenta_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            cuenta_herencia cuenta_Ahorro = new ahorro_pesos();
            cuenta_herencia cuenta_Dolares = new corriente_dolares();
            cuenta_herencia cuenta_Pesos = new corriente_pesos();

            List<cuenta_herencia> listado = new();

            listado.Add(cuenta_Ahorro);
            listado.Add(cuenta_Dolares);
            listado.Add(cuenta_Pesos);

            foreach (var item in listado)
            {
                item.insercion(50000);
            }
            Console.WriteLine("Extraccion por Cajero Automatico");
            foreach (var item in listado)
            {
                item.extraccion(10000, TipoDeExtraccion.CajeroAutomatico); ;
            }
            Console.WriteLine("Extraccion por Cajero Humano");
            foreach (var item in listado)
            {
                item.extraccion(10000, TipoDeExtraccion.CajeroHumano); ;
            }

        }
    }
}
