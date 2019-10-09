namespace Client
{
    partial class MainClient
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServerResult = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtServerResult
            // 
            this.txtServerResult.BackColor = System.Drawing.Color.Black;
            this.txtServerResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerResult.Font = new System.Drawing.Font("ArcadeClassic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerResult.ForeColor = System.Drawing.Color.Black;
            this.txtServerResult.Location = new System.Drawing.Point(620, 273);
            this.txtServerResult.Name = "txtServerResult";
            this.txtServerResult.ReadOnly = true;
            this.txtServerResult.Size = new System.Drawing.Size(24, 16);
            this.txtServerResult.TabIndex = 0;
            this.txtServerResult.Visible = false;
            this.txtServerResult.TextChanged += new System.EventHandler(this.txtServerResult_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(416, 162);
            this.listBox1.TabIndex = 1;
            // 
            // MainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(656, 301);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtServerResult);
            this.Name = "MainClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServerResult;
        private System.Windows.Forms.ListBox listBox1;
    }
}

