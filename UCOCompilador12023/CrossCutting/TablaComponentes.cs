using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023.CrossCutting
{
    public class TablaComponentes
    {
        protected Dictionary<string, List<LexicalComponent>> Components = new Dictionary<string, List<LexicalComponent>>();

        public void Initialize()
        {
            Components.Clear();
        }

        public Dictionary<string, List<LexicalComponent>> GetComponents()
        {
            return Components;
        }

        public List<LexicalComponent> GetComponent(string lexema)
        {
            if (!Components.ContainsKey(lexema))
            {
                Components.Add(lexema, new List<LexicalComponent>());
            }
            return Components[lexema];
        }

        public void Add(LexicalComponent lexicalComponent)
        {
            if(lexicalComponent != null)
            {
                GetComponent(lexicalComponent.GetLexeme()).Add(lexicalComponent);
            }
        }

        public List<LexicalComponent> GetComponentsAsList()
        {
            List<LexicalComponent> returnList = new List<LexicalComponent> ();
            foreach (List<LexicalComponent> list in Components.Values)
            {
                returnList.AddRange(list);
            }
            return returnList;
        }
    }
}
