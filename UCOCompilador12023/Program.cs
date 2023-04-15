using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.DataCache;

namespace UCOCompilador12023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Precarga de datos
            Cache.AddLine(Line.Create(1, "Esta es una linea de prueba"));
            Cache.AddLine(Line.Create(2, "Esta es segunda lìnea"));
            Cache.AddLine(Line.Create(3, ""));
            Cache.AddLine(Line.Create(4, "final"));

            Scanner.Initialize();
            Scanner.ReadNextCharacter();

            while (!"}".Equals(Scanner.GetCurrentCharacter()))
            {
                if ("@FL@".Equals(Scanner.GetCurrentCharacter()))
                {
                    Scanner.LoadNextLine();
                } 
                else 
                { 
                    Console.WriteLine(Scanner.GetCurrentCharacter());
                    Scanner.ReadNextCharacter();
                }
            }

            Console.ReadKey();

        }
    }
}
