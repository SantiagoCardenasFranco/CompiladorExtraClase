﻿using System;
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
                response = "No se presentaron errores, pero faltaron componenetes por evaluar...";
            }

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
                    if (EsCategoriaEsperada(Category.FIN_DE_ARCHIVO))
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
                    }

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
            GrupoSentencias();
        }

        private void Sentencia()
        {
            AsignacionPrima();
            EntradaPrima();
            ConcatenarPrima();
            CondicionalPrima();
            ComentarioPrima();
   
        }

        private void AsignacionPrima()
        {
            Asignacion();
            LeerSiguienteComponente();
        }

        private void EntradaPrima()
        {
            Entrada();
            LeerSiguienteComponente();
        }

        private void CondicionalPrima()
        {
            Condicional();
            LeerSiguienteComponente();
        }

        private void ComentarioPrima()
        {
            Comentario();
            LeerSiguienteComponente();
        }

        private void ConcatenarPrima()
        {
            Concatenar();
            LeerSiguienteComponente();
        }

        private void Concatenar()
        {
            Salida();
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
                string fail = "Componente sintactico no corresponde a un identificador.";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un identificador.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.IDENTIFICADOR,
                    component.GetCategory().ToString());
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
                string fail = "Componente sintactico no corresponde a un leer.";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un leer.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.INPUT,
                    component.GetCategory().ToString());

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
                Comparacion();
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
                string fail = "Componente sintactico no corresponde a un si.";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un si.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.SI,
                    component.GetCategory().ToString());

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
                string fail = "Componente sintactico no corresponde a un comentario.";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un un comentario.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                    component.GetCategory().ToString());
            }
        }

        private void Expresion()
        {
            Termino();
            ExpresionPrima();
        }

        private void ExpresionPrima()
        {
            if (EsCategoriaEsperada(Category.SUMA))
            {
                LeerSiguienteComponente();
                Expresion();
            }
            else if (EsCategoriaEsperada(Category.RESTA))
            {
                LeerSiguienteComponente();
                Expresion();
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

            }
            else if (EsCategoriaEsperada(Category.DIVISION))
            {
                LeerSiguienteComponente();
                Termino();
            }
        }

        private void Factor()
        {
            if (EsCategoriaEsperada(Category.ENTERO))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.DECIMAL))
            {
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
                    string cause = "Componente sintactico no experado en este lugar...";
                    string solution = "Asegúrese de que en este lugar esté ubicado un parentesis que cierra.";
                    CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.PARENTESIS_CIERRA,
                        component.GetCategory().ToString());
                }
            }
            else
            {
                LeerSiguienteComponente();
                Comparacion();
                //string fail = "Componente léxico no corresponde a un parentesis que abre, Entero o Decimal...";
                //string cause = "Componente léxico no experado en este lugar...";
                //string solution = "Asegúrese de que en este lugar esté ubicado un parentesis que abre, Entero o Decimal.";
                //CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                //    component.GetCategory().ToString());
            }
        }

        private void Comparacion()
        {
            Expresion();
            ComparacionPrima();

            LeerSiguienteComponente();
            ComparacionLogica();
        }

        private void ComparacionPrima()
        {
            Comparador();
            Expresion();
        }

        private void ComparacionLogica()
        {
            Comparacion();
            ComparacionLogicaPrima();
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

        private void Comparador()
        {
            if (EsCategoriaEsperada(Category.MENOR_QUE))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.MENOR_IGUAL_QUE))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.MAYOR_IGUAL_QUE))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.MAYOR_QUE))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.DIFERENTE_QUE))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.IGUAL_QUE))
            {
                LeerSiguienteComponente();
            }
            else
            {
                string fail = "Componente sintactico no corresponde a un opreador de compraración ...";
                string cause = "Componente sintactico no experado en este lugar...";
                string solution = "Asegúrese de que en este lugar esté ubicado un >, <, >=, <=, !=, ==.";
                CreateSintaticError(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL,
                   component.GetCategory().ToString());
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
                throw new Exception("Se ha presentado un error tipo STOPPER durante el análisis léxico " +
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
    }
}