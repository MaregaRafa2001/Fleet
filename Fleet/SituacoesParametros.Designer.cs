namespace Fleet
{
    partial class SituacoesParametros
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
            this.ctSkinetTitleBar1 = new CTSkinet.CTSkinetTitleBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ctSkinetButton2 = new CTSkinet.CTSkinetButton();
            this.SuspendLayout();
            // 
            // ctSkinetTitleBar1
            // 
            this.ctSkinetTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctSkinetTitleBar1.FormMaximize = true;
            this.ctSkinetTitleBar1.FormMoveable = false;
            this.ctSkinetTitleBar1.FormResize = false;
            this.ctSkinetTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.ctSkinetTitleBar1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetTitleBar1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ctSkinetTitleBar1.MinimumSize = new System.Drawing.Size(200, 40);
            this.ctSkinetTitleBar1.Name = "ctSkinetTitleBar1";
            this.ctSkinetTitleBar1.Size = new System.Drawing.Size(253, 40);
            this.ctSkinetTitleBar1.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.LightGray;
            this.textBox4.Location = new System.Drawing.Point(12, 86);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 25);
            this.textBox4.TabIndex = 59;
            this.textBox4.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(7, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 30);
            this.label12.TabIndex = 60;
            this.label12.Text = "Situação:";
            // 
            // ctSkinetButton2
            // 
            this.ctSkinetButton2.BackColor = System.Drawing.Color.LawnGreen;
            this.ctSkinetButton2.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.ctSkinetButton2.FlatAppearance.BorderSize = 0;
            this.ctSkinetButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctSkinetButton2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetButton2.ForeColor = System.Drawing.Color.Black;
            this.ctSkinetButton2.Location = new System.Drawing.Point(158, 123);
            this.ctSkinetButton2.MainColor = System.Drawing.Color.LawnGreen;
            this.ctSkinetButton2.Name = "ctSkinetButton2";
            this.ctSkinetButton2.Size = new System.Drawing.Size(83, 27);
            this.ctSkinetButton2.TabIndex = 66;
            this.ctSkinetButton2.Text = "Adicionar";
            this.ctSkinetButton2.UseVisualStyleBackColor = false;
            // 
            // SituacoesParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(253, 162);
            this.Controls.Add(this.ctSkinetButton2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ctSkinetTitleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "SituacoesParametros";
            this.Text = "SituacoesParametros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTSkinet.CTSkinetTitleBar ctSkinetTitleBar1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label12;
        private CTSkinet.CTSkinetButton ctSkinetButton2;
    }
}