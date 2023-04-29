using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023.CrossCutting
{
    public class TablaSimbolos : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaSimbolos();

        private TablaSimbolos() 
        { 

        }

        public static TablaComponentes GetTablaSimbolos()
        {
            return INSTANCE;
        }

    }
}
