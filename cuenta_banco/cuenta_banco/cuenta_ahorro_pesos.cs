using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_banco
{
    class cuenta_ahorro_pesos
    {
        string titular;
        string dni;
        float dinero;

        public float Dinero { get => dinero; set => dinero = value; }
        public string Titular { get => titular; set => titular = value; }
        public string Dni { get => dni; set => dni = value; }

        void insercion(int monto)
        {
            dinero += monto;
        }
        void extraccion(int monto, TipoDeExtraccion tipo)
        {
            if(monto<=10000 && dinero - monto >= 0 && tipo==TipoDeExtraccion.CajeroAutomatico)
            {
                dinero -= monto;
                Console.WriteLine("Extraccion realizada con exito");
            }
            else
            {
                Console.WriteLine("No puede ese monto");
            }
        }
    }
}
