namespace WindowsFormsApp1
{
    partial class Form2
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.rbOpcion1 = new System.Windows.Forms.RadioButton();
            this.rbOpcion2 = new System.Windows.Forms.RadioButton();
            this.rbOpcion3 = new System.Windows.Forms.RadioButton();
            this.rbOpcion4 = new System.Windows.Forms.RadioButton();
            this.rbVerdadero = new System.Windows.Forms.RadioButton();
            this.rbFalso = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(40, 71);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(78, 16);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "pregunta hp";
            // 
            // rbOpcion1
            // 
            this.rbOpcion1.AutoSize = true;
            this.rbOpcion1.Location = new System.Drawing.Point(218, 71);
            this.rbOpcion1.Name = "rbOpcion1";
            this.rbOpcion1.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion1.TabIndex = 1;
            this.rbOpcion1.TabStop = true;
            this.rbOpcion1.Text = "radioButton1";
            this.rbOpcion1.UseVisualStyleBackColor = true;
            // 
            // rbOpcion2
            // 
            this.rbOpcion2.AutoSize = true;
            this.rbOpcion2.Location = new System.Drawing.Point(218, 97);
            this.rbOpcion2.Name = "rbOpcion2";
            this.rbOpcion2.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion2.TabIndex = 2;
            this.rbOpcion2.TabStop = true;
            this.rbOpcion2.Text = "radioButton2";
            this.rbOpcion2.UseVisualStyleBackColor = true;
            // 
            // rbOpcion3
            // 
            this.rbOpcion3.AutoSize = true;
            this.rbOpcion3.Location = new System.Drawing.Point(218, 123);
            this.rbOpcion3.Name = "rbOpcion3";
            this.rbOpcion3.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion3.TabIndex = 3;
            this.rbOpcion3.TabStop = true;
            this.rbOpcion3.Text = "radioButton3";
            this.rbOpcion3.UseVisualStyleBackColor = true;
            // 
            // rbOpcion4
            // 
            this.rbOpcion4.AutoSize = true;
            this.rbOpcion4.Location = new System.Drawing.Point(218, 149);
            this.rbOpcion4.Name = "rbOpcion4";
            this.rbOpcion4.Size = new System.Drawing.Size(103, 20);
            this.rbOpcion4.TabIndex = 4;
            this.rbOpcion4.TabStop = true;
            this.rbOpcion4.Text = "radioButton4";
            this.rbOpcion4.UseVisualStyleBackColor = true;
            // 
            // rbVerdadero
            // 
            this.rbVerdadero.AutoSize = true;
            this.rbVerdadero.Location = new System.Drawing.Point(218, 71);
            this.rbVerdadero.Name = "rbVerdadero";
            this.rbVerdadero.Size = new System.Drawing.Size(97, 20);
            this.rbVerdadero.TabIndex = 5;
            this.rbVerdadero.TabStop = true;
            this.rbVerdadero.Text = "Verdadero";
            this.rbVerdadero.UseVisualStyleBackColor = true;
            this.rbVerdadero.Visible = false; // Inicialmente oculto
            // 
            // rbFalso
            // 
            this.rbFalso.AutoSize = true;
            this.rbFalso.Location = new System.Drawing.Point(218, 97);
            this.rbFalso.Name = "rbFalso";
            this.rbFalso.Size = new System.Drawing.Size(62, 20);
            this.rbFalso.TabIndex = 6;
            this.rbFalso.TabStop = true;
            this.rbFalso.Text = "Falso";
            this.rbFalso.UseVisualStyleBackColor = true;
            this.rbFalso.Visible = false; // Inicialmente oculto
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(228, 214);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(529, 75);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(51, 16);
            this.lblPuntaje.TabIndex = 8;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPuntaje);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.rbFalso);
            this.Controls.Add(this.rbVerdadero);
            this.Controls.Add(this.rbOpcion4);
            this.Controls.Add(this.rbOpcion3);
            this.Controls.Add(this.rbOpcion2);
            this.Controls.Add(this.rbOpcion1);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.RadioButton rbOpcion1;
        private System.Windows.Forms.RadioButton rbOpcion2;
        private System.Windows.Forms.RadioButton rbOpcion3;
        private System.Windows.Forms.RadioButton rbOpcion4;
        private System.Windows.Forms.RadioButton rbVerdadero;
        private System.Windows.Forms.RadioButton rbFalso;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblPuntaje;
    }
}
