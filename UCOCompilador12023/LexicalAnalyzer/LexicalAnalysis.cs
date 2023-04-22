using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.DataCache;

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
                if (INSTANCE.CurrentState == 23)
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
                INSTANCE.CurrentState = 57;
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
                //Error Stopper
                INSTANCE.CurrentState = 36;
                //IsError(Scanner.GetCurrentCharacter(), "Esperaba un valor del compilador no el siguiente caracter ");
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
            if (IsEqual())
            {
                Concanate();
                INSTANCE.CurrentState = 28;
            }
            else if(IsGreaterThan()) 
            {
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
            CreateComponentWithoutReturningIndex(Category.MENOR_QUE, ComponentType.NORMAL);
        }
        private static void ProcessState23()
        {
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
            CreateComponentWithoutReturningIndex(Category.MAYOR_QUE, ComponentType.NORMAL);
        }

        private static void ProcessState25()
        {
            //Retorna o lógico
            returnData();
            INSTANCE.CurrentState = 0; 
        }

        private static void ProcessState26()
        {
            if(IsEqual())
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
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState28()
        {
            //Retorno menor o igual
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState29()
        {
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
            if (IsQuotationMarks())
            {
                Concanate();
                INSTANCE.CurrentState = 35;
            }
            else if (IsDivision())
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
            if (IsEndLine())
            {
                Concanate();
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
            if (IsEndLine())
            {
                Concanate();
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
            returnData();
            INSTANCE.CurrentState = 35;
        }

        private static void ProcessState36()
        {
            //Retorna error
            //IsError(Scanner.GetCurrentCharacter(), "Esperaba un valor del compilador no el siguiente caracter ");
        }

        private static void ProcessState37()
        {
            //Retorna suma
            CreateComponentWithoutReturningIndex(Category.SUMA, ComponentType.NORMAL);
        }

        private static void ProcessState38()
        {
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
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState42()
        {
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
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState45()
        {
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
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState52()
        {
            //Retorna diferente que
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState53()
        {
            //Retorna fin si lógico
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState55()
        {
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
            if (IsCurrency())
            {
                Concanate();
                INSTANCE.CurrentState = 57;
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
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState58()
        {
            //Retorna igual que
            returnData();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState59()
        {
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
            Concanate();
            INSTANCE.CurrentState = 0;
        }

        private static void ProcessState69()
        {
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
