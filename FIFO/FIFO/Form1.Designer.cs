namespace FIFO
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelEmpty = new System.Windows.Forms.Label();
            this.labelUnTask = new System.Windows.Forms.Label();
            this.labelCoTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelEmpty
            // 
            this.labelEmpty.AutoSize = true;
            this.labelEmpty.Location = new System.Drawing.Point(13, 12);
            this.labelEmpty.Name = "labelEmpty";
            this.labelEmpty.Size = new System.Drawing.Size(69, 13);
            this.labelEmpty.TabIndex = 1;
            this.labelEmpty.Text = "Empty cicles:";
            // 
            // labelUnTask
            // 
            this.labelUnTask.AutoSize = true;
            this.labelUnTask.Location = new System.Drawing.Point(13, 35);
            this.labelUnTask.Name = "labelUnTask";
            this.labelUnTask.Size = new System.Drawing.Size(101, 13);
            this.labelUnTask.TabIndex = 2;
            this.labelUnTask.Text = "Uncompleted tasks:";
            // 
            // labelCoTask
            // 
            this.labelCoTask.AutoSize = true;
            this.labelCoTask.Location = new System.Drawing.Point(13, 61);
            this.labelCoTask.Name = "labelCoTask";
            this.labelCoTask.Size = new System.Drawing.Size(88, 13);
            this.labelCoTask.TabIndex = 3;
            this.labelCoTask.Text = "Completed tasks:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 260);
            this.Controls.Add(this.labelCoTask);
            this.Controls.Add(this.labelUnTask);
            this.Controls.Add(this.labelEmpty);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelEmpty;
        private System.Windows.Forms.Label labelUnTask;
        private System.Windows.Forms.Label labelCoTask;
    }
}

