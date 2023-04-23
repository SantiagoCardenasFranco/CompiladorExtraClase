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
            Cache.AddLine(Line.Create(1, "$HolaMundo$  {"));
            Cache.AddLine(Line.Create(2, "(PGJ)* a + 2345, 9   / 5"));
            Cache.AddLine(Line.Create(3, "a = 1    a > b   a < c   d <> b  x <= y  w >= v  p == q"));
            Cache.AddLine(Line.Create(4, ""));
            Cache.AddLine(Line.Create(5, "@y@ @o@ @si@ @sino@ @finsi@ @entonces@ @escriba@ @lea@"));
            Cache.AddLine(Line.Create(6, "& #HGF3456"));
            Cache.AddLine(Line.Create(7, " \"Hola \\\"\""));
            Cache.AddLine(Line.Create(8, "final }"));

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

            if (Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
            {
                Console.WriteLine(component.ToString());
            }

            Console.ReadKey();

        }
    }
}
