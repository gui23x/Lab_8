
namespace lab_8.LabCalculos.Lab07
{
    partial class Telaprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telaprincipal));
            this.lblValor1 = new System.Windows.Forms.Label();
            this.nudValor1 = new System.Windows.Forms.NumericUpDown();
            this.nudValor2 = new System.Windows.Forms.NumericUpDown();
            this.nudValor3 = new System.Windows.Forms.NumericUpDown();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.lblValor3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor1
            // 
            this.lblValor1.AutoSize = true;
            this.lblValor1.Location = new System.Drawing.Point(48, 28);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(42, 15);
            this.lblValor1.TabIndex = 0;
            this.lblValor1.Text = "Valor 1";
            // 
            // nudValor1
            // 
            this.nudValor1.Location = new System.Drawing.Point(112, 26);
            this.nudValor1.Name = "nudValor1";
            this.nudValor1.Size = new System.Drawing.Size(120, 23);
            this.nudValor1.TabIndex = 1;
            // 
            // nudValor2
            // 
            this.nudValor2.Location = new System.Drawing.Point(112, 77);
            this.nudValor2.Name = "nudValor2";
            this.nudValor2.Size = new System.Drawing.Size(120, 23);
            this.nudValor2.TabIndex = 2;
            // 
            // nudValor3
            // 
            this.nudValor3.Location = new System.Drawing.Point(112, 125);
            this.nudValor3.Name = "nudValor3";
            this.nudValor3.Size = new System.Drawing.Size(120, 23);
            this.nudValor3.TabIndex = 3;
            // 
            // lblValor2
            // 
            this.lblValor2.AutoSize = true;
            this.lblValor2.Location = new System.Drawing.Point(48, 79);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(42, 15);
            this.lblValor2.TabIndex = 4;
            this.lblValor2.Text = "Valor 2";
            // 
            // lblValor3
            // 
            this.lblValor3.AutoSize = true;
            this.lblValor3.Location = new System.Drawing.Point(48, 127);
            this.lblValor3.Name = "lblValor3";
            this.lblValor3.Size = new System.Drawing.Size(42, 15);
            this.lblValor3.TabIndex = 5;
            this.lblValor3.Text = "Valor 3";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(48, 162);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.BackColor = System.Drawing.SystemColors.Menu;
            this.lblResultado.Location = new System.Drawing.Point(48, 222);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(310, 156);
            this.lblResultado.TabIndex = 7;
            // 
            // Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(414, 451);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValor3);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.nudValor3);
            this.Controls.Add(this.nudValor2);
            this.Controls.Add(this.nudValor1);
            this.Controls.Add(this.lblValor1);
            this.Name = "Telaprincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cálculo";
            ((System.ComponentModel.ISupportInitialize)(this.nudValor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.NumericUpDown nudValor1;
        private System.Windows.Forms.NumericUpDown nudValor2;
        private System.Windows.Forms.NumericUpDown nudValor3;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label lblValor3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}