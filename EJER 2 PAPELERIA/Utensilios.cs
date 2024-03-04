using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_2_PAPELERIA
{
     public class Utensilios : Producto
     {
        private string categoria;
        private decimal peso;

        public override void Almacenar()
        {
            base.Almacenar();           
            categoria = Console.ReadLine();
            peso = Convert.ToDecimal(Console.ReadLine());
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Categoría: {categoria}");
            Console.WriteLine($"Peso: {peso}");
        }
    }

}
