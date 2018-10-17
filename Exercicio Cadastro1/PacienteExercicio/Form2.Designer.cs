namespace PacienteExercicio
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
            this.ucDetalhePaciente1 = new PacienteExercicio.ucDetalhePaciente();
            this.SuspendLayout();
            // 
            // ucDetalhePaciente1
            // 
            this.ucDetalhePaciente1.Location = new System.Drawing.Point(96, 57);
            this.ucDetalhePaciente1.Name = "ucDetalhePaciente1";
            this.ucDetalhePaciente1.Size = new System.Drawing.Size(365, 90);
            this.ucDetalhePaciente1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 258);
            this.Controls.Add(this.ucDetalhePaciente1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private ucDetalhePaciente ucDetalhePaciente1;
    }
}