namespace RecycleCoinProject
{
    partial class GeriDonusum
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
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarbon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nesneIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nesneAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nesneDegeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nesnelerTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recycleCoinDataSet = new RecycleCoinProject.RecycleCoinDataSet();
            this.nesnelerTblTableAdapter = new RecycleCoinProject.RecycleCoinDataSetTableAdapters.NesnelerTblTableAdapter();
            this.lblnesne = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtadet = new System.Windows.Forms.TextBox();
            this.lbldeger = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsondeger = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltoplamcarbon = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nesnelerTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleCoinDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(182, 23);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(24, 28);
            this.lblTC.TabIndex = 30;
            this.lblTC.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "TC :";
            // 
            // lblCarbon
            // 
            this.lblCarbon.AutoSize = true;
            this.lblCarbon.Location = new System.Drawing.Point(182, 65);
            this.lblCarbon.Name = "lblCarbon";
            this.lblCarbon.Size = new System.Drawing.Size(24, 28);
            this.lblCarbon.TabIndex = 32;
            this.lblCarbon.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Carbon Değerin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "NESNE DÖNÜŞÜMÜ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nesneIDDataGridViewTextBoxColumn,
            this.nesneAdDataGridViewTextBoxColumn,
            this.nesneDegeriDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nesnelerTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(406, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(657, 292);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nesneIDDataGridViewTextBoxColumn
            // 
            this.nesneIDDataGridViewTextBoxColumn.DataPropertyName = "NesneID";
            this.nesneIDDataGridViewTextBoxColumn.HeaderText = "NesneID";
            this.nesneIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nesneIDDataGridViewTextBoxColumn.Name = "nesneIDDataGridViewTextBoxColumn";
            this.nesneIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nesneAdDataGridViewTextBoxColumn
            // 
            this.nesneAdDataGridViewTextBoxColumn.DataPropertyName = "NesneAd";
            this.nesneAdDataGridViewTextBoxColumn.HeaderText = "NesneAd";
            this.nesneAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nesneAdDataGridViewTextBoxColumn.Name = "nesneAdDataGridViewTextBoxColumn";
            // 
            // nesneDegeriDataGridViewTextBoxColumn
            // 
            this.nesneDegeriDataGridViewTextBoxColumn.DataPropertyName = "NesneDegeri";
            this.nesneDegeriDataGridViewTextBoxColumn.HeaderText = "NesneDegeri";
            this.nesneDegeriDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nesneDegeriDataGridViewTextBoxColumn.Name = "nesneDegeriDataGridViewTextBoxColumn";
            // 
            // nesnelerTblBindingSource
            // 
            this.nesnelerTblBindingSource.DataMember = "NesnelerTbl";
            this.nesnelerTblBindingSource.DataSource = this.recycleCoinDataSet;
            // 
            // recycleCoinDataSet
            // 
            this.recycleCoinDataSet.DataSetName = "RecycleCoinDataSet";
            this.recycleCoinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nesnelerTblTableAdapter
            // 
            this.nesnelerTblTableAdapter.ClearBeforeFill = true;
            // 
            // lblnesne
            // 
            this.lblnesne.AutoSize = true;
            this.lblnesne.Location = new System.Drawing.Point(127, 216);
            this.lblnesne.Name = "lblnesne";
            this.lblnesne.Size = new System.Drawing.Size(168, 28);
            this.lblnesne.TabIndex = 33;
            this.lblnesne.Text = "0,5 Litre Pet Şişe";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(576, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(344, 45);
            this.label18.TabIndex = 49;
            this.label18.Text = "NESNELER BİLGİLERİ";
            // 
            // txtadet
            // 
            this.txtadet.Location = new System.Drawing.Point(173, 326);
            this.txtadet.Name = "txtadet";
            this.txtadet.Size = new System.Drawing.Size(196, 36);
            this.txtadet.TabIndex = 50;
            // 
            // lbldeger
            // 
            this.lbldeger.AutoSize = true;
            this.lbldeger.Location = new System.Drawing.Point(182, 264);
            this.lbldeger.Name = "lbldeger";
            this.lbldeger.Size = new System.Drawing.Size(46, 28);
            this.lbldeger.TabIndex = 51;
            this.lbldeger.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 52;
            this.label5.Text = "Sayı Adedi :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(12, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 61);
            this.button1.TabIndex = 53;
            this.button1.Text = "Carbon Değerini Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 54;
            this.label4.Text = "Carbon Değeri : ";
            // 
            // lblsondeger
            // 
            this.lblsondeger.AutoSize = true;
            this.lblsondeger.Location = new System.Drawing.Point(262, 379);
            this.lblsondeger.Name = "lblsondeger";
            this.lblsondeger.Size = new System.Drawing.Size(24, 28);
            this.lblsondeger.TabIndex = 55;
            this.lblsondeger.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(268, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 61);
            this.button2.TabIndex = 56;
            this.button2.Text = "Dönüştür";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbltoplamcarbon
            // 
            this.lbltoplamcarbon.AutoSize = true;
            this.lbltoplamcarbon.Location = new System.Drawing.Point(263, 422);
            this.lbltoplamcarbon.Name = "lbltoplamcarbon";
            this.lbltoplamcarbon.Size = new System.Drawing.Size(24, 28);
            this.lbltoplamcarbon.TabIndex = 58;
            this.lbltoplamcarbon.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(220, 28);
            this.label7.TabIndex = 57;
            this.label7.Text = "Yeni Carbon Değerin : ";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(524, 473);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(250, 61);
            this.button3.TabIndex = 59;
            this.button3.Text = "İptal Et";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GeriDonusum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1068, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbltoplamcarbon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblsondeger);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbldeger);
            this.Controls.Add(this.txtadet);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblnesne);
            this.Controls.Add(this.lblCarbon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GeriDonusum";
            this.Text = "GeriDonusum";
            this.Load += new System.EventHandler(this.GeriDonusum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nesnelerTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleCoinDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarbon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RecycleCoinDataSet recycleCoinDataSet;
        private System.Windows.Forms.BindingSource nesnelerTblBindingSource;
        private RecycleCoinDataSetTableAdapters.NesnelerTblTableAdapter nesnelerTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nesneIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nesneAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nesneDegeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblnesne;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtadet;
        private System.Windows.Forms.Label lbldeger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblsondeger;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltoplamcarbon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}