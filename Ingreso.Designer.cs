namespace CalculadoraAgiles
{
    partial class Ingreso
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
            this.btnSuma = new System.Windows.Forms.Button();
            this.tf_Int1 = new System.Windows.Forms.TextBox();
            this.tf_Int2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(367, 165);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(75, 23);
            this.btnSuma.TabIndex = 0;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // tf_Int1
            // 
            this.tf_Int1.Location = new System.Drawing.Point(235, 85);
            this.tf_Int1.Name = "tf_Int1";
            this.tf_Int1.Size = new System.Drawing.Size(100, 20);
            this.tf_Int1.TabIndex = 2;
            // 
            // tf_Int2
            // 
            this.tf_Int2.Location = new System.Drawing.Point(491, 85);
            this.tf_Int2.Name = "tf_Int2";
            this.tf_Int2.Size = new System.Drawing.Size(100, 20);
            this.tf_Int2.TabIndex = 3;
            // 
            // Ingreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tf_Int2);
            this.Controls.Add(this.tf_Int1);
            this.Controls.Add(this.btnSuma);
            this.Name = "Ingreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox tf_Int1;
        private System.Windows.Forms.TextBox tf_Int2;
    }
}