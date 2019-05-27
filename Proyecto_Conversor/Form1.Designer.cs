namespace Proyecto_Conversor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textEntrada = new System.Windows.Forms.TextBox();
            this.textSalida = new System.Windows.Forms.TextBox();
            this.buttonConvertir = new System.Windows.Forms.Button();
            this.listEntrada = new System.Windows.Forms.ListBox();
            this.listSalida = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botonDesplegar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GrayText;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarConversionToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.fileToolStripMenuItem.Text = "Archivo";
            // 
            // personalizarConversionToolStripMenuItem
            // 
            this.personalizarConversionToolStripMenuItem.Name = "personalizarConversionToolStripMenuItem";
            this.personalizarConversionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.personalizarConversionToolStripMenuItem.Text = "Personalizar Conversion";
            this.personalizarConversionToolStripMenuItem.Click += new System.EventHandler(this.personalizarConversionToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ayudaToolStripMenuItem.Text = "Manual de Usuario";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verReporteToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem1.Text = "Reporte";
            // 
            // verReporteToolStripMenuItem
            // 
            this.verReporteToolStripMenuItem.Name = "verReporteToolStripMenuItem";
            this.verReporteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.verReporteToolStripMenuItem.Text = "Ver Reporte";
            this.verReporteToolStripMenuItem.Click += new System.EventHandler(this.verReporteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTRADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "SALIDA";
            // 
            // textEntrada
            // 
            this.textEntrada.Location = new System.Drawing.Point(107, 275);
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.Size = new System.Drawing.Size(162, 20);
            this.textEntrada.TabIndex = 3;
            this.textEntrada.TextChanged += new System.EventHandler(this.textEntrada_TextChanged);
            this.textEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEntrada_KeyPress);
            // 
            // textSalida
            // 
            this.textSalida.Location = new System.Drawing.Point(107, 306);
            this.textSalida.Name = "textSalida";
            this.textSalida.Size = new System.Drawing.Size(162, 20);
            this.textSalida.TabIndex = 4;
            this.textSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSalida_KeyPress);
            // 
            // buttonConvertir
            // 
            this.buttonConvertir.Location = new System.Drawing.Point(479, 299);
            this.buttonConvertir.Name = "buttonConvertir";
            this.buttonConvertir.Size = new System.Drawing.Size(75, 23);
            this.buttonConvertir.TabIndex = 5;
            this.buttonConvertir.Text = "Convertir";
            this.buttonConvertir.UseVisualStyleBackColor = true;
            this.buttonConvertir.Click += new System.EventHandler(this.buttonConvertir_Click);
            // 
            // listEntrada
            // 
            this.listEntrada.FormattingEnabled = true;
            this.listEntrada.Location = new System.Drawing.Point(25, 82);
            this.listEntrada.Name = "listEntrada";
            this.listEntrada.Size = new System.Drawing.Size(230, 160);
            this.listEntrada.TabIndex = 6;
            this.listEntrada.SelectedIndexChanged += new System.EventHandler(this.listEntrada_SelectedIndexChanged);
            // 
            // listSalida
            // 
            this.listSalida.FormattingEnabled = true;
            this.listSalida.Location = new System.Drawing.Point(301, 82);
            this.listSalida.Name = "listSalida";
            this.listSalida.Size = new System.Drawing.Size(253, 160);
            this.listSalida.TabIndex = 7;
            this.listSalida.SelectedIndexChanged += new System.EventHandler(this.listSalida_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Unidad Entrada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Unidad Salida";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Longitud",
            "Masa",
            "Tiempo",
            "Moneda",
            "Velocidad",
            "Angulos",
            "Temperatura",
            "Presion",
            "Volumen",
            "Area",
            "Densidad",
            "Fuerza",
            "Personalizado"});
            this.comboCategoria.Location = new System.Drawing.Point(84, 27);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Categoría";
            // 
            // botonDesplegar
            // 
            this.botonDesplegar.Location = new System.Drawing.Point(231, 27);
            this.botonDesplegar.Name = "botonDesplegar";
            this.botonDesplegar.Size = new System.Drawing.Size(158, 23);
            this.botonDesplegar.TabIndex = 12;
            this.botonDesplegar.Text = "Desplegar Unidades";
            this.botonDesplegar.UseVisualStyleBackColor = true;
            this.botonDesplegar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 346);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botonDesplegar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listSalida);
            this.Controls.Add(this.listEntrada);
            this.Controls.Add(this.buttonConvertir);
            this.Controls.Add(this.textSalida);
            this.Controls.Add(this.textEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarConversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEntrada;
        private System.Windows.Forms.TextBox textSalida;
        private System.Windows.Forms.Button buttonConvertir;
        private System.Windows.Forms.ListBox listEntrada;
        private System.Windows.Forms.ListBox listSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botonDesplegar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verReporteToolStripMenuItem;
    }
}

