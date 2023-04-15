using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCOCompilador12023.LexicalAnalyzer
{
    public class LexicalComponent
    {
        private int LineNumber;
        private int InitialPosition;
        private int FinalPosition;
        private Category Category;
        private string Lexeme;

        public LexicalComponent(int lineNumber, int initialPosition, int finalPosition, Category category, string lexeme)
        {
            LineNumber = lineNumber;
            InitialPosition = initialPosition;
            FinalPosition = finalPosition;
            Category = category;
            Lexeme = lexeme;
        }

        public static LexicalComponent Create(int lineNumber, int initialPosition, int finalPosition, Category category, string lexeme)
        {
            return new LexicalComponent(lineNumber, initialPosition, finalPosition, category, lexeme);
        }

        public void SetLineNumber(int lineNumber)
        {
            LineNumber = lineNumber;
        }

        public void SetInitialPosition(int initialPosition)
        {
            InitialPosition = initialPosition;
        }

        public void SetFinalPosition(int finalPosition)
        {
            FinalPosition = finalPosition;
        }

        public void SetCategory(Category category)
        {
            Category = category;
        }

        public void SetLexeme(string lexeme)
        {
            Lexeme = lexeme;
        }

        public int GetLineNumber()
        {
            return LineNumber;
        }

        public int GetInitialPosition()
        {
            return InitialPosition;
        }

        public int GetFinalPosition()
        {
            return FinalPosition;
        }

        public Category GetCategory()
        {
            return Category;
        }

        public string GetLexeme()
        {
            return Lexeme;
        }
    }
}
