namespace UCOCompilador12023
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Buscar = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Compilar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.principalMenu = new System.Windows.Forms.TabPage();
            this.tablasMenu = new System.Windows.Forms.TabPage();
            this.ErroresMenu = new System.Windows.Forms.TabPage();
            this.tablaSimbolosButton = new System.Windows.Forms.Button();
            this.tablaLiteralesButton = new System.Windows.Forms.Button();
            this.tablaDummiesButton = new System.Windows.Forms.Button();
            this.tablaPalabrasReservadasButton = new System.Windows.Forms.Button();
            this.tablaDummyGroupBox = new System.Windows.Forms.GroupBox();
            this.dummiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaSimbolosGroup = new System.Windows.Forms.GroupBox();
            this.SimbolosdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaLiteralesgroupBox = new System.Windows.Forms.GroupBox();
            this.LiteralesdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TablaPalabrasResevadasgroupBox = new System.Windows.Forms.GroupBox();
            this.ReservadasdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.principalMenu.SuspendLayout();
            this.tablasMenu.SuspendLayout();
            this.tablaDummyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dummiesDataGridView)).BeginInit();
            this.tablaSimbolosGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SimbolosdataGridView)).BeginInit();
            this.TablaLiteralesgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LiteralesdataGridView)).BeginInit();
            this.TablaPalabrasResevadasgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReservadasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(95, 33);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(222, 36);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(408, 20);
            this.url.TabIndex = 1;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(300, 75);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(280, 220);
            this.info.TabIndex = 2;
            this.info.TextChanged += new System.EventHandler(this.info_TextChanged);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(300, 311);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Compilar
            // 
            this.Compilar.Location = new System.Drawing.Point(505, 311);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(75, 23);
            this.Compilar.TabIndex = 4;
            this.Compilar.Text = "Compilar";
            this.Compilar.UseVisualStyleBackColor = true;
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.principalMenu);
            this.tabControl1.Controls.Add(this.tablasMenu);
            this.tabControl1.Controls.Add(this.ErroresMenu);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 448);
            this.tabControl1.TabIndex = 7;
            // 
            // principalMenu
            // 
            this.principalMenu.Controls.Add(this.Buscar);
            this.principalMenu.Controls.Add(this.url);
            this.principalMenu.Controls.Add(this.Limpiar);
            this.principalMenu.Controls.Add(this.Compilar);
            this.principalMenu.Controls.Add(this.info);
            this.principalMenu.Location = new System.Drawing.Point(4, 22);
            this.principalMenu.Name = "principalMenu";
            this.principalMenu.Padding = new System.Windows.Forms.Padding(3);
            this.principalMenu.Size = new System.Drawing.Size(792, 422);
            this.principalMenu.TabIndex = 0;
            this.principalMenu.Text = "Principal";
            this.principalMenu.UseVisualStyleBackColor = true;
            // 
            // tablasMenu
            // 
            this.tablasMenu.Controls.Add(this.TablaPalabrasResevadasgroupBox);
            this.tablasMenu.Controls.Add(this.TablaLiteralesgroupBox);
            this.tablasMenu.Controls.Add(this.tablaSimbolosGroup);
            this.tablasMenu.Controls.Add(this.tablaDummyGroupBox);
            this.tablasMenu.Controls.Add(this.tablaPalabrasReservadasButton);
            this.tablasMenu.Controls.Add(this.tablaDummiesButton);
            this.tablasMenu.Controls.Add(this.tablaLiteralesButton);
            this.tablasMenu.Controls.Add(this.tablaSimbolosButton);
            this.tablasMenu.Location = new System.Drawing.Point(4, 22);
            this.tablasMenu.Name = "tablasMenu";
            this.tablasMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tablasMenu.Size = new System.Drawing.Size(792, 422);
            this.tablasMenu.TabIndex = 1;
            this.tablasMenu.Text = "Tablas";
            this.tablasMenu.UseVisualStyleBackColor = true;
            // 
            // ErroresMenu
            // 
            this.ErroresMenu.Location = new System.Drawing.Point(4, 22);
            this.ErroresMenu.Name = "ErroresMenu";
            this.ErroresMenu.Size = new System.Drawing.Size(792, 422);
            this.ErroresMenu.TabIndex = 2;
            this.ErroresMenu.Text = "Errores";
            this.ErroresMenu.UseVisualStyleBackColor = true;
            // 
            // tablaSimbolosButton
            // 
            this.tablaSimbolosButton.BackColor = System.Drawing.Color.White;
            this.tablaSimbolosButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tablaSimbolosButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tablaSimbolosButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.tablaSimbolosButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.tablaSimbolosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablaSimbolosButton.ForeColor = System.Drawing.Color.Black;
            this.tablaSimbolosButton.Location = new System.Drawing.Point(32, 351);
            this.tablaSimbolosButton.Margin = new System.Windows.Forms.Padding(0);
            this.tablaSimbolosButton.Name = "tablaSimbolosButton";
            this.tablaSimbolosButton.Size = new System.Drawing.Size(122, 38);
            this.tablaSimbolosButton.TabIndex = 12;
            this.tablaSimbolosButton.Text = "Tabla de Simbolos";
            this.tablaSimbolosButton.UseVisualStyleBackColor = false;
            this.tablaSimbolosButton.Click += new System.EventHandler(this.tablaSimbolosButton_Click);
            // 
            // tablaLiteralesButton
            // 
            this.tablaLiteralesButton.BackColor = System.Drawing.Color.White;
            this.tablaLiteralesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tablaLiteralesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tablaLiteralesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.tablaLiteralesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.tablaLiteralesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablaLiteralesButton.ForeColor = System.Drawing.Color.Black;
            this.tablaLiteralesButton.Location = new System.Drawing.Point(168, 351);
            this.tablaLiteralesButton.Margin = new System.Windows.Forms.Padding(0);
            this.tablaLiteralesButton.Name = "tablaLiteralesButton";
            this.tablaLiteralesButton.Size = new System.Drawing.Size(113, 38);
            this.tablaLiteralesButton.TabIndex = 13;
            this.tablaLiteralesButton.Text = "Tabla de Literales";
            this.tablaLiteralesButton.UseVisualStyleBackColor = false;
            // 
            // tablaDummiesButton
            // 
            this.tablaDummiesButton.BackColor = System.Drawing.Color.White;
            this.tablaDummiesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tablaDummiesButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tablaDummiesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.tablaDummiesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.tablaDummiesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablaDummiesButton.ForeColor = System.Drawing.Color.Black;
            this.tablaDummiesButton.Location = new System.Drawing.Point(292, 351);
            this.tablaDummiesButton.Margin = new System.Windows.Forms.Padding(0);
            this.tablaDummiesButton.Name = "tablaDummiesButton";
            this.tablaDummiesButton.Size = new System.Drawing.Size(117, 38);
            this.tablaDummiesButton.TabIndex = 10;
            this.tablaDummiesButton.Text = "Tabla de Dummies";
            this.tablaDummiesButton.UseVisualStyleBackColor = false;
            // 
            // tablaPalabrasReservadasButton
            // 
            this.tablaPalabrasReservadasButton.BackColor = System.Drawing.Color.White;
            this.tablaPalabrasReservadasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tablaPalabrasReservadasButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.tablaPalabrasReservadasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.tablaPalabrasReservadasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.tablaPalabrasReservadasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tablaPalabrasReservadasButton.ForeColor = System.Drawing.Color.Black;
            this.tablaPalabrasReservadasButton.Location = new System.Drawing.Point(422, 351);
            this.tablaPalabrasReservadasButton.Margin = new System.Windows.Forms.Padding(0);
            this.tablaPalabrasReservadasButton.Name = "tablaPalabrasReservadasButton";
            this.tablaPalabrasReservadasButton.Size = new System.Drawing.Size(169, 38);
            this.tablaPalabrasReservadasButton.TabIndex = 13;
            this.tablaPalabrasReservadasButton.Text = "Tabla de Palabras Reservadas";
            this.tablaPalabrasReservadasButton.UseVisualStyleBackColor = false;
            // 
            // tablaDummyGroupBox
            // 
            this.tablaDummyGroupBox.Controls.Add(this.dummiesDataGridView);
            this.tablaDummyGroupBox.Location = new System.Drawing.Point(6, 6);
            this.tablaDummyGroupBox.Name = "tablaDummyGroupBox";
            this.tablaDummyGroupBox.Size = new System.Drawing.Size(780, 304);
            this.tablaDummyGroupBox.TabIndex = 16;
            this.tablaDummyGroupBox.TabStop = false;
            this.tablaDummyGroupBox.Text = "Tabla de Dummies";
            // 
            // dummiesDataGridView
            // 
            this.dummiesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dummiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dummiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dummiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dummiesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.dummiesDataGridView.Name = "dummiesDataGridView";
            this.dummiesDataGridView.Size = new System.Drawing.Size(771, 282);
            this.dummiesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Número de Linea";
            this.dataGridViewTextBoxColumn11.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn12.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn13.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn14.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn15.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // tablaSimbolosGroup
            // 
            this.tablaSimbolosGroup.Controls.Add(this.SimbolosdataGridView);
            this.tablaSimbolosGroup.Location = new System.Drawing.Point(6, 6);
            this.tablaSimbolosGroup.Name = "tablaSimbolosGroup";
            this.tablaSimbolosGroup.Size = new System.Drawing.Size(783, 314);
            this.tablaSimbolosGroup.TabIndex = 17;
            this.tablaSimbolosGroup.TabStop = false;
            this.tablaSimbolosGroup.Text = "Tabla de Simbolos";
            // 
            // SimbolosdataGridView
            // 
            this.SimbolosdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SimbolosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SimbolosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.SimbolosdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.SimbolosdataGridView.Location = new System.Drawing.Point(6, 19);
            this.SimbolosdataGridView.Name = "SimbolosdataGridView";
            this.SimbolosdataGridView.Size = new System.Drawing.Size(771, 282);
            this.SimbolosdataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Número de Linea";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // TablaLiteralesgroupBox
            // 
            this.TablaLiteralesgroupBox.Controls.Add(this.LiteralesdataGridView);
            this.TablaLiteralesgroupBox.Location = new System.Drawing.Point(6, 6);
            this.TablaLiteralesgroupBox.Name = "TablaLiteralesgroupBox";
            this.TablaLiteralesgroupBox.Size = new System.Drawing.Size(783, 314);
            this.TablaLiteralesgroupBox.TabIndex = 18;
            this.TablaLiteralesgroupBox.TabStop = false;
            this.TablaLiteralesgroupBox.Text = "Tabla de Literales";
            // 
            // LiteralesdataGridView
            // 
            this.LiteralesdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LiteralesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LiteralesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.LiteralesdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.LiteralesdataGridView.Location = new System.Drawing.Point(6, 19);
            this.LiteralesdataGridView.Name = "LiteralesdataGridView";
            this.LiteralesdataGridView.Size = new System.Drawing.Size(771, 282);
            this.LiteralesdataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Número de Linea";
            this.dataGridViewTextBoxColumn6.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn7.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn8.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn9.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn10.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // TablaPalabrasResevadasgroupBox
            // 
            this.TablaPalabrasResevadasgroupBox.Controls.Add(this.ReservadasdataGridView);
            this.TablaPalabrasResevadasgroupBox.Location = new System.Drawing.Point(6, 6);
            this.TablaPalabrasResevadasgroupBox.Name = "TablaPalabrasResevadasgroupBox";
            this.TablaPalabrasResevadasgroupBox.Size = new System.Drawing.Size(783, 314);
            this.TablaPalabrasResevadasgroupBox.TabIndex = 19;
            this.TablaPalabrasResevadasgroupBox.TabStop = false;
            this.TablaPalabrasResevadasgroupBox.Text = "Tabla de Palabras Resevadas";
            // 
            // ReservadasdataGridView
            // 
            this.ReservadasdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservadasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReservadasdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.ReservadasdataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.ReservadasdataGridView.Location = new System.Drawing.Point(6, 19);
            this.ReservadasdataGridView.Name = "ReservadasdataGridView";
            this.ReservadasdataGridView.Size = new System.Drawing.Size(771, 282);
            this.ReservadasdataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn16.HeaderText = "Número de Linea";
            this.dataGridViewTextBoxColumn16.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Posición Inicial";
            this.dataGridViewTextBoxColumn17.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Posición Final";
            this.dataGridViewTextBoxColumn18.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn19.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Lexema";
            this.dataGridViewTextBoxColumn20.MaxInputLength = 999999;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.tabControl1.ResumeLayout(false);
            this.principalMenu.ResumeLayout(false);
            this.principalMenu.PerformLayout();
            this.tablasMenu.ResumeLayout(false);
            this.tablaDummyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dummiesDataGridView)).EndInit();
            this.tablaSimbolosGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SimbolosdataGridView)).EndInit();
            this.TablaLiteralesgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LiteralesdataGridView)).EndInit();
            this.TablaPalabrasResevadasgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReservadasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Compilar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage principalMenu;
        private System.Windows.Forms.TabPage tablasMenu;
        private System.Windows.Forms.TabPage ErroresMenu;
        private System.Windows.Forms.GroupBox tablaDummyGroupBox;
        private System.Windows.Forms.GroupBox tablaSimbolosGroup;
        private System.Windows.Forms.DataGridView SimbolosdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView dummiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button tablaPalabrasReservadasButton;
        private System.Windows.Forms.Button tablaDummiesButton;
        private System.Windows.Forms.Button tablaLiteralesButton;
        private System.Windows.Forms.Button tablaSimbolosButton;
        private System.Windows.Forms.GroupBox TablaPalabrasResevadasgroupBox;
        private System.Windows.Forms.DataGridView ReservadasdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.GroupBox TablaLiteralesgroupBox;
        private System.Windows.Forms.DataGridView LiteralesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}