namespace obiz_SqlCRUD
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Cb_Type = new System.Windows.Forms.ComboBox();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tb_Address = new System.Windows.Forms.TextBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Tb_StuId = new System.Windows.Forms.TextBox();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PC-ALEX;Initial Catalog=School;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(590, 579);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Cb_Type);
            this.tabPage1.Controls.Add(this.Tb_Search);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "搜尋.建立";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "建立";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cb_Type
            // 
            this.Cb_Type.FormattingEnabled = true;
            this.Cb_Type.Location = new System.Drawing.Point(8, 15);
            this.Cb_Type.Name = "Cb_Type";
            this.Cb_Type.Size = new System.Drawing.Size(71, 20);
            this.Cb_Type.TabIndex = 5;
            // 
            // Tb_Search
            // 
            this.Tb_Search.Location = new System.Drawing.Point(85, 13);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(150, 22);
            this.Tb_Search.TabIndex = 4;
            this.Tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Search_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.Tb_Address);
            this.tabPage2.Controls.Add(this.Tb_Phone);
            this.tabPage2.Controls.Add(this.Tb_StuId);
            this.tabPage2.Controls.Add(this.Tb_Name);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改.刪除";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tb_Address
            // 
            this.Tb_Address.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Address.Location = new System.Drawing.Point(204, 354);
            this.Tb_Address.Name = "Tb_Address";
            this.Tb_Address.Size = new System.Drawing.Size(205, 33);
            this.Tb_Address.TabIndex = 17;
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Phone.Location = new System.Drawing.Point(204, 267);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(205, 33);
            this.Tb_Phone.TabIndex = 16;
            // 
            // Tb_StuId
            // 
            this.Tb_StuId.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_StuId.Location = new System.Drawing.Point(204, 171);
            this.Tb_StuId.Name = "Tb_StuId";
            this.Tb_StuId.Size = new System.Drawing.Size(205, 33);
            this.Tb_StuId.TabIndex = 15;
            // 
            // Tb_Name
            // 
            this.Tb_Name.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Name.Location = new System.Drawing.Point(204, 70);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(205, 33);
            this.Tb_Name.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(136, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "地址 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(94, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "手機號碼 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(94, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "學生編號 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(136, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "姓名 :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "送出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 18;
            this.button3.Text = "送出";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 578);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Cb_Type;
        private System.Windows.Forms.TextBox Tb_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Tb_Address;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.TextBox Tb_StuId;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

