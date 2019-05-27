namespace Proyecto_Conversor
{
    partial class VentanaReporte
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
            this.midatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.midatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // midatagrid
            // 
            this.midatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.midatagrid.Location = new System.Drawing.Point(28, 63);
            this.midatagrid.Name = "midatagrid";
            this.midatagrid.Size = new System.Drawing.Size(508, 269);
            this.midatagrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPERACIONES REALIZADAS POR EL USUARIO";
            // 
            // VentanaReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.midatagrid);
            this.Name = "VentanaReporte";
            this.Text = "VentanaReporte";
            this.Load += new System.EventHandler(this.VentanaReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.midatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView midatagrid;
        private System.Windows.Forms.Label label1;


    }
}