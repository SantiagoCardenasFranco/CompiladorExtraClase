using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.CrossCutting;
using UCOCompilador12023.DataCache;
using UCOCompilador12023.ErrorManager;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023
{
    class Program
    {
        static void Main(string[] args)
        {
            // Precarga de datos
            //Cache.AddLine(Line.Create(1, "$HolaMundo$  {"));
            Cache.AddLine(Line.Create(1, "(PGJ2)* a + 2345,a 9  ~  / 5"));
            //Cache.AddLine(Line.Create(3, "a = 1    a > b   a < c   d <> b  x <= y  w >= v  p == q"));
            //Cache.AddLine(Line.Create(4, ""));
            //Cache.AddLine(Line.Create(5, "@y@ @o@ @si@ @sino@ @finsi@ @entonces@ @escriba@ @lea@"));
            ///Cache.AddLine(Line.Create(6, "& #HGF3456"));
            //Cache.AddLine(Line.Create(7, " \"Hola \\\"\""));
            //Cache.AddLine(Line.Create(8, "final }"));

            LexicalAnalysis.Initialize();

            try
            {

                LexicalComponent component = LexicalAnalysis.Analyze();
                while (!Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
                {
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

                /*if (Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
                {
                    Console.WriteLine(component.ToString());
                }*/
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡¡¡ERROR DE COMPILACIÓN!!!");
                Console.WriteLine(ex.Message);
            }
            if(TablaMaestra.GetComponentsAsList(ComponentType.NORMAL).Count > 0)
            {
                Console.WriteLine("Simbolos: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.NORMAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            else if (TablaMaestra.GetComponentsAsList(ComponentType.LITERAL).Count > 0)
            {
                Console.WriteLine("Literales: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.LITERAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            else if (TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA).Count > 0)
            {
                Console.WriteLine("Palabras reservadas: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            else if (TablaMaestra.GetComponentsAsList(ComponentType.DUMMY).Count > 0)
            {
                Console.WriteLine("Dummies: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.DUMMY))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }                

            if (ErrorManagement.HayErrores())
            {
                Console.WriteLine("_________________________________________________________________");
                Console.WriteLine("LISTADO DE ERRORES LÉXICOS");
                Console.WriteLine("_________________________________________________________________");

                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    Console.WriteLine(error.ToString());
                    Console.WriteLine("_________________________________________________________________");
                }
            }
 

           

            Console.ReadKey();

        }
    }
}
