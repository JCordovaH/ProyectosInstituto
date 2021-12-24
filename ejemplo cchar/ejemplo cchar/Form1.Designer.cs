namespace ejemplo_cchar
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
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.txtnum2 = new System.Windows.Forms.Label();
            this.cmdaceptar = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnum2
            // 
            this.txtnum2.AutoSize = true;
            this.txtnum2.Location = new System.Drawing.Point(12, 9);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(35, 13);
            this.txtnum2.TabIndex = 0;
            this.txtnum2.Text = "label1";
            // 
            // cmdaceptar
            // 
            this.cmdaceptar.Location = new System.Drawing.Point(205, 238);
            this.cmdaceptar.Name = "cmdaceptar";
            this.cmdaceptar.Size = new System.Drawing.Size(75, 23);
            this.cmdaceptar.TabIndex = 1;
            this.cmdaceptar.Text = "Aceptar";
            this.cmdaceptar.UseVisualStyleBackColor = true;
            this.cmdaceptar.Click += new System.EventHandler(this.cmdaceptar_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(79, 6);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.cmdaceptar);
            this.Controls.Add(this.txtnum2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnum2;
        private System.Windows.Forms.Button cmdaceptar;
        private System.Windows.Forms.TextBox txtnum1;
    }
}

