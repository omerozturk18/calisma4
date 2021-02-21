namespace KitapOkuma
{
    partial class KitapOku
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sp_kitapListeleTableAdapter = new KitapOkuma.kitapdfDataSet3TableAdapters.sp_kitapListeleTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kitapdfDataSet = new KitapOkuma.kitapdfDataSet();
            this.kitapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kitapTableAdapter = new KitapOkuma.kitapdfDataSetTableAdapters.kitapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spkitapListeleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdfDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdfDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).BeginInit();
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
            this.dataGridView1.DataSource = this.kitapBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seçili Kitap :";
            // 
            // sp_kitapListeleTableAdapter
            // 
            this.sp_kitapListeleTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Image = global::KitapOkuma.Properties.Resources.duzenle;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(473, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "DÜZENLE";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Image = global::KitapOkuma.Properties.Resources.ekle1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(40, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "EKLE";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Image = global::KitapOkuma.Properties.Resources.oku;
            this.button1.Location = new System.Drawing.Point(256, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "OKU";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kitapdfDataSet
            // 
            this.kitapdfDataSet.DataSetName = "kitapdfDataSet";
            this.kitapdfDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kitapBindingSource
            // 
            this.kitapBindingSource.DataMember = "kitap";
            this.kitapBindingSource.DataSource = this.kitapdfDataSet;
            // 
            // kitapTableAdapter
            // 
            this.kitapTableAdapter.ClearBeforeFill = true;
            // 
            // KitapOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KitapOku";
            this.Text = "KitapOku";
            this.Load += new System.EventHandler(this.KitapOku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spkitapListeleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdfDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapdfDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private kitapdfDataSet3 kitapdfDataSet3;
        private System.Windows.Forms.BindingSource spkitapListeleBindingSource;
        private kitapdfDataSet3TableAdapters.sp_kitapListeleTableAdapter sp_kitapListeleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapsayfasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapbasimyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitappdfadresDataGridViewTextBoxColumn;
        private kitapdfDataSet kitapdfDataSet;
        private System.Windows.Forms.BindingSource kitapBindingSource;
        private kitapdfDataSetTableAdapters.kitapTableAdapter kitapTableAdapter;
    }
}