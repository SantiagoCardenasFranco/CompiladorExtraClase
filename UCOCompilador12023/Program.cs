using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.DataCache;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Precarga de datos
            Cache.AddLine(Line.Create(1, "(PGJ)* a + 2345,9"));
            Cache.AddLine(Line.Create(2, "    4567         - Otra"));
            Cache.AddLine(Line.Create(3, ""));
            Cache.AddLine(Line.Create(4, "final"));

            Scanner.Initialize();
            Scanner.ReadNextCharacter();

            LexicalAnalysis.Initialize();
            LexicalComponent component = LexicalAnalysis.Analyze(); 

            while (!Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
            {
                Console.WriteLine(component.ToString());
                component = LexicalAnalysis.Analyze();
                /*if ("@FL@".Equals(Scanner.GetCurrentCharacter()))
                {
                    Scanner.LoadNextLine();
                } 
                else 
                { 
                    Console.WriteLine(Scanner.GetCurrentCharacter());
                    Scanner.ReadNextCharacter();
                }*/
            }

            Console.ReadKey();

        }
    }
}
