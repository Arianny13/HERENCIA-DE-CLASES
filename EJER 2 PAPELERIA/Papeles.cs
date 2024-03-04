using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJER_2_PAPELERIA
{
    public class Papeles : Producto
    {
        private string tipo;
        private string color;
        private string tamaño;

        public override void Almacenar()
        {
            base.Almacenar();            
            tipo = Console.ReadLine();
            color = Console.ReadLine();
            tamaño = Console.ReadLine();
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Tamaño: {tamaño}");
        }
    }
}
