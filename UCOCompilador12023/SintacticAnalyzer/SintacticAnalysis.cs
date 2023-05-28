using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCOCompilador12023.DataCache;
using UCOCompilador12023.ErrorManager;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023.SintacticAnalyzer
{
    public class SintacticAnalysis
    {
        private Stack<double> stackData = new Stack<double>();
        private LexicalComponent component;
        //private LexicalAnalysis LexAna;

        //public SintacticAnalysis()
        //{
        //    LexAna = LexicalAnalysis.GetInstance();
        //}

        public string Analyze()
        {
            string response = "El proceso del analisis sintactico, finalizó exitosamente...";
            LexicalAnalysis.Initialize();
            LeerSiguienteComponente();
            Programa();

            if (ErrorManagement.HayErrores())
            {
                response = "El proceso de compilación finalizó con errores...";
            }
            else if(!Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
            {
                response = "No se presentaron errores, el proceso de compilación sinatctico pero faltaron componenetes por evaluar...";
            }/*else if(stackData.Count > 1)
            {
                response = "No se presentaron errores, el proceso de compilación sematico pero faltaron componenetes por evaluar...";
            }
            else
            {
                response = "\n" + "El resultado de la operación es: " + stackData.Pop();
            }*/


            return response;
        }
        private void Programa()
        {
            if (EsCategoriaEsperada(Category.NOMBREPROGRAMA))
            {
                LeerSiguienteComponente();
                if (EsCategoriaEsperada(Category.INICIO_ARCHIVO))
                {
                    LeerSiguienteComponente();
                    GrupoSentencias();
                    /*if (EsCategoriaEsperada(Category.FIN_DE_ARCHIVO))
                    {
                        LeerSiguienteComponente();
                    }
                    else
                    {
                        string fail = "Componente sintactico no corresponde a un fin de archivo...";
                        string cause = "Componente sintactico no experado en este lugar...";
                        string solution = "Asegúrese de que en este lugar esté ubicado un fin de archivo (\"}\").";
                        CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.FIN_DE_ARCHIVO,
                            component.GetCategory().ToString());
                    }*/

                }
                else
                {
                    string fail = "Componente sintactico no corresponde a un inicio de archivo...";
                    string cause = "Componente sintactico no experado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado un inicio de archivo (\"{\").";
                    CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.INICIO_ARCHIVO,
                        component.GetCategory().ToString());
                }
            }
            else
            {
                string fail = "Componente léxico no corresponde a un nombre del programa...";
                string cause = "Componente léxico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un nombre del programa ($algo$).";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.NOMBREPROGRAMA,
                    component.GetCategory().ToString());
            }

        }

        private void GrupoSentencias()
        {
            Sentencia();
        }

        private void Sentencia()
        {
            AsignacionPrima();
            //EntradaPrima();
            //ConcatenarPrima();
            //CondicionalPrima();
            //ComentarioPrima();
   
        }

        private void AsignacionPrima()
        {
            Asignacion();
        }


        private void Concatenar()
        {
            if (EsCategoriaEsperada(Category.CONCATENACION))
            {
                LeerSiguienteComponente();
                Salida();
            }
        }

        private void Asignacion()
        {
            if (EsCategoriaEsperada(Category.IDENTIFICADOR))
            {
                LeerSiguienteComponente();
                if (EsCategoriaEsperada(Category.ASIGNACION))
                {
                    LeerSiguienteComponente();
                    Expresion();
                    Asignacion();
                }
                else
                {
                    string fail = "Componente sintactico no corresponde a una asignación.";
                    string cause = "Componente sintactico no experado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado una asignación.";
                    CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.ASIGNACION,
                        component.GetCategory().ToString());
                }

            }
            else
            {
                Entrada();
            }
        }

        private void Entrada()
        {
            if (EsCategoriaEsperada(Category.INPUT))
            {
                LeerSiguienteComponente();
                if (EsCategoriaEsperada(Category.PARENTESIS_ABRE))
                {
                    LeerSiguienteComponente();
                    if (EsCategoriaEsperada(Category.IDENTIFICADOR))
                    {
                        LeerSiguienteComponente();
                        if (EsCategoriaEsperada(Category.PARENTESIS_CIERRA))
                        {
                            LeerSiguienteComponente();
                        }
                        else
                        {
                            string fail = "Componente sintactico no corresponde a un parentesis cierra.";
                            string cause = "Componente sintactico no experado en este lugar...";
                            string solution = "Asegúrese de que en este lugar esté ubicado un parentesis cierra.";
                            CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.PARENTESIS_CIERRA,
                                component.GetCategory().ToString());
                        }
                    }
                    else
                    {
                        string fail = "Componente sintactico no corresponde a un identificador.";
                        string cause = "Componente sintactico no experado en este lugar...";
                        string solution = "Asegúrese de que en este lugar esté ubicado un identificador.";
                        CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.IDENTIFICADOR,
                            component.GetCategory().ToString());
                    }
                }
                else
                {
                    string fail = "Componente sintactico no corresponde a un parentesis abre.";
                    string cause = "Componente sintactico no experado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado un parentesis abre.";
                    CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.PARENTESIS_ABRE,
                        component.GetCategory().ToString());

                }

            }
            else
            {
                Condicional();
                //string fail = "Componente sintactico no corresponde a un leer.";
                //string cause = "Componente sintactico no experado en este lugar...";
                //string solution = "Asegúrese de que en este lugar esté ubicado un leer.";
                //CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.INPUT,
                //    component.GetCategory().ToString());

            }
        }

        private void Salida()
        {
            if (EsCategoriaEsperada(Category.IMPRIMA))
            {
                LeerSiguienteComponente();
                OpcionalExpresion();
                //LeerSiguienteComponente();
                OpcionalTexto();
                //LeerSiguienteComponente();
                OpcionalExpresion();
            }
            else
            {
                string fail = "Componente sintactico no corresponde a un imprima.";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un imprima.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.IMPRIMA,
                    component.GetCategory().ToString());

            }
        }

        private void OpcionalExpresion()
        {
            Expresion();
            LeerSiguienteComponente();
        }

        private void OpcionalTexto()
        {
            if (EsCategoriaEsperada(Category.CADENA_DE_TEXTO))
            {
                LeerSiguienteComponente();
            }
            else
            {
                string fail = "Componente sintactico no corresponde a un cadena de texto.";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado una cadena de texto.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.CADENA_DE_TEXTO,
                    component.GetCategory().ToString());

            }
        }

        private void Condicional()
        {
            if (EsCategoriaEsperada(Category.SI))
            {
                LeerSiguienteComponente();
                Expresion();
                operanorComaprador();
                if (EsCategoriaEsperada(Category.ENTONCES))
                {
                    LeerSiguienteComponente();
                    Sentencia();
                    if (EsCategoriaEsperada(Category.SINO))
                    {
                        LeerSiguienteComponente();
                        Sentencia();
                        if (EsCategoriaEsperada(Category.FINSI))
                        {
                            LeerSiguienteComponente();
                        }
                        else
                        {
                            string fail = "Componente sintactico no corresponde a un finsi.";
                            string cause = "Componente sintactico no experado en este lugar...";
                            string solution = "Asegúrese de que en este lugar esté ubicado un finsi.";
                            CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.FINSI,
                                component.GetCategory().ToString());

                        }
                    }
                    else
                    {
                        string fail = "Componente sintactico no corresponde a un sino.";
                        string cause = "Componente sintactico no experado en este lugar...";
                        string solution = "Asegúrese de que en este lugar esté ubicado un sino.";
                        CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.SINO,
                            component.GetCategory().ToString());

                    }
                }
                else
                {
                    string fail = "Componente sintactico no corresponde a un entonces.";
                    string cause = "Componente sintactico no experado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado un entonces.";
                    CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.ENTONCES,
                        component.GetCategory().ToString());

                }
            }
            else
            {
                Comentario();
             //   string fail = "Componente sintactico no corresponde a un si.";
             //   string cause = "Componente sintactico no experado en este lugar...";
             //   string solution = "Asegúrese de que en este lugar esté ubicado un si.";
             //   CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.SI,
             //       component.GetCategory().ToString());

            }
        }


        private void Comentario()
        {
            if (EsCategoriaEsperada(Category.COMENTARIO_UNA_LINEA))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.COMENTARIO_MULTILINEA))
            {
                LeerSiguienteComponente();
            }
            else
            {
                Concatenar();
                //string fail = "Componente sintactico no corresponde a un comentario.";
                //string cause = "Componente sintactico no experado en este lugar...";
                //string solution = "Asegúrese de que en este lugar esté ubicado un un comentario.";
                //CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                //    component.GetCategory().ToString());
            }
        }

        private void Expresion()
        {
            Termino();
            ExpresionPrima();
            operanorComaprador();
        }

        private void ExpresionPrima()
        {
            if (EsCategoriaEsperada(Category.SUMA))
            {
                LeerSiguienteComponente();
                Expresion();
                /*if (!ErrorManagement.HayErrores())
                {
                    double derecho = stackData.Pop();
                    double izquierdo = stackData.Pop();
                    stackData.Push(izquierdo * derecho);
                }*/
            }
            else if (EsCategoriaEsperada(Category.RESTA))
            {

                LeerSiguienteComponente();
                Expresion();
                /*if (!ErrorManagement.HayErrores())
                {
                    double derecho = stackData.Pop();
                    double izquierdo = stackData.Pop();
                    stackData.Push(izquierdo * derecho);
                }*/
            }

        }

        private void Termino()
        {
            Factor();
            TerminoPrima();
            
        }

        private void TerminoPrima()
        {
            if (EsCategoriaEsperada(Category.MULTIPLICACION))
            {
                LeerSiguienteComponente();
                Termino();
                /*if (!ErrorManagement.HayErrores())
                {
                    double derecho = stackData.Pop();
                    double izquierdo = stackData.Pop();
                    stackData.Push(izquierdo * derecho);
                }*/

            }
            else if (EsCategoriaEsperada(Category.DIVISION))
            {
                LeerSiguienteComponente();
                Termino();
                if (!ErrorManagement.HayErrores())
                {
                    double derecho = stackData.Pop();
                    double izquierdo = stackData.Pop();
                    if(derecho == 0)
                    {
                        string fail = "Division por cero.";
                        string cause = "Componente léxico igualñ a cero...";
                        string solution = "Asegúrese de que en este lugar esté ubicado un número diferente a cero.";
                        CreateSintaticError(ErrorType.CONTROLABLE, fail, cause, solution, Category.DECIMAL,
                            "Cero (0)");
                        derecho = 1;
                    }
                    stackData.Push(izquierdo / derecho);

                }
            }
        }

        private void Factor()
        {
            if (EsCategoriaEsperada(Category.ENTERO))
            {
                //{
                //    stackData.Push(Double.Parse(component.GetLexeme()));
                //}
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.DECIMAL))
            {
                //{
                //    stackData.Push(Double.Parse(component.GetLexeme()));
                //}
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.IDENTIFICADOR))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.PARENTESIS_ABRE))
            {
                LeerSiguienteComponente();
                Expresion();
                if (EsCategoriaEsperada(Category.PARENTESIS_CIERRA))
                {
                    LeerSiguienteComponente();
                }
                else
                {
                    string fail = "Componente sintactico no corresponde a un parentesis que cierra...";
                    string 
                        cause = "Componente sintactico no experado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado un parentesis que cierra.";
                    CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.PARENTESIS_CIERRA,
                        component.GetCategory().ToString());
                }
            }
            else
            {
                //string fail = "Componente léxico no corresponde a un parentesis que abre, Entero o Decimal...";
                //string cause = "Componente léxico no experado en este lugar...";
                //string solution = "Asegúrese de que en este lugar esté ubicado un parentesis que abre, Entero o Decimal.";
                //CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                //    component.GetCategory().ToString());
            }
        }

        /*private void Comparacion()
        {
            Expresion();
            ComparacionPrima();
            ComparacionLogica();
        }*/

        /*private void ComparacionPrima()
        {
            Comparador();
            Expresion();
        }*/

        private void ComparacionLogica()
        {
            Expresion();
        }

        private void ComparacionLogicaPrima()
        {
            if (EsCategoriaEsperada(Category.Y))
            {
                LeerSiguienteComponente();
                ComparacionLogica();
            }
            else if (EsCategoriaEsperada(Category.O))
            {
                LeerSiguienteComponente();
                ComparacionLogica();
            }
        }

        private void operanorComaprador()
        {
            Comparador();
            Factor();
            ComparacionLogicaPrima();
        }

        private void Comparador()
        {
            if (EsCategoriaEsperada(Category.MENOR_QUE) || EsCategoriaEsperada(Category.MENOR_IGUAL_QUE)
                || EsCategoriaEsperada(Category.MAYOR_IGUAL_QUE) || EsCategoriaEsperada(Category.MAYOR_QUE) 
                || EsCategoriaEsperada(Category.DIFERENTE_QUE)|| EsCategoriaEsperada(Category.IGUAL_QUE))
            {
                LeerSiguienteComponente();
            }
        }


        private bool EsCategoriaEsperada(Category category)
        {
            return category.Equals(component.GetCategory());
        }

        private void LeerSiguienteComponente()
        {
            component = LexicalAnalysis.Analyze();
        }

        private void CreateSintaticError(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexema)
        {
            int lineNumber = component.GetLineNumber();
            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int finalPosition = component.GetFinalPosition();
                int initialPosition = component.GetInitialPosition();
                error = Error.CreateStopperSintacticlError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexema);

                ErrorManagement.Agregar(error);
                throw new Exception("Se ha presentado un error tipo STOPPER durante el análisis sintactico " +
                    "No es posible continuar con el proceso de compilación hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tener más detalle del" +
                    "problema que se ha presentado ");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int finalPosition = component.GetFinalPosition();
                int initialPosition = component.GetInitialPosition();
                error = Error.CreateNoStopperSintacticError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexema);
                ErrorManagement.Agregar(error);
            }
        }

        private void CreateSemanticError(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexema)
        {
            int lineNumber = component.GetLineNumber();
            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int finalPosition = component.GetFinalPosition();
                int initialPosition = component.GetInitialPosition();
                error = Error.CreateStopperSemanticlError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexema);

                ErrorManagement.Agregar(error);
                throw new Exception("Se ha presentado un error tipo STOPPER durante el análisis semántico " +
                    "No es posible continuar con el proceso de compilación hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tener más detalle del" +
                    "problema que se ha presentado ");
            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int finalPosition = component.GetFinalPosition();
                int initialPosition = component.GetInitialPosition();
                error = Error.CreateNoStopperSemanticError(lineNumber, initialPosition,
                    finalPosition, fail, cause, solution, expectedCategory, lexema);
                ErrorManagement.Agregar(error);
            }
        }
    }
}
