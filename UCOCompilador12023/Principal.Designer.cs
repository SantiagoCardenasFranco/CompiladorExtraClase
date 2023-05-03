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
            this.Buscar = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Compilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(135, 39);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 0;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(246, 41);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(408, 20);
            this.url.TabIndex = 1;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(280, 124);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(280, 220);
            this.info.TabIndex = 2;
            this.info.TextChanged += new System.EventHandler(this.info_TextChanged);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(280, 381);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Compilar
            // 
            this.Compilar.Location = new System.Drawing.Point(485, 381);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(75, 23);
            this.Compilar.TabIndex = 4;
            this.Compilar.Text = "Compilar";
            this.Compilar.UseVisualStyleBackColor = true;
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Compilar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.info);
            this.Controls.Add(this.url);
            this.Controls.Add(this.Buscar);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Compilar;
    }
}