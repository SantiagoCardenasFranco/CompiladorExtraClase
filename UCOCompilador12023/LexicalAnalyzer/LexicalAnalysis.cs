using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.DataCache;
using UCOCompilador12023.ErrorManager;

namespace UCOCompilador12023.LexicalAnalyzer
{
    public class LexicalAnalysis
    {
        private readonly static LexicalAnalysis INSTANCE = new LexicalAnalysis();
        private int CurrentState;
        private string Lexeme;
        private bool Continue;
        private LexicalComponent Component;

        public static void Initialize()
        {
            Scanner.Initialize();
        }

        private static void Restart()
        {
            INSTANCE.CurrentState = 0;
            INSTANCE.Lexeme = "";
            INSTANCE.Continue = true;
        }

        private static void Restart(int state)
        {
            INSTANCE.CurrentState = state;
            INSTANCE.Lexeme = "";
            INSTANCE.Continue = true;
        }

        private static void Concanate()
        {
            INSTANCE.Lexeme = INSTANCE.Lexeme + Scanner.GetCurrentCharacter();
        }

        private static void Concanate(string character)
        {
            INSTANCE.Lexeme = INSTANCE.Lexeme + character;
        }

        private static void returnData()
        {
            String returnValue = Scanner.GetCurrentCharacter();
        }

        private static void loadNextLine()
        {
            Scanner.LoadNextLine();
        }

        private static void DevourBlankCharacter()
        {
            Scanner.ReadNextCharacter();

            while(" ".Equals(Scanner.GetCurrentCharacter()))
            {
                Scanner.ReadNextCharacter();
            }
        }


        public static LexicalComponent Analyze()
        {
            Restart();
            

            while (INSTANCE.Continue)
            {
                if(INSTANCE.CurrentState == 0)
                {
                    ProcessState0();
                }
                else if(INSTANCE.CurrentState == 1)
                {
                    ProcessState1();
                }
                else if (INSTANCE.CurrentState == 2)
                {
                    ProcessState2();
                }
                else if (INSTANCE.CurrentState == 3)
                {
                    ProcessState3();
                }
                else if (INSTANCE.CurrentState == 4)
                {
                    ProcessState4();
                }
                else if (INSTANCE.CurrentState == 5)
                {
                    ProcessState5();
                }
                else if (INSTANCE.CurrentState == 6)
                {
                    ProcessState6();
                }
                else if (INSTANCE.CurrentState == 7)
                {
                    ProcessState7();
                }
                else if (INSTANCE.CurrentState == 8)
                {
                    ProcessState8();
                }
                else if (INSTANCE.CurrentState == 9)
                {
                    ProcessState9();
                }
                else if (INSTANCE.CurrentState == 10)
                {
                    ProcessState10();
                }
                else if (INSTANCE.CurrentState == 11)
                {
                    ProcessState11();
                }
                else if (INSTANCE.CurrentState == 12)
                {
                    ProcessState12();
                }
                else if (INSTANCE.CurrentState == 13)
                {
                    ProcessState13();
                }
                else if (INSTANCE.CurrentState == 14)
                {
                    ProcessState14();
                }
                else if (INSTANCE.CurrentState == 15)
                {
                    ProcessState15();
                }
                else if (INSTANCE.CurrentState == 16)
                {
                    ProcessState16();
                }
                else if (INSTANCE.CurrentState == 18)
                {
                    ProcessState18();
                }
                else if (INSTANCE.CurrentState == 19)
                {
                    ProcessState19();
                }
                else if (INSTANCE.CurrentState == 20)
                {
                    ProcessState20();
                }
                else if (INSTANCE.CurrentState == 21)
                {
                    ProcessState21();
                }
                else if (INSTANCE.CurrentState == 22)
                {
                    ProcessState22();
                }
                else if (INSTANCE.CurrentState == 23)
                {
                    ProcessState23();
                }
                else if (INSTANCE.CurrentState == 24)
                {
                    ProcessState24();
                }
                else if (INSTANCE.CurrentState == 25)
                {
                    ProcessState25();
                }
                else if (INSTANCE.CurrentState == 26)
                {
                    ProcessState26();
                }
                else if (INSTANCE.CurrentState == 27)
                {
                    ProcessState27();
                }
                else if (INSTANCE.CurrentState == 28)
                {
                    ProcessState28();
                }
                else if (INSTANCE.CurrentState == 29)
                {
                    ProcessState29();
                }
                else if (INSTANCE.CurrentState == 30)
                {
                    ProcessState30();
                }
                else if (INSTANCE.CurrentState == 31)
                {
                    ProcessState31();
                }
                else if (INSTANCE.CurrentState == 32)
                {
                    ProcessState32();
                }
                else if (INSTANCE.CurrentState == 33)
                {
                    ProcessState33();
                }
                else if (INSTANCE.CurrentState == 34)
                {
                    ProcessState34();
                }
                else if (INSTANCE.CurrentState == 35)
                {
                    ProcessState35();
                }
                else if (INSTANCE.CurrentState == 36)
                {
                    ProcessState36();
                }
                else if (INSTANCE.CurrentState == 37)
                {
                    ProcessState37();
                }
                else if (INSTANCE.CurrentState == 38)
                {
                    ProcessState38();
                }
                else if (INSTANCE.CurrentState == 39)
                {
                    ProcessState39();
                }
                else if (INSTANCE.CurrentState == 42)
                {
                    ProcessState42();
                }
                else if (INSTANCE.CurrentState == 43)
                {
                    ProcessState43();
                }
                else if (INSTANCE.CurrentState == 44)
                {
                    ProcessState44();
                }
                else if (INSTANCE.CurrentState == 45)
                {
                    ProcessState45();
                }
                else if (INSTANCE.CurrentState == 46)
                {
                    ProcessState46();
                }
                else if (INSTANCE.CurrentState == 47)
                {
                    ProcessState47();
                }
                else if (INSTANCE.CurrentState == 48)
                {
                    ProcessState48();
                }
                else if (INSTANCE.CurrentState == 49)
                {
                    ProcessState49();
                }
                else if (INSTANCE.CurrentState == 50)
                {
                    ProcessState50();
                }
                else if (INSTANCE.CurrentState == 51)
                {
                    ProcessState51();
                }
                else if (INSTANCE.CurrentState == 52)
                {
                    ProcessState52();
                }
                else if (INSTANCE.CurrentState == 53)
                {
                    ProcessState53();
                }
                else if (INSTANCE.CurrentState == 55)
                {
                    ProcessState55();
                }
                else if (INSTANCE.CurrentState == 56)
                {
                    ProcessState56();
                }
                else if (INSTANCE.CurrentState == 57)
                {
                    ProcessState57();
                }
                else if (INSTANCE.CurrentState == 58)
                {
                    ProcessState58();
                }
                else if (INSTANCE.CurrentState == 59)
                {
                    ProcessState59();
                }
                else if (INSTANCE.CurrentState == 60)
                {
                    ProcessState60();
                }
                else if (INSTANCE.CurrentState == 61)
                {
                    ProcessState61();
                }
                else if (INSTANCE.CurrentState == 62)
                {
                    ProcessState62();
                }
                else if (INSTANCE.CurrentState == 63)
                {
                    ProcessState63();
                }
                else if (INSTANCE.CurrentState == 64)
                {
                    ProcessState64();
                }
                else if (INSTANCE.CurrentState == 65)
                {
                    ProcessState65();
                }
                else if (INSTANCE.CurrentState == 66)
                {
                    ProcessState66();
                }
                else if (INSTANCE.CurrentState == 69)
                {
                    ProcessState69();
                }
                else if (INSTANCE.CurrentState == 70)
                {
                    ProcessState70();
                }
                else if (INSTANCE.CurrentState == 71)
                {
                    ProcessState71();
                }
                else if (INSTANCE.CurrentState == 72)
                {
                    ProcessState72();
                }
                else if (INSTANCE.CurrentState == 73)
                {
                    ProcessState73();
                }
                else if (INSTANCE.CurrentState == 74)
                {
                    ProcessState74();
                }
                else if (INSTANCE.CurrentState == 75)
                {
                    ProcessState75();
                }
                else if (INSTANCE.CurrentState == 77)
                {
                    ProcessState77();
                }
                else if (INSTANCE.CurrentState == 78)
                {
                    ProcessState78();
                }
                else if (INSTANCE.CurrentState == 79)
                {
                    ProcessState79();
                }
                else if(INSTANCE.CurrentState == 80)
                {
                    ProcessState80();
                }
                else if (INSTANCE.CurrentState == 81)
                {
                    ProcessState81();
                }
                else if (INSTANCE.CurrentState == 82)
                {
                    ProcessState82();
                }
                else if (INSTANCE.CurrentState == 83)
                {
                    ProcessState83();
                }
                else if (INSTANCE.CurrentState == 84)
                {
                    ProcessState84();
                }
                else if (INSTANCE.CurrentState == 85)
                {
                    ProcessState85();
                }
                else if (INSTANCE.CurrentState == 86)
                {
                    ProcessState86();
                }
                else if (INSTANCE.CurrentState == 87)
                {
                    ProcessState87();
                }
                else if (INSTANCE.CurrentState == 88)
                {
                    ProcessState88();
                }
                else if (INSTANCE.CurrentState == 89)
                {
                    ProcessState89();
                }
                else if (INSTANCE.CurrentState == 90)
                {
                    ProcessState90();
                }
                else if (INSTANCE.CurrentState == 91)
                {
                    ProcessState91();
                }
                else if (INSTANCE.CurrentState == 92)
                {
                    ProcessState92();
                }
                else if (INSTANCE.CurrentState == 93)
                {
                    ProcessState93();
                }
                else if (INSTANCE.CurrentState == 94)
                {
                    ProcessState94();
                }
                else if (INSTANCE.CurrentState == 95)
                {
                    ProcessState95();
                }
                else if (INSTANCE.CurrentState == 96)
                {
                    ProcessState96();
                }
                else if (INSTANCE.CurrentState == 97)
                {
                    ProcessState97();
                }
                else if (INSTANCE.CurrentState == 98)
                {
                    ProcessState98();
                }
                else if (INSTANCE.CurrentState == 99)
                {
                    ProcessState99();
                }
                else if (INSTANCE.CurrentState == 100)
                {
                    ProcessState100();
                }
                else if (INSTANCE.CurrentState == 101)
                {
                    ProcessState101();
                }
                else if (INSTANCE.CurrentState == 102)
                {
                    ProcessState102();
                }
                else if (INSTANCE.CurrentState == 103)
                {
                    ProcessState103();
                }
                else if (INSTANCE.CurrentState == 104)
                {
                    ProcessState104();
                }
                else if (INSTANCE.CurrentState == 106)
                {
                    ProcessState106();
                }
                else if (INSTANCE.CurrentState == 107)
                {
                    ProcessState107();
                }
                else if (INSTANCE.CurrentState == 108)
                {
                    ProcessState108();
                }
                else if (INSTANCE.CurrentState == 109)
                {
                    ProcessState109();
                }
                else if (INSTANCE.CurrentState == 110)
                {
                    ProcessState110();
                }
                else if (INSTANCE.CurrentState == 111)
                {
                    ProcessState111();
                }
                else if (INSTANCE.CurrentState == 112)
                {
                    ProcessState112();
                }
                else if (INSTANCE.CurrentState == 113)
                {
                    ProcessState113();
                }
                else if (INSTANCE.CurrentState == 114)
                {
                    ProcessState114();
                }
                else if (INSTANCE.CurrentState == 115)
                {
                    ProcessState115();
                }
                else if (INSTANCE.CurrentState == 116)
                {
                    ProcessState116();
                }
                else if (INSTANCE.CurrentState == 117)
                {
                    ProcessState117();
                }
            }

            return INSTANCE.Component;
        }

        private static void ProcessState0()
        {
            DevourBlankCharacter();
            if(IsLetter())
            {
                Concanate();
                INSTANCE.CurrentState = 1;
            }
            else if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 3;
            }
            else if (IsSubtration())
            {
                Concanate();
                INSTANCE.CurrentState = 9;
            }
            else if (IsMultiplicationtion())
            {
                Concanate();
                INSTANCE.CurrentState = 10;
            }
            else if (IsDivision())
            {
                Concanate();
                INSTANCE.CurrentState = 11;
            }
            else if (IsOpenparenthesis())
            {
                Concanate();
                INSTANCE.CurrentState = 12;
            }
            else if (IsCloseparenthesis())
            {
                Concanate();
                INSTANCE.CurrentState = 13;
            }
            else if (IsEndLine())
            {
                Concanate();
                INSTANCE.CurrentState = 19;
            }
            else if (IsComment())
            {
                Concanate();
                INSTANCE.CurrentState = 31;
            }
            else if (IsSmallerThan())
            {
                Concanate();
                INSTANCE.CurrentState = 21;
            }
            else if (IsGreaterThan())
            {
                Concanate();
                INSTANCE.CurrentState = 23;
            }
            else if(IsEqual())
            {
                Concanate();
                INSTANCE.CurrentState = 26;
            }
            else if (IsQuotationMarks())
            {
                Concanate();
                INSTANCE.CurrentState = 30;
            }
            else if (IsAddition())
            {
                Concanate();
                INSTANCE.CurrentState = 37;
            }
            else if (IsCurrency())
            {
                Concanate();
                INSTANCE.CurrentState = 56;
            }
            else if (IsConcate())
            {
                Concanate();
                INSTANCE.CurrentState = 81;
            }
            else if (IsStartFile())
            {
                Concanate();
                INSTANCE.CurrentState = 50;
            }
            else if (IsEndFile())
            {
                Concanate();
                INSTANCE.CurrentState = 20;
            }
            else if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 14;
            }
            else if (IsBlankSpaces() || IsTab())
            {
                INSTANCE.CurrentState = 0;
            } 
            else
            {
                INSTANCE.CurrentState = 36;
            }
        }

        private static void ProcessState1()
        {
            Scanner.ReadNextCharacter();
            if (IsLetter())
            {
                Concanate();
                INSTANCE.CurrentState = 1;
            }
            else
            {
                INSTANCE.CurrentState = 2;
            }
        }

        private static void ProcessState2()
        {
            CreateComponentReturningIndex(Category.IDENTIFICADOR, ComponentType.NORMAL);
        }

        private static void ProcessState3()
        {
            Scanner.ReadNextCharacter();
            if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 3;
            }
            else if(IsComa())
            {
                Concanate();
                INSTANCE.CurrentState = 5;
            }
            else
            {
                INSTANCE.CurrentState = 4;
            }
        }

        private static void ProcessState4()
        {
            //Retorna entero, devuelve puntero
            CreateComponentReturningIndex(Category.ENTERO, ComponentType.NORMAL);
        }

        private static void ProcessState5()
        {
            Scanner.ReadNextCharacter();
            if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 6;
            }
            else
            {
                INSTANCE.CurrentState = 8;
            }
        }

        private static void ProcessState6()
        {
            Scanner.ReadNextCharacter();
            if (IsDigit())
            {
                Concanate();
                INSTANCE.CurrentState = 6;
            }
            else
            {
                INSTANCE.CurrentState = 7;
            }
        }

        private static void ProcessState7()
        {
            //Retorno decimal, devuelve puntero
            CreateComponentReturningIndex(Category.DECIMAL, ComponentType.NORMAL);
        }

        private static void ProcessState8()
        {
            //Error no decimal competo
            string fail = "Número decimal no válido...";
            string cause = "Se ha recibido un caracter que no corresponde a un digito";
            string solution = "Asegúrese de que luego del separador decimal, contiene un dígito";
            CreateLexicalError(ErrorType.CONTROLABLE, fail, cause, solution, Category.DECIMAL, 
                INSTANCE.Lexeme + Scanner.GetCurrentCharacter());

            Concanate("0");
            CreateComponentReturningIndex(Category.DECIMAL, ComponentType.DUMMY);


        }

        private static void ProcessState9()
        {
            //Retorno resta
            CreateComponentWithoutReturningIndex(Category.RESTA, ComponentType.NORMAL);
        }

        private static void ProcessState10()
        {
            //Retorno multiplicación
            CreateComponentWithoutReturningIndex(Category.MULTIPLICACION, ComponentType.NORMAL);
        }

        private static void ProcessState11()
        {
            //Retorno división 
            CreateComponentWithoutReturningIndex(Category.DIVISION, ComponentType.NORMAL);
        }

        private static void ProcessState12()
        {
            //Retorno parentesis abre
            CreateComponentWithoutReturningIndex(Category.PARENTESIS_ABRE, ComponentType.NORMAL);
        }

        private static void ProcessState13()
        {
            //Retorno parentesis cierra
            CreateComponentWithoutReturningIndex(Category.PARENTESIS_CIERRA, ComponentType.NORMAL);
        }

        private static void ProcessState14()
        {
            Scanner.ReadNextCharacter();
            if (IsY())
            {
                Concanate();
                INSTANCE.CurrentState = 15;
            }
            else if (IsO())
            {
                Concanate();
                INSTANCE.CurrentState = 18;
            }
            else if (IsS())
            {
                Concanate();
                INSTANCE.CurrentState = 29;
            }
            else if (IsF())
            {
                Concanate();
                INSTANCE.CurrentState = 45;
            }
            else if (IsE())
            {
                Concanate();
                INSTANCE.CurrentState = 55;
            }
            else if (IsL())
            {
                Concanate();
                INSTANCE.CurrentState = 77;
            }
            else
            {
                INSTANCE.CurrentState = 82;
            }
        }

        private static void ProcessState15()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 16;
            }
            else
            {
                INSTANCE.CurrentState = 86;
            }
        }

        private static void ProcessState16()
        {
            //Retorno y lógico
            CreateComponentWithoutReturningIndex(Category.Y, ComponentType.NORMAL);
        }

        private static void ProcessState18()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 25;
            }
            else
            {
                INSTANCE.CurrentState = 87;
            }
        }

        private static void ProcessState19()
        {
            Scanner.LoadNextLine();
            Restart();
        }

        private static void ProcessState20()
        {
            //Retorno fin del archivo
            CreateComponentWithoutReturningIndex(Category.FIN_DE_ARCHIVO, ComponentType.NORMAL);
        }

        private static void ProcessState21()
        {
            Scanner.ReadNextCharacter();
            if (IsEqual())
            {
                Concanate();
                INSTANCE.CurrentState = 28;
            }
            else if(IsGreaterThan()) 
            {
                Concanate();
                INSTANCE.CurrentState = 52;
            }
            else
            {
                INSTANCE.CurrentState = 22;
            }
        }
        private static void ProcessState22()
        {
            //Retorno menor que, devuelve puntero
            CreateComponentReturningIndex(Category.MENOR_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState23()
        {
            Scanner.ReadNextCharacter();
            if (IsEqual())
            {
                Concanate();
                INSTANCE.CurrentState = 51;
            }
            else
            {
                INSTANCE.CurrentState = 24;

            }
        }
        private static void ProcessState24()
        {
            //Retorno mayor que, devuelve puntero
            CreateComponentReturningIndex(Category.MAYOR_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState25()
        {
            //Retorna o lógico
            CreateComponentWithoutReturningIndex(Category.O, ComponentType.NORMAL);
        }

        private static void ProcessState26()
        {
            Scanner.ReadNextCharacter();
            if (IsEqual())
            {
                Concanate();
                INSTANCE.CurrentState = 58;
            }
            else
            {
                INSTANCE.CurrentState = 27; 
            }
        }

        private static void ProcessState27()
        {
            //Retorna asignación, devuelve puntero
            CreateComponentReturningIndex(Category.ASIGNACION, ComponentType.NORMAL);
        }

        private static void ProcessState28()
        {
            //Retorno menor o igual
            CreateComponentWithoutReturningIndex(Category.MENOR_IGUAL_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState29()
        {
            Scanner.ReadNextCharacter();
            if (IsI())
            {
                Concanate();
                INSTANCE.CurrentState = 38;
            }
            else
            {
                INSTANCE.CurrentState = 88;
            }
        }

        private static void ProcessState30()
        {
            Scanner.ReadNextCharacter();
            if (IsQuotationMarks())
            {
                Concanate();
                INSTANCE.CurrentState = 35;
            }
            else if (IsBackSlash())
            {
                Concanate();
                INSTANCE.CurrentState = 85;
            }
            else if(IsEndLine())
            {
                INSTANCE.CurrentState = 117;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState= 30;
            }
        }

        private static void ProcessState31()
        {
            Scanner.ReadNextCharacter();
            //Se come los comentarios?
            if (IsComment())
            {
                Concanate();
                INSTANCE.CurrentState = 33;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 34;
            }
        }

        private static void ProcessState32()
        {
            Scanner.ReadNextCharacter();
            if (IsEndLine())
            {
                Concanate();
                INSTANCE.CurrentState = 116;
            }
            else if (IsComment())
            {
                Concanate();
                INSTANCE.CurrentState = 0;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 33;
            }
        }

        private static void ProcessState33()
        {
            Scanner.ReadNextCharacter();
            if (IsEndLine())
            {
                INSTANCE.CurrentState = 83;
            }
            else if (IsComment())
            {
                Concanate();
                INSTANCE.CurrentState = 32;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 33;
            }
        }

        private static void ProcessState34()
        {
            Scanner.ReadNextCharacter();
            if (IsEndLine())
            {
                CreateComponentWithoutReturningIndex(Category.COMENTARIO_UNA_LINEA, ComponentType.NORMAL);
                INSTANCE.CurrentState = 19;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 34;
            }
        }

        private static void ProcessState35()
        {
            //Retorna cadena de texto
            CreateComponentWithoutReturningIndex(Category.CADENA_DE_TEXTO, ComponentType.NORMAL);
        }

        private static void ProcessState36()
        {
            //Retorna error stopper
            string fail = "Componente léxico no válido...";
            string cause = "Se ha recibido un simbolo desconocido por el lenguaje...";
            string solution = "Asegúrese de que solo existan símbolos aceptados por el lenguaje.";
            CreateLexicalError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                INSTANCE.Lexeme + Scanner.GetCurrentCharacter());

        }

        private static void ProcessState37()
        {
            //Retorna suma
            CreateComponentWithoutReturningIndex(Category.SUMA, ComponentType.NORMAL);
        }

        private static void ProcessState38()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 39;
            }
            else if (IsN())
            {
                Concanate();
                INSTANCE.CurrentState = 42;
            }
            else
            {
                INSTANCE.CurrentState = 89;
            }
        }

        private static void ProcessState39()
        {
            //Retorno si lógico
            CreateComponentWithoutReturningIndex(Category.SI, ComponentType.NORMAL);
        }

        private static void ProcessState42()
        {
            Scanner.ReadNextCharacter();
            if (IsO())
            {
                Concanate();
                INSTANCE.CurrentState = 43;
            }
            else
            {
                INSTANCE.CurrentState = 90;
            }
        }

        private static void ProcessState43()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 44;
            }
            else
            {
                INSTANCE.CurrentState = 91;
            }
        }

        private static void ProcessState44()
        {
            //Retorno sino lógico
            CreateComponentWithoutReturningIndex(Category.SINO, ComponentType.NORMAL);
        }

        private static void ProcessState45()
        {
            Scanner.ReadNextCharacter();
            if (IsI())
            {
                Concanate();
                INSTANCE.CurrentState = 46;
            }
            else
            {
                INSTANCE.CurrentState = 92;
            }
        }

        private static void ProcessState46()
        {
            Scanner.ReadNextCharacter();
            if (IsN())
            {
                Concanate();
                INSTANCE.CurrentState = 47;
            }
            else
            {
                INSTANCE.CurrentState = 93;
            }
        }

        private static void ProcessState47()
        {
            Scanner.ReadNextCharacter();
            if (IsS())
            {
                Concanate();
                INSTANCE.CurrentState = 48;
            }
            else
            {
                INSTANCE.CurrentState = 94;
            }
        }

        private static void ProcessState48()
        {
            Scanner.ReadNextCharacter();
            if (IsI())
            {
                Concanate();
                INSTANCE.CurrentState = 49;
            }
            else
            {
                INSTANCE.CurrentState = 95;
            }
        }

        private static void ProcessState49()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 53;
            }
            else
            {
                INSTANCE.CurrentState = 96;
            }
        }

        private static void ProcessState50()
        {
            //Retorna inicio archivo
            CreateComponentWithoutReturningIndex(Category.INICIO_ARCHIVO, ComponentType.NORMAL);
        }

        private static void ProcessState51()
        {
            //Retorna mayor o igual
            CreateComponentWithoutReturningIndex(Category.MAYOR_IGUAL_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState52()
        {
            //Retorna diferente que
            CreateComponentWithoutReturningIndex(Category.DIFERENTE_QUE, ComponentType.NORMAL);

        }

        private static void ProcessState53()
        {
            //Retorna fin si lógico
            CreateComponentWithoutReturningIndex(Category.FINSI, ComponentType.NORMAL);
        }

        private static void ProcessState55()
        {
            Scanner.ReadNextCharacter();
            if (IsN())
            {
                Concanate();
                INSTANCE.CurrentState = 59;
            }
            else if (IsS())
            {
                Concanate();
                INSTANCE.CurrentState = 69;
            }
            else
            {
                INSTANCE.CurrentState = 97;
            }
        }

        private static void ProcessState56()
        {
            Scanner.ReadNextCharacter();
            if (IsCurrency())
            {
                Concanate();
                INSTANCE.CurrentState = 57;
            }
            else if (IsEndLine())
            {
                INSTANCE.CurrentState = 115;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 56;
            }
        }

        private static void ProcessState57()
        {
            //Retorna nombre del programa
            CreateComponentWithoutReturningIndex(Category.NOMBREPROGRAMA, ComponentType.NORMAL);
        }

        private static void ProcessState58()
        {
            //Retorna igual que
            CreateComponentWithoutReturningIndex(Category.IGUAL_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState59()
        {
            Scanner.ReadNextCharacter();
            if (IsT())
            {
                Concanate();
                INSTANCE.CurrentState = 60;
            }
            else
            {
                INSTANCE.CurrentState = 98;
            }
        }

        private static void ProcessState60()
        {
            Scanner.ReadNextCharacter();
            if (IsO())
            {
                Concanate();
                INSTANCE.CurrentState = 61;
            }
            else
            {
                INSTANCE.CurrentState = 98;
            }
        }

        private static void ProcessState61()
        {
            Scanner.ReadNextCharacter();
            if (IsN())
            {
                Concanate();
                INSTANCE.CurrentState = 62;
            }
            else
            {
                INSTANCE.CurrentState = 100;
            }
        }

        private static void ProcessState62()
        {
            Scanner.ReadNextCharacter();
            if (IsC())
            {
                Concanate();
                INSTANCE.CurrentState = 63;
            }
            else
            {
                INSTANCE.CurrentState = 101;
            }
        }

        private static void ProcessState63()
        {
            Scanner.ReadNextCharacter();
            if (IsE())
            {
                Concanate();
                INSTANCE.CurrentState = 64;
            }
            else
            {
                INSTANCE.CurrentState = 102;
            }
        }

        private static void ProcessState64()
        {
            Scanner.ReadNextCharacter();
            if (IsS())
            {
                Concanate();
                INSTANCE.CurrentState = 65;
            }
            else
            {
                INSTANCE.CurrentState = 103;
            }
        }

        private static void ProcessState65()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 66;
            }
            else
            {
                INSTANCE.CurrentState = 104;
            }
        }

        private static void ProcessState66()
        {
            //Retorna entonces lógico
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.NORMAL);
        }

        private static void ProcessState69()
        {
            Scanner.ReadNextCharacter();
            if (IsC())
            {
                Concanate();
                INSTANCE.CurrentState = 70;
            }
            else
            {
                INSTANCE.CurrentState = 106;
            }
        }

        private static void ProcessState70()
        {
            Scanner.ReadNextCharacter();
            if (IsR())
            {
                Concanate();
                INSTANCE.CurrentState = 71;
            }
            else
            {
                INSTANCE.CurrentState = 107;
            }
        }

        private static void ProcessState71()
        {
            Scanner.ReadNextCharacter();
            if (IsI())
            {
                Concanate();
                INSTANCE.CurrentState = 72;
            }
            else
            {
                INSTANCE.CurrentState = 108;
            }
        }

        private static void ProcessState72()
        {
            Scanner.ReadNextCharacter();
            if (IsB())
            {
                Concanate();
                INSTANCE.CurrentState = 73;
            }
            else
            {
                INSTANCE.CurrentState = 109;
            }
        }

        private static void ProcessState73()
        {
            Scanner.ReadNextCharacter();
            if (IsA())
            {
                Concanate();
                INSTANCE.CurrentState = 74;
            }
            else
            {
                INSTANCE.CurrentState = 110;
            }
        }

        private static void ProcessState74()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 75;
            }
            else
            {
                INSTANCE.CurrentState = 111;
            }
        }

        private static void ProcessState75()
        {
            //Retorna imprima
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.NORMAL);
        }

        private static void ProcessState77()
        {
            Scanner.ReadNextCharacter();
            if (IsE())
            {
                Concanate();
                INSTANCE.CurrentState = 78;
            }
            else
            {
                INSTANCE.CurrentState = 112;
            }
        }

        private static void ProcessState78()
        {
            Scanner.ReadNextCharacter();
            if (IsA())
            {
                Concanate();
                INSTANCE.CurrentState = 79;
            }
            else
            {
                INSTANCE.CurrentState = 113;
            }
        }

        private static void ProcessState79()
        {
            Scanner.ReadNextCharacter();
            if (IsAtSign())
            {
                Concanate();
                INSTANCE.CurrentState = 80;
            }
            else
            {
                INSTANCE.CurrentState = 114;
            }
        }

        private static void ProcessState80()
        {
            //Retorna input
            CreateComponentWithoutReturningIndex(Category.INPUT, ComponentType.NORMAL);
        }

        private static void ProcessState81()
        {
            //Retorna concatenación
            CreateComponentWithoutReturningIndex(Category.CONCATENACION, ComponentType.NORMAL);
        }

        //Revisar--------------------------------------------------------------------------------------------
        private static void ProcessState82()
        {
            //Error no condición competa
            Concanate("y");
            CreateComponentReturningIndex(Category.Y, ComponentType.DUMMY);
        }

        private static void ProcessState83()
        {
            Scanner.LoadNextLine();
            Restart(33);
        }

        private static void ProcessState84()
        {
            Scanner.ReadNextCharacter();
            if (IsBackSlash())
            {
                Concanate();
                INSTANCE.CurrentState = 85;
            }
            else if (IsQuotationMarks())
            {
                Concanate();
                INSTANCE.CurrentState = 35;
            }
            else if (IsEndLine())
            {
                INSTANCE.CurrentState = 117;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 30;
            }
        }

        private static void ProcessState85()
        {
            Scanner.ReadNextCharacter();
            if (IsBackSlash())
            {
                Concanate();
                INSTANCE.CurrentState = 85;
            }
            else if (IsQuotationMarks())
            {
                Concanate();
                INSTANCE.CurrentState = 84;
            }
            else if (IsEndLine())
            {
                INSTANCE.CurrentState = 117;
            }
            else
            {
                Concanate();
                INSTANCE.CurrentState = 30;
            }
        }

        private static void ProcessState86()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentReturningIndex(Category.Y, ComponentType.DUMMY);
        }

        private static void ProcessState87()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentReturningIndex(Category.O, ComponentType.DUMMY);
        }

        private static void ProcessState88()
        {
            //Error no condición competa
            Concanate("i");
            CreateComponentWithoutReturningIndex(Category.SINO, ComponentType.DUMMY);
        }

        private static void ProcessState89()
        {
            //Error no condición competa
            Concanate("n");
            CreateComponentWithoutReturningIndex(Category.SINO, ComponentType.DUMMY);
        }

        private static void ProcessState90()
        {
            //Error no condición competa
            Concanate("o");
            CreateComponentWithoutReturningIndex(Category.SINO, ComponentType.DUMMY);
        }

        private static void ProcessState91()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentWithoutReturningIndex(Category.SINO, ComponentType.DUMMY);
        }

        private static void ProcessState92()
        {
            //Error no condición competa
            Concanate("i");
            CreateComponentWithoutReturningIndex(Category.FINSI, ComponentType.DUMMY);
        }

        private static void ProcessState93()
        {
            //Error no condición competa
            Concanate("n");
            CreateComponentWithoutReturningIndex(Category.FINSI, ComponentType.DUMMY);
        }

        private static void ProcessState94()
        {
            //Error no condición competa
            Concanate("s");
            CreateComponentWithoutReturningIndex(Category.FINSI, ComponentType.DUMMY);
        }

        private static void ProcessState95()
        {
            //Error no condición competa
            Concanate("i");
            CreateComponentWithoutReturningIndex(Category.FINSI, ComponentType.DUMMY);
        }

        private static void ProcessState96()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentWithoutReturningIndex(Category.FINSI, ComponentType.DUMMY);
        }

        //Revisar ---------------------------------------------------------------------------------------
        private static void ProcessState97()
        {
            //Error no condición competa
            Concanate("n");
            //CreateComponentReturningIndex(Category.FINSI, ComponentType.DUMMY);
        }

        private static void ProcessState98()
        {
            //Error no condición competa
            Concanate("t");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }

        private static void ProcessState99()
        {
            //Error no condición competa
            Concanate("o");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }

        private static void ProcessState100()
        {
            //Error no condición competa
            Concanate("n");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }

        private static void ProcessState101()
        {
            //Error no condición competa
            Concanate("c");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }


        private static void ProcessState102()
        {
            //Error no condición competa
            Concanate("e");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }
        private static void ProcessState103()
        {
            //Error no condición competa
            Concanate("s");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }
        private static void ProcessState104()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentWithoutReturningIndex(Category.ENTONCES, ComponentType.DUMMY);
        }

        private static void ProcessState106()
        {
            //Error no condición competa
            Concanate("c");
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.DUMMY);
        }

        private static void ProcessState107()
        {
            //Error no condición competa
            Concanate("r");
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.DUMMY);
        }

        private static void ProcessState108()
        {
            //Error no condición competa
            Concanate("i");
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.DUMMY);
        }

        private static void ProcessState109()
        {
            //Error no condición competa
            Concanate("b");
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.DUMMY);
        }

        private static void ProcessState110()
        {
            //Error no condición competa
            Concanate("a");
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.DUMMY);
        }

        private static void ProcessState111()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentWithoutReturningIndex(Category.IMPRIMA, ComponentType.DUMMY);
        }

        private static void ProcessState112()
        {
            //Error no condición competa
            Concanate("e");
            CreateComponentWithoutReturningIndex(Category.INPUT, ComponentType.DUMMY);
        }

        private static void ProcessState113()
        {
            //Error no condición competa
            Concanate("a");
            CreateComponentWithoutReturningIndex(Category.INPUT, ComponentType.DUMMY);
        }

        private static void ProcessState114()
        {
            //Error no condición competa
            Concanate("@");
            CreateComponentWithoutReturningIndex(Category.INPUT, ComponentType.DUMMY);
        }

        private static void ProcessState115()
        {
            //Error no condición competa
            string fail = "Acción no permitida, caracter no valido...";
            string cause = "Se ha recibido un caracter que no corresponde a un nombre del programa";
            string solution = "Asegúrese de que luego del simbolo de pesos vaya cualquier elemento a excepción de un salto de linea";
            CreateLexicalError(ErrorType.CONTROLABLE, fail, cause, solution, Category.NOMBREPROGRAMA,
                INSTANCE.Lexeme + Scanner.GetCurrentCharacter());


            Concanate("$");
            CreateComponentWithoutReturningIndex(Category.NOMBREPROGRAMA, ComponentType.DUMMY);
        }

        private static void ProcessState116()
        {
            Scanner.LoadNextLine();
            Restart(32);
        }

        private static void ProcessState117()
        {
            string fail = "Acción no permitida, caracter no valido...";
            string cause = "Se ha recibido un caracter que no corresponde a una cadena de texto";
            string solution = "Asegúrese de que luego de la comillas vaya cualquier elemneto a excepción de un salto de linea";
            CreateLexicalError(ErrorType.CONTROLABLE, fail, cause, solution, Category.CADENA_DE_TEXTO,
                INSTANCE.Lexeme + Scanner.GetCurrentCharacter());

            Concanate("\"");
            CreateComponentWithoutReturningIndex(Category.CADENA_DE_TEXTO, ComponentType.DUMMY);
        }

        //Revisar 117 y 115

        private static void CreateComponent(Category category, ComponentType type)
        {
            int lineNumber = Scanner.GetCurrentNumberLine();
            int finalPosition = Scanner.GetCurrentIndex() - 1;
            int initialPosition = Scanner.GetCurrentIndex() - INSTANCE.Lexeme.Length;

            if (ComponentType.NORMAL.Equals(type))
            {
                INSTANCE.Component = LexicalComponent.CreateNormalComponent(lineNumber, initialPosition, finalPosition, category, INSTANCE.Lexeme);

            }
            else if(ComponentType.DUMMY.Equals(type))
            {
                INSTANCE.Component = LexicalComponent.CreateDummyComponent(lineNumber, initialPosition, finalPosition, category, INSTANCE.Lexeme);
            }
        }

        private static void CreateLexicalError(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexema)
        {
            int lineNumber = Scanner.GetCurrentNumberLine();


            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int finalPosition = Scanner.GetCurrentIndex() - 1;
                int initialPosition = Scanner.GetCurrentIndex() - 1;
                error = Error.CreateStopperLexicalError(lineNumber, initialPosition, 
                    finalPosition, fail, cause, solution, expectedCategory, 
                    lexema);

                ErrorManagement.Agregar(error);
                throw new Exception("Se ha presentado un error tipo STOPPER durante el análisis léxico " +
                    "No es posible continuar con el proceso de compilación hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tener más detalle del" +
                    "problema que se ha presentado ");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int finalPosition = Scanner.GetCurrentIndex() - INSTANCE.Lexeme.Length;
                int initialPosition = Scanner.GetCurrentIndex() - 1;
                error = Error.CreateNoStopperLexicalError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory,
                    lexema);
                ErrorManagement.Agregar(error);
            }
        }

        private static void CreateComponentWithoutReturningIndex(Category category, ComponentType type)
        {
            INSTANCE.Continue = false;
            CreateComponent(category, type);
        }


        private static void CreateComponentReturningIndex(Category category, ComponentType type)
        {
            Scanner.ReturnIndex();
            INSTANCE.Continue = false;

            CreateComponent(category, type);
        }



        private static bool IsLetter()
        {
            return Char.IsLetter(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }

        private static bool IsDigit()
        {
            return Char.IsDigit(Scanner.GetCurrentCharacter().ToCharArray()[0]);
        }

        private static bool IsCurrency()
        {
            return "$".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsAddition()
        {
            return GrammaticalCategory.SUMA.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsSubtration()
        {
            return GrammaticalCategory.RESTA.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsMultiplicationtion()
        {
            return GrammaticalCategory.MULTIPLICACION.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsDivision()
        {
            return GrammaticalCategory.DIVISION.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsBackSlash()
        {
            return GrammaticalCategory.BARRA_INVESRA.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsOpenparenthesis()
        {
            return GrammaticalCategory.PARENTESIS_ABRE.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsCloseparenthesis()
        {
            return GrammaticalCategory.PARENTESIS_CIERRA.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsEndLine()
        {
            return GrammaticalCategory.FIN_DE_LINEA.Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsComment() 
        {
            return GrammaticalCategory.COMENTARIO_MULTILINEA.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsSmallerThan() 
        {
            return GrammaticalCategory.MENOR_QUE.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsGreaterThan() 
        {
            return GrammaticalCategory.MAYOR_QUE.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsEqual() 
        {
            return GrammaticalCategory.ASIGNACION.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsQuotationMarks()
        {
            return GrammaticalCategory.CADENA_DE_TEXTO.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsConcate()
        {
            return GrammaticalCategory.CONCATENACION.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsStartFile()
        {
            return GrammaticalCategory.INICIO.Equals(Scanner.GetCurrentCharacter());
        }
        private static bool IsEndFile()
        {
            return GrammaticalCategory.FIN_DEL_ARCHIVO.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsAtSign()
        {
            return "@".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsBlankSpaces()
        {
            return GrammaticalCategory.ESPACIO.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsTab()
        {
            return GrammaticalCategory.TABULACION.Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsComa()
        {
            return ",".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsY()
        {
            return "y".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsO()
        {
            return "o".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsS()
        {
            return "s".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsF()
        {
            return "f".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsE()
        {
            return "e".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsL()
        {
            return "l".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsR()
        {
            return "r".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsB()
        {
            return "b".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsA()
        {
            return "a".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsI()
        {
            return "i".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsN()
        {
            return "n".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsT()
        {
            return "t".Equals(Scanner.GetCurrentCharacter());
        }

        private static bool IsC()
        {
            return "c".Equals(Scanner.GetCurrentCharacter());
        }

        private static void IsError(String value, String message)
        {
            throw new NotImplementedException(message + value);
        }
    }
}
