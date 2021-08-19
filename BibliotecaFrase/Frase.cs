using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaFrase
{
    public class Frase
    {
        public static void SortedListCollection()
        {
            var letras = new[] { 'A', 'E', 'I', 'O', 'U' };

            Console.WriteLine("Introduce un texto: ");
            var text = Console.ReadLine().ToUpper();

            foreach (var v in letras)
            {
                var vocales = text.Count(x => x == v);
                Console.WriteLine($"Existen {vocales} vocales {v}");
            }
        }
     
        }
    }

