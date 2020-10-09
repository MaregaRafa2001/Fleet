namespace Fleet
{
    partial class Contrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contrato));
            this.ctSkinetTitleBar1 = new CTSkinet.CTSkinetTitleBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ctSkinetButton1 = new CTSkinet.CTSkinetButton();
            this.SuspendLayout();
            // 
            // ctSkinetTitleBar1
            // 
            this.ctSkinetTitleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetTitleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctSkinetTitleBar1.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetTitleBar1.FormMaximize = true;
            this.ctSkinetTitleBar1.FormMoveable = false;
            this.ctSkinetTitleBar1.FormResize = false;
            this.ctSkinetTitleBar1.Location = new System.Drawing.Point(0, 0);
            this.ctSkinetTitleBar1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetTitleBar1.MaximumSize = new System.Drawing.Size(0, 40);
            this.ctSkinetTitleBar1.MinimumSize = new System.Drawing.Size(200, 40);
            this.ctSkinetTitleBar1.Name = "ctSkinetTitleBar1";
            this.ctSkinetTitleBar1.Size = new System.Drawing.Size(370, 40);
            this.ctSkinetTitleBar1.TabIndex = 0;
            this.ctSkinetTitleBar1.Text = "Contrato de Aluguel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 336);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 176);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(15, 554);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(257, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Eu li e concordo com os termos acima.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ctSkinetButton1
            // 
            this.ctSkinetButton1.BackColor = System.Drawing.Color.LawnGreen;
            this.ctSkinetButton1.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.ctSkinetButton1.FlatAppearance.BorderSize = 0;
            this.ctSkinetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctSkinetButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetButton1.ForeColor = System.Drawing.Color.Black;
            this.ctSkinetButton1.Location = new System.Drawing.Point(278, 551);
            this.ctSkinetButton1.MainColor = System.Drawing.Color.LawnGreen;
            this.ctSkinetButton1.Name = "ctSkinetButton1";
            this.ctSkinetButton1.Size = new System.Drawing.Size(71, 23);
            this.ctSkinetButton1.TabIndex = 6;
            this.ctSkinetButton1.Text = "Aceitar";
            this.ctSkinetButton1.UseVisualStyleBackColor = false;
            this.ctSkinetButton1.Click += new System.EventHandler(this.ctSkinetButton1_Click);
            // 
            // Contrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(370, 586);
            this.Controls.Add(this.ctSkinetButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctSkinetTitleBar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1366, 728);
            this.Name = "Contrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CTSkinet.CTSkinetTitleBar ctSkinetTitleBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private CTSkinet.CTSkinetButton ctSkinetButton1;
    }
}