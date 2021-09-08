using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuenta_banco
{
    class cuenta_herencia
    {
        protected string titular;
        protected string dni;
        protected float dinero;

        public float Dinero { get => dinero; set => dinero = value; }
        public string Titular { get => titular; set => titular = value; }
        public string Dni { get => dni; set => dni = value; }

        public void insercion(int monto)
        {
            dinero += monto;
        }
        public virtual void extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (monto < 20000 && dinero - monto >= -5000 && tipo == TipoDeExtraccion.CajeroAutomatico)
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
    class corriente_dolares : cuenta_herencia
    {
        private DateTime ultima_extraccion;
        public override void extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (monto <= 200 && dinero - monto >= 0 && tipo == TipoDeExtraccion.CajeroAutomatico && ultima_extraccion.Date!=DateTime.Today.Date)
            {
                dinero -= monto;
                Console.WriteLine("Extraccion por cajero automatico realizada con exito");
            }
            if (dinero - monto >= 0 && tipo == TipoDeExtraccion.CajeroHumano)
            {
                Console.WriteLine("Extraccion realizada con exito");
            }
            else
            {
                Console.WriteLine("No puede ese monto");
            }
        }
    }
    class corriente_pesos : cuenta_herencia
    {
        public override void extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (monto < 20000 && dinero - monto >= -5000 && tipo == TipoDeExtraccion.CajeroAutomatico)
            {
                dinero -= monto;
                Console.WriteLine("Extraccion realizada con exito");
            }
            else if (dinero - monto >= 0 && tipo == TipoDeExtraccion.CajeroHumano)
            {
                Console.WriteLine("Extraccion realizada con exito");
            }
            else
            {
                Console.WriteLine("No puede ese monto");
            }
        }
    }
    class ahorro_pesos : cuenta_herencia
    {
        public override void extraccion(int monto, TipoDeExtraccion tipo)
        {
            if (monto < 10000 && dinero - monto >= 0 && tipo == TipoDeExtraccion.CajeroAutomatico)
            {
                dinero -= monto;
                Console.WriteLine("Extraccion realizada con exito");
            }
            else if (dinero - monto >= 0 && tipo == TipoDeExtraccion.CajeroHumano)
            {
                Console.WriteLine("Extraccion realizada con exito");
            }
            else
            {
                Console.WriteLine("No puede ese monto");
            }
        }
    }

}
