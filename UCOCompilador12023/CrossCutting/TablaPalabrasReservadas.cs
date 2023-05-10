using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023.CrossCutting
{
    public class TablaPalabrasReservadas : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaPalabrasReservadas();
        private static Dictionary<string, Category> PALABRAS_RESERVADAS = new Dictionary<string, Category>();

        static TablaPalabrasReservadas()
        {
            PALABRAS_RESERVADAS.Add("@y@", Category.Y);
            PALABRAS_RESERVADAS.Add("@o@", Category.O);
            PALABRAS_RESERVADAS.Add("@escriba@", Category.IMPRIMA);
            PALABRAS_RESERVADAS.Add("@lea@", Category.INPUT);
            PALABRAS_RESERVADAS.Add("@si@", Category.SI);
            PALABRAS_RESERVADAS.Add("@sino@", Category.SINO);
            PALABRAS_RESERVADAS.Add("@finsi@", Category.FINSI);
            PALABRAS_RESERVADAS.Add("@entonces@", Category.ENTONCES);
        }

        private TablaPalabrasReservadas()
        {
            
        }

        public static TablaComponentes GetTablaPalabrasReservadas()
        {
            return INSTANCE;
        }

        public static LexicalComponent ComprobarComponent(LexicalComponent component)
        {
            if (component != null && ComponentType.NORMAL.Equals(component.componentType) && PALABRAS_RESERVADAS.ContainsKey(component.GetLexeme()))
            {
                return LexicalComponent.CreatePalabraReservadaComponent(component.GetLineNumber(),
                    component.GetInitialPosition(), component.GetFinalPosition(),
                    PALABRAS_RESERVADAS[component.GetLexeme()], component.GetLexeme());
            }
            else
            {
                return component;
            }
        }
    }
}
