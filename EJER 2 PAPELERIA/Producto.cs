using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_2_PAPELERIA
{
   public class Producto
    {
        protected string codigo;
        protected string nombre;
        protected string marca;
        protected decimal precio;

        public virtual void Almacenar()
        {
            // Para almacenar los datos
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Marca: {marca}");
            Console.WriteLine($"Precio: {precio:C}");
        }
    }
}
