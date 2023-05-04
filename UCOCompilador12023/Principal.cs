using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCOCompilador12023.CrossCutting;
using UCOCompilador12023.DataCache;
using UCOCompilador12023.ErrorManager;
using UCOCompilador12023.LexicalAnalyzer;

namespace UCOCompilador12023
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            url.Text = ObtainUrl();
            if (url.Text.Contains(".XML") || url.Text.Contains(".xml") || url.Text.Contains(".html") || url.Text.Contains(".txt"))
            {
                StreamReader lector;
                try
                {
                    lector = File.OpenText(url.Text);
                    List<string> Lineas = new List<string>();
                    while (!lector.EndOfStream)
                    {
                        Lineas.Add(lector.ReadLine());
                    }
                    info.Lines = Lineas.ToArray();
                }
                catch (ArgumentException exp)
                {
                    Console.WriteLine("La ruta no debe estar vacia", exp.Message);
                }
            }
            else
            {
                MessageBox.Show("Esta extensión no está permitida");
                url.Clear();
            }
        }

        private String ObtainUrl()
        {
            string path = string.Empty;
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.FileName;

            }
            return path;
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            url.Clear();
            info.Clear();
        }

        private void info_TextChanged(object sender, EventArgs e)
        {

        }

        private void Compilar_Click(object sender, EventArgs e)
        {
            int index = 1;
            foreach(var linea in info.Lines)
            {
                Cache.AddLine(Line.Create(index, linea));
                index++;
            }
            LexicalAnalysis.Initialize();

            try
            {
                LexicalComponent component = LexicalAnalysis.Analyze();
                while (!Category.FIN_DE_ARCHIVO.Equals(component.GetCategory()))
                {
                    component = LexicalAnalysis.Analyze();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡¡¡ERROR DE COMPILACIÓN!!!");
                Console.WriteLine(ex.Message);
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.NORMAL).Count > 0)
            {
                Console.WriteLine("Simbolos: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.NORMAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.LITERAL).Count > 0)
            {
                Console.WriteLine("Literales: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.LITERAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.DUMMY).Count > 0)
            {
                Console.WriteLine("Dummies: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.DUMMY))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA).Count > 0)
            {
                Console.WriteLine("Palabras reservadas: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }

            if (ErrorManagement.HayErrores())
            {
                Console.WriteLine("_________________________________________________________________");
                Console.WriteLine("LISTADO DE ERRORES LÉXICOS");
                Console.WriteLine("_________________________________________________________________");

                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    Console.WriteLine(error.ToString());
                    Console.WriteLine("_________________________________________________________________");
                    adicionarCeldaATablaErrores(error.GetType(), error.GetCause(), error.GetSolution(), error.GetExpectedCategory(), error.GetLineNumber(), 
                        error.GetInitialPosition(), error.GetFinalPosition(), error.GetLexeme());

               
        



                    }
            }
        }

        private void clearDataGrid(DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
        }

        private void tablaDePalbrasReservadasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tablaSimbolosButton_Click(object sender, EventArgs e)
        {
            tablaDummyGroupBox.Hide();
            TablaLiteralesgroupBox.Hide();
            TablaPalabrasResevadasgroupBox.Hide();
            tablaSimbolosGroup.Show();

            clearDataGrid(SimbolosdataGridView);
            foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.NORMAL))
            {
                //Console.WriteLine("=======================================================");
                //Console.WriteLine(componentTmp.ToString());
                adicionarCeldaATablaSimbolos(componentTmp.GetLineNumber(), componentTmp.GetInitialPosition(),
                    componentTmp.GetFinalPosition(), componentTmp.GetCategory(), componentTmp.GetLexeme());

            }
        }
        private void adicionarCeldaATablaSimbolos(int numeroLinea, int posicionInicial, int posicionFinal, Category categoria, string lexema)
        {
            int numero = SimbolosdataGridView.Rows.Add();

            SimbolosdataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            SimbolosdataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            SimbolosdataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            SimbolosdataGridView.Rows[numero].Cells[3].Value = categoria;
            SimbolosdataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        private void principalMenu_Click(object sender, EventArgs e)
        {

        }

        private void tablaDummiesButton_Click(object sender, EventArgs e)
        {
            tablaDummyGroupBox.Show();
            TablaLiteralesgroupBox.Hide();
            TablaPalabrasResevadasgroupBox.Hide();
            tablaSimbolosGroup.Hide();
            clearDataGrid(dummiesDataGridView);
            foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.DUMMY))
            {
                //Console.WriteLine("=======================================================");
                //Console.WriteLine(componentTmp.ToString());
                adicionarCeldaATablaDummies(componentTmp.GetLineNumber(), componentTmp.GetInitialPosition(),
                    componentTmp.GetFinalPosition(), componentTmp.GetCategory(), componentTmp.GetLexeme());

            }


        }
        private void adicionarCeldaATablaDummies(int numeroLinea, int posicionInicial, int posicionFinal, Category categoria, string lexema)
        {
            int numero = dummiesDataGridView.Rows.Add();

            dummiesDataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            dummiesDataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            dummiesDataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            dummiesDataGridView.Rows[numero].Cells[3].Value = categoria;
            dummiesDataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        

        private void tablaPalabrasReservadasButton_Click(object sender, EventArgs e)
        {
            tablaDummyGroupBox.Hide();
            TablaLiteralesgroupBox.Hide();
            TablaPalabrasResevadasgroupBox.Show();
            tablaSimbolosGroup.Hide();

            clearDataGrid(ReservadasdataGridView);
            foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA))
            {
                //Console.WriteLine("=======================================================");
                //Console.WriteLine(componentTmp.ToString());
                adicionarCeldaATablaPalabrasReservadas(componentTmp.GetLineNumber(), componentTmp.GetInitialPosition(),
                    componentTmp.GetFinalPosition(), componentTmp.GetCategory(), componentTmp.GetLexeme());

            }



        }

        private void adicionarCeldaATablaPalabrasReservadas(int numeroLinea, int posicionInicial, int posicionFinal, Category categoria, string lexema)
        {
            int numero = ReservadasdataGridView.Rows.Add();

            ReservadasdataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            ReservadasdataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            ReservadasdataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            ReservadasdataGridView.Rows[numero].Cells[3].Value = categoria;
            ReservadasdataGridView.Rows[numero].Cells[4].Value = lexema;
        }

        private void tablaLiteralesButton_Click(object sender, EventArgs e)
        {
            tablaDummyGroupBox.Hide();
            TablaLiteralesgroupBox.Show();
            TablaPalabrasResevadasgroupBox.Hide();
            tablaSimbolosGroup.Hide();

            clearDataGrid(LiteralesdataGridView);
            foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.LITERAL))
            {

                adicionarCeldaATablaLiterales(componentTmp.GetLineNumber(), componentTmp.GetInitialPosition(),
                    componentTmp.GetFinalPosition(), componentTmp.GetCategory(), componentTmp.GetLexeme());

            }


        }

        private void adicionarCeldaATablaLiterales (int numeroLinea, int posicionInicial, int posicionFinal, Category categoria, string lexema)
        {
            int numero = LiteralesdataGridView.Rows.Add();

            LiteralesdataGridView.Rows[numero].Cells[0].Value = numeroLinea.ToString();
            LiteralesdataGridView.Rows[numero].Cells[1].Value = posicionInicial.ToString();
            LiteralesdataGridView.Rows[numero].Cells[2].Value = posicionFinal.ToString();
            LiteralesdataGridView.Rows[numero].Cells[3].Value = categoria;
            LiteralesdataGridView.Rows[numero].Cells[4].Value = lexema;
        }



        private void adicionarCeldaATablaErrores( ErrorType errorType,String cause,String solution,Category ExpectedCategory, int numeroLinea, int posicionInicial, int posicionFinal, string lexema)
        {
            clearDataGrid(ErrorDataGridVIew);
            int numero = ErrorDataGridVIew.Rows.Add();

            ErrorDataGridVIew.Rows[numero].Cells[0].Value = errorType;
            ErrorDataGridVIew.Rows[numero].Cells[1].Value = cause;
            ErrorDataGridVIew.Rows[numero].Cells[2].Value = solution;
            ErrorDataGridVIew.Rows[numero].Cells[3].Value = ExpectedCategory;
            ErrorDataGridVIew.Rows[numero].Cells[4].Value = lexema;
            ErrorDataGridVIew.Rows[numero].Cells[5].Value = numeroLinea.ToString();
            ErrorDataGridVIew.Rows[numero].Cells[6].Value = posicionInicial.ToString();
            ErrorDataGridVIew.Rows[numero].Cells[7].Value = posicionFinal.ToString();
        }

       
    }
}
