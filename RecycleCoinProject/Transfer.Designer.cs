namespace RecycleCoinProject
{
    partial class Transfer
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
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHA256DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.recycleCoinDataSet1 = new RecycleCoinProject.RecycleCoinDataSet1();
            this.label18 = new System.Windows.Forms.Label();
            this.musteriTblTableAdapter = new RecycleCoinProject.RecycleCoinDataSet1TableAdapters.MusteriTblTableAdapter();
            this.lblCarbon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblgondericiadres = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblaliciadres = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblgndrcyeni = new System.Windows.Forms.Label();
            this.lblaliciyeni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleCoinDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.sHA256DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.musteriTblBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(458, 54);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 368);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            // 
            // sHA256DataGridViewTextBoxColumn
            // 
            this.sHA256DataGridViewTextBoxColumn.DataPropertyName = "SHA256";
            this.sHA256DataGridViewTextBoxColumn.HeaderText = "SHA256";
            this.sHA256DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sHA256DataGridViewTextBoxColumn.Name = "sHA256DataGridViewTextBoxColumn";
            // 
            // musteriTblBindingSource
            // 
            this.musteriTblBindingSource.DataMember = "MusteriTbl";
            this.musteriTblBindingSource.DataSource = this.recycleCoinDataSet1;
            // 
            // recycleCoinDataSet1
            // 
            this.recycleCoinDataSet1.DataSetName = "RecycleCoinDataSet1";
            this.recycleCoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(756, 9);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(251, 45);
            this.label18.TabIndex = 50;
            this.label18.Text = "KULLANICILAR";
            // 
            // musteriTblTableAdapter
            // 
            this.musteriTblTableAdapter.ClearBeforeFill = true;
            // 
            // lblCarbon
            // 
            this.lblCarbon.AutoSize = true;
            this.lblCarbon.Location = new System.Drawing.Point(184, 81);
            this.lblCarbon.Name = "lblCarbon";
            this.lblCarbon.Size = new System.Drawing.Size(24, 28);
            this.lblCarbon.TabIndex = 54;
            this.lblCarbon.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Coin Değerin:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(184, 39);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(24, 28);
            this.lblTC.TabIndex = 52;
            this.lblTC.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 51;
            this.label1.Text = "TC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Gönderici Adres :";
            // 
            // lblgondericiadres
            // 
            this.lblgondericiadres.AutoSize = true;
            this.lblgondericiadres.Location = new System.Drawing.Point(224, 474);
            this.lblgondericiadres.Name = "lblgondericiadres";
            this.lblgondericiadres.Size = new System.Drawing.Size(102, 28);
            this.lblgondericiadres.TabIndex = 56;
            this.lblgondericiadres.Text = "SHA-256 ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 57;
            this.label5.Text = "Alıcı Adres :";
            // 
            // lblaliciadres
            // 
            this.lblaliciadres.AutoSize = true;
            this.lblaliciadres.Location = new System.Drawing.Point(218, 569);
            this.lblaliciadres.Name = "lblaliciadres";
            this.lblaliciadres.Size = new System.Drawing.Size(102, 28);
            this.lblaliciadres.TabIndex = 58;
            this.lblaliciadres.Text = "SHA-256 ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 28);
            this.label6.TabIndex = 59;
            this.label6.Text = "Transfer Miktarı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 36);
            this.textBox1.TabIndex = 60;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(189, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 61);
            this.button2.TabIndex = 61;
            this.button2.Text = "Transfer Et";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(189, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 61);
            this.button3.TabIndex = 62;
            this.button3.Text = "İptal Et";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblgndrcyeni
            // 
            this.lblgndrcyeni.AutoSize = true;
            this.lblgndrcyeni.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgndrcyeni.Location = new System.Drawing.Point(406, 9);
            this.lblgndrcyeni.Name = "lblgndrcyeni";
            this.lblgndrcyeni.Size = new System.Drawing.Size(39, 15);
            this.lblgndrcyeni.TabIndex = 63;
            this.lblgndrcyeni.Text = "label4";
            this.lblgndrcyeni.Visible = false;
            // 
            // lblaliciyeni
            // 
            this.lblaliciyeni.AutoSize = true;
            this.lblaliciyeni.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaliciyeni.Location = new System.Drawing.Point(470, 9);
            this.lblaliciyeni.Name = "lblaliciyeni";
            this.lblaliciyeni.Size = new System.Drawing.Size(38, 15);
            this.lblaliciyeni.TabIndex = 64;
            this.lblaliciyeni.Text = "label7";
            this.lblaliciyeni.Visible = false;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(1192, 645);
            this.Controls.Add(this.lblaliciyeni);
            this.Controls.Add(this.lblgndrcyeni);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblaliciadres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblgondericiadres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCarbon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recycleCoinDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private RecycleCoinDataSet1 recycleCoinDataSet1;
        private System.Windows.Forms.BindingSource musteriTblBindingSource;
        private RecycleCoinDataSet1TableAdapters.MusteriTblTableAdapter musteriTblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHA256DataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCarbon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblgondericiadres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblaliciadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblgndrcyeni;
        private System.Windows.Forms.Label lblaliciyeni;
    }
}