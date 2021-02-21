namespace KitapOkuma
{
    partial class KitapSil
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapsayfasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapbasimyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitappdfadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spkitapListeleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapdfDataSet3 = new KitapOkuma.kitapdfDataSet3();
            this.sp_kitapListeleTableAdapter = new KitapOkuma.kitapdfDataSet3TableAdapters.sp_kitapListeleTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spkitapListeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdfDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapnoDataGridViewTextBoxColumn,
            this.kitapadiDataGridViewTextBoxColumn,
            this.kitapyazariDataGridViewTextBoxColumn,
            this.kitapsayfasiDataGridViewTextBoxColumn,
            this.kitapbasimyiliDataGridViewTextBoxColumn,
            this.kitappdfadresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spkitapListeleBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // kitapnoDataGridViewTextBoxColumn
            // 
            this.kitapnoDataGridViewTextBoxColumn.DataPropertyName = "kitap_no";
            this.kitapnoDataGridViewTextBoxColumn.HeaderText = "kitap_no";
            this.kitapnoDataGridViewTextBoxColumn.Name = "kitapnoDataGridViewTextBoxColumn";
            this.kitapnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kitapadiDataGridViewTextBoxColumn
            // 
            this.kitapadiDataGridViewTextBoxColumn.DataPropertyName = "kitap_adi";
            this.kitapadiDataGridViewTextBoxColumn.HeaderText = "kitap_adi";
            this.kitapadiDataGridViewTextBoxColumn.Name = "kitapadiDataGridViewTextBoxColumn";
            // 
            // kitapyazariDataGridViewTextBoxColumn
            // 
            this.kitapyazariDataGridViewTextBoxColumn.DataPropertyName = "kitap_yazari";
            this.kitapyazariDataGridViewTextBoxColumn.HeaderText = "kitap_yazari";
            this.kitapyazariDataGridViewTextBoxColumn.Name = "kitapyazariDataGridViewTextBoxColumn";
            // 
            // kitapsayfasiDataGridViewTextBoxColumn
            // 
            this.kitapsayfasiDataGridViewTextBoxColumn.DataPropertyName = "kitap_sayfasi";
            this.kitapsayfasiDataGridViewTextBoxColumn.HeaderText = "kitap_sayfasi";
            this.kitapsayfasiDataGridViewTextBoxColumn.Name = "kitapsayfasiDataGridViewTextBoxColumn";
            // 
            // kitapbasimyiliDataGridViewTextBoxColumn
            // 
            this.kitapbasimyiliDataGridViewTextBoxColumn.DataPropertyName = "kitap_basimyili";
            this.kitapbasimyiliDataGridViewTextBoxColumn.HeaderText = "kitap_basimyili";
            this.kitapbasimyiliDataGridViewTextBoxColumn.Name = "kitapbasimyiliDataGridViewTextBoxColumn";
            // 
            // kitappdfadresDataGridViewTextBoxColumn
            // 
            this.kitappdfadresDataGridViewTextBoxColumn.DataPropertyName = "kitap_pdfadres";
            this.kitappdfadresDataGridViewTextBoxColumn.HeaderText = "kitap_pdfadres";
            this.kitappdfadresDataGridViewTextBoxColumn.Name = "kitappdfadresDataGridViewTextBoxColumn";
            // 
            // spkitapListeleBindingSource
            // 
            this.spkitapListeleBindingSource.DataMember = "sp_kitapListele";
            this.spkitapListeleBindingSource.DataSource = this.kitapdfDataSet3;
            // 
            // kitapdfDataSet3
            // 
            this.kitapdfDataSet3.DataSetName = "kitapdfDataSet3";
            this.kitapdfDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_kitapListeleTableAdapter
            // 
            this.sp_kitapListeleTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(234, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(234, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(76, 100);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(234, 20);
            this.textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(76, 126);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(234, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(76, 152);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(234, 20);
            this.textBox6.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kitap No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kitap Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yazar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Sayfa :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Basım Yılı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Adres :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 72);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 72);
            this.button2.TabIndex = 13;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(316, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Dosya Seç";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 398);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KitapSil";
            this.Text = "KitapSil";
            this.Load += new System.EventHandler(this.KitapSil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spkitapListeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdfDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kitapdfDataSet3 kitapdfDataSet3;
        private System.Windows.Forms.BindingSource spkitapListeleBindingSource;
        private kitapdfDataSet3TableAdapters.sp_kitapListeleTableAdapter sp_kitapListeleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapsayfasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapbasimyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappdfadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}