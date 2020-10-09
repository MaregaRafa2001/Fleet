namespace Fleet
{
    partial class Motoristas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.motoristaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLEETDataSet = new Fleet.FLEETDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctSkinetButton1 = new CTSkinet.CTSkinetButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dATABASEDataSet = new Fleet.DATABASEDataSet();
            this.dATABASEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motoristaTableAdapter = new Fleet.FLEETDataSetTableAdapters.MotoristaTableAdapter();
            this.dATABASEDataSet1 = new Fleet.DATABASEDataSet1();
            this.btnMotorista_Alterar = new CTSkinet.CTSkinetButton();
            this.ctSkinetButton3 = new CTSkinet.CTSkinetButton();
            this.motoristasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgMotorista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEETDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotorista)).BeginInit();
            this.SuspendLayout();
            // 
            // motoristaBindingSource
            // 
            this.motoristaBindingSource.DataMember = "Motorista";
            this.motoristaBindingSource.DataSource = this.fLEETDataSet;
            // 
            // fLEETDataSet
            // 
            this.fLEETDataSet.DataSetName = "FLEETDataSet";
            this.fLEETDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(53, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 224);
            this.panel1.TabIndex = 30;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctSkinetButton1);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(21, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(929, 188);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Localizar por: ";
            // 
            // ctSkinetButton1
            // 
            this.ctSkinetButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetButton1.BackgroundImage = global::Fleet.Properties.Resources.magnifying_glass__1_;
            this.ctSkinetButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ctSkinetButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetButton1.FlatAppearance.BorderSize = 0;
            this.ctSkinetButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctSkinetButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetButton1.ForeColor = System.Drawing.SystemColors.Window;
            this.ctSkinetButton1.Location = new System.Drawing.Point(824, 112);
            this.ctSkinetButton1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetButton1.Margin = new System.Windows.Forms.Padding(4);
            this.ctSkinetButton1.Name = "ctSkinetButton1";
            this.ctSkinetButton1.Size = new System.Drawing.Size(39, 28);
            this.ctSkinetButton1.TabIndex = 4;
            this.ctSkinetButton1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(53, 108);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(821, 35);
            this.textBox2.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.LightGray;
            this.radioButton1.Location = new System.Drawing.Point(807, 47);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "CPF";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.LightGray;
            this.radioButton2.Location = new System.Drawing.Point(533, 47);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(156, 24);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "N. Registro CNH";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.LightGray;
            this.radioButton3.Location = new System.Drawing.Point(248, 47);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(150, 24);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Nome Completo";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.LightGray;
            this.radioButton4.Location = new System.Drawing.Point(53, 47);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(47, 24);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID";
            this.radioButton4.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel16.Controls.Add(this.pictureBox1);
            this.panel16.Location = new System.Drawing.Point(1057, 44);
            this.panel16.Margin = new System.Windows.Forms.Padding(4);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(405, 224);
            this.panel16.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Fleet.Properties.Resources.Veículos__4_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // dATABASEDataSet
            // 
            this.dATABASEDataSet.DataSetName = "DATABASEDataSet";
            this.dATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATABASEDataSetBindingSource
            // 
            this.dATABASEDataSetBindingSource.DataSource = this.dATABASEDataSet;
            this.dATABASEDataSetBindingSource.Position = 0;
            // 
            // motoristaTableAdapter
            // 
            this.motoristaTableAdapter.ClearBeforeFill = true;
            // 
            // dATABASEDataSet1
            // 
            this.dATABASEDataSet1.DataSetName = "DATABASEDataSet1";
            this.dATABASEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMotorista_Alterar
            // 
            this.btnMotorista_Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMotorista_Alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMotorista_Alterar.FlatAppearance.BorderSize = 0;
            this.btnMotorista_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMotorista_Alterar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMotorista_Alterar.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnMotorista_Alterar.Location = new System.Drawing.Point(1196, 805);
            this.btnMotorista_Alterar.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnMotorista_Alterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMotorista_Alterar.Name = "btnMotorista_Alterar";
            this.btnMotorista_Alterar.Size = new System.Drawing.Size(129, 37);
            this.btnMotorista_Alterar.TabIndex = 71;
            this.btnMotorista_Alterar.Text = "Alterar";
            this.btnMotorista_Alterar.UseVisualStyleBackColor = false;
            this.btnMotorista_Alterar.Click += new System.EventHandler(this.BtnMotorista_Alterar_Click);
            // 
            // ctSkinetButton3
            // 
            this.ctSkinetButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetButton3.FlatAppearance.BorderSize = 0;
            this.ctSkinetButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctSkinetButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSkinetButton3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.ctSkinetButton3.Location = new System.Drawing.Point(1333, 805);
            this.ctSkinetButton3.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ctSkinetButton3.Margin = new System.Windows.Forms.Padding(4);
            this.ctSkinetButton3.Name = "ctSkinetButton3";
            this.ctSkinetButton3.Size = new System.Drawing.Size(129, 37);
            this.ctSkinetButton3.TabIndex = 73;
            this.ctSkinetButton3.Text = "Excluir";
            this.ctSkinetButton3.UseVisualStyleBackColor = false;
            // 
            // motoristasBindingSource
            // 
            this.motoristasBindingSource.DataSource = typeof(Fleet.Motoristas);
            // 
            // dtgMotorista
            // 
            this.dtgMotorista.AllowUserToAddRows = false;
            this.dtgMotorista.AllowUserToDeleteRows = false;
            this.dtgMotorista.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtgMotorista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgMotorista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgMotorista.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgMotorista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dtgMotorista.Location = new System.Drawing.Point(53, 302);
            this.dtgMotorista.Margin = new System.Windows.Forms.Padding(4);
            this.dtgMotorista.Name = "dtgMotorista";
            this.dtgMotorista.ReadOnly = true;
            this.dtgMotorista.RowHeadersWidth = 51;
            this.dtgMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMotorista.Size = new System.Drawing.Size(1409, 495);
            this.dtgMotorista.TabIndex = 74;
            // 
            // Motoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.dtgMotorista);
            this.Controls.Add(this.ctSkinetButton3);
            this.Controls.Add(this.btnMotorista_Alterar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel16);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Motoristas";
            this.Size = new System.Drawing.Size(1584, 846);
            this.Load += new System.EventHandler(this.Motoristas_Load);
            this.Enter += new System.EventHandler(this.Motoristas_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.motoristaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLEETDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATABASEDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoristasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMotorista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private CTSkinet.CTSkinetButton ctSkinetButton1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.BindingSource dATABASEDataSetBindingSource;
        private DATABASEDataSet dATABASEDataSet;
        private System.Windows.Forms.BindingSource motoristaBindingSource;
        private FLEETDataSet fLEETDataSet;
        private System.Windows.Forms.BindingSource motoristasBindingSource;
        private FLEETDataSetTableAdapters.MotoristaTableAdapter motoristaTableAdapter;
        private DATABASEDataSet1 dATABASEDataSet1;
        private CTSkinet.CTSkinetButton btnMotorista_Alterar;
        private CTSkinet.CTSkinetButton ctSkinetButton3;
        private System.Windows.Forms.DataGridView dtgMotorista;
    }
}
