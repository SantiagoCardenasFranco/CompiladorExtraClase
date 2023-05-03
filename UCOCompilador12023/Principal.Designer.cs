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
            this.tabControl1.SuspendLayout();
            this.principalMenu.SuspendLayout();
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
    }
}