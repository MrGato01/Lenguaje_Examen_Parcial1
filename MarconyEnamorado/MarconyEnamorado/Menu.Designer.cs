namespace MarconyEnamorado
{
    partial class Menu
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
            this.Ejercicio1button = new System.Windows.Forms.Button();
            this.Ejercicio2button = new System.Windows.Forms.Button();
            this.Ejercicio3button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ejercicio1button
            // 
            this.Ejercicio1button.Location = new System.Drawing.Point(13, 65);
            this.Ejercicio1button.Margin = new System.Windows.Forms.Padding(4);
            this.Ejercicio1button.Name = "Ejercicio1button";
            this.Ejercicio1button.Size = new System.Drawing.Size(112, 32);
            this.Ejercicio1button.TabIndex = 0;
            this.Ejercicio1button.Text = "Ejercicio 1";
            this.Ejercicio1button.UseVisualStyleBackColor = true;
            this.Ejercicio1button.Click += new System.EventHandler(this.Ejercicio1button_Click);
            // 
            // Ejercicio2button
            // 
            this.Ejercicio2button.Location = new System.Drawing.Point(133, 65);
            this.Ejercicio2button.Margin = new System.Windows.Forms.Padding(4);
            this.Ejercicio2button.Name = "Ejercicio2button";
            this.Ejercicio2button.Size = new System.Drawing.Size(112, 32);
            this.Ejercicio2button.TabIndex = 1;
            this.Ejercicio2button.Text = "Ejercicio 2";
            this.Ejercicio2button.UseVisualStyleBackColor = true;
            this.Ejercicio2button.Click += new System.EventHandler(this.Ejercicio2button_Click);
            // 
            // Ejercicio3button
            // 
            this.Ejercicio3button.Location = new System.Drawing.Point(253, 65);
            this.Ejercicio3button.Margin = new System.Windows.Forms.Padding(4);
            this.Ejercicio3button.Name = "Ejercicio3button";
            this.Ejercicio3button.Size = new System.Drawing.Size(105, 32);
            this.Ejercicio3button.TabIndex = 2;
            this.Ejercicio3button.Text = "Ejercicio 3";
            this.Ejercicio3button.UseVisualStyleBackColor = true;
            this.Ejercicio3button.Click += new System.EventHandler(this.Ejercicio3button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ejercicios de Examen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarconyEnamorado.Properties.Resources.bad_company_hd_wallpapers_top_desktop_images;
            this.pictureBox1.Location = new System.Drawing.Point(27, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(312, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ejercicio3button);
            this.Controls.Add(this.Ejercicio2button);
            this.Controls.Add(this.Ejercicio1button);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Ejercicios";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ejercicio1button;
        private System.Windows.Forms.Button Ejercicio2button;
        private System.Windows.Forms.Button Ejercicio3button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

