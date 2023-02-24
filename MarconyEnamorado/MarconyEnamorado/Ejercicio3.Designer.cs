namespace MarconyEnamorado
{
    partial class Ejercicio3
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
            this.NumerolistBox = new System.Windows.Forms.ListBox();
            this.MostrarNumerobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NumerolistBox
            // 
            this.NumerolistBox.FormattingEnabled = true;
            this.NumerolistBox.ItemHeight = 18;
            this.NumerolistBox.Location = new System.Drawing.Point(57, 50);
            this.NumerolistBox.Name = "NumerolistBox";
            this.NumerolistBox.Size = new System.Drawing.Size(202, 148);
            this.NumerolistBox.TabIndex = 0;
            // 
            // MostrarNumerobutton
            // 
            this.MostrarNumerobutton.Location = new System.Drawing.Point(68, 220);
            this.MostrarNumerobutton.Name = "MostrarNumerobutton";
            this.MostrarNumerobutton.Size = new System.Drawing.Size(171, 47);
            this.MostrarNumerobutton.TabIndex = 1;
            this.MostrarNumerobutton.Text = "Mostrar Numeros";
            this.MostrarNumerobutton.UseVisualStyleBackColor = true;
            this.MostrarNumerobutton.Click += new System.EventHandler(this.MostrarNumerobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numeros Multiplos de 3 y 5";
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MostrarNumerobutton);
            this.Controls.Add(this.NumerolistBox);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NumerolistBox;
        private System.Windows.Forms.Button MostrarNumerobutton;
        private System.Windows.Forms.Label label1;
    }
}