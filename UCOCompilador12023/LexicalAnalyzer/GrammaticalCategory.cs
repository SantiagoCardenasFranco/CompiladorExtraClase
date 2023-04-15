using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOCompilador12023.LexicalAnalyzer
{
    public class GrammaticalCategory
    {
        public static string TABULACION = "    ";
        public static string ESPACIO = " ";
        public static string CONCATENACION = "&";
        public static string COMENTARIO_UNA_LINEA = "#";
        public static string COMENTARIO_MULTILINEA = "#";
        public static string FIN_DEL_ARCHIVO = "}";
        public static string INICIO = "{";
        public static string FIN_DE_LINEA = "@FL@";
        public static string PARENTESIS_CIERRA = ")";
        public static string PARENTESIS_ABRE = "(";
        public static string CADENA_DE_TEXTO = "\"";
        public static string ASIGNACION = "=";
        public static string MAYOR_QUE = ">";
        public static string MENOR_QUE = "<";
        public static string DIFERENTE_QUE = "<>";
        public static string IGUAL_QUE = "==";
        public static string MAYOR_O_IGUAL = ">=";
        public static string MENOR_O_IGUAL = "<=";
        public static string SUMA = "+";
        public static string RESTA = "-";
        public static string MULTIPLICACION = "*";
        public static string DIVISION = "/";
    }
}
