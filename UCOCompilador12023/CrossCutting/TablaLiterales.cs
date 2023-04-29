using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOCompilador12023.CrossCutting
{
    public class TablaLiterales : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaLiterales();

        private TablaLiterales()
        {

        }

        public static TablaComponentes GetTablaLiterales()
        {
            return INSTANCE;
        }

    }
}
