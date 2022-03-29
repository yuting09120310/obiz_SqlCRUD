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
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Tb_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.Tb_Address = new System.Windows.Forms.TextBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Tb_StuId = new System.Windows.Forms.TextBox();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.Cb_Type = new System.Windows.Forms.ComboBox();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=PC-ALEX;Initial Catalog=School;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Tb_num);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Btn_Del);
            this.tabPage2.Controls.Add(this.Tb_Address);
            this.tabPage2.Controls.Add(this.Tb_Phone);
            this.tabPage2.Controls.Add(this.Tb_StuId);
            this.tabPage2.Controls.Add(this.Tb_Name);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Btn_Edit);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改.刪除";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Tb_num
            // 
            this.Tb_num.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_num.Location = new System.Drawing.Point(224, 42);
            this.Tb_num.Name = "Tb_num";
            this.Tb_num.Size = new System.Drawing.Size(205, 33);
            this.Tb_num.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(156, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "編號 :";
            // 
            // Btn_Del
            // 
            this.Btn_Del.Location = new System.Drawing.Point(337, 498);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(92, 33);
            this.Btn_Del.TabIndex = 18;
            this.Btn_Del.Text = "刪除";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // Tb_Address
            // 
            this.Tb_Address.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Address.Location = new System.Drawing.Point(224, 398);
            this.Tb_Address.Name = "Tb_Address";
            this.Tb_Address.Size = new System.Drawing.Size(205, 33);
            this.Tb_Address.TabIndex = 17;
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Phone.Location = new System.Drawing.Point(224, 311);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(205, 33);
            this.Tb_Phone.TabIndex = 16;
            // 
            // Tb_StuId
            // 
            this.Tb_StuId.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_StuId.Location = new System.Drawing.Point(224, 215);
            this.Tb_StuId.Name = "Tb_StuId";
            this.Tb_StuId.Size = new System.Drawing.Size(205, 33);
            this.Tb_StuId.TabIndex = 15;
            // 
            // Tb_Name
            // 
            this.Tb_Name.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Name.Location = new System.Drawing.Point(224, 129);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(205, 33);
            this.Tb_Name.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(156, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "地址 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(114, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "手機號碼 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(114, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "學生編號 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(156, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "姓名 :";
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(183, 498);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(92, 33);
            this.Btn_Edit.TabIndex = 9;
            this.Btn_Edit.Text = "修改";
            this.Btn_Edit.UseVisualStyleBackColor = true;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.Cb_Type);
            this.tabPage1.Controls.Add(this.Tb_Search);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "搜尋.建立";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 9F);
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
            this.Cb_Type.Size = new System.Drawing.Size(71, 25);
            this.Cb_Type.TabIndex = 5;
            // 
            // Tb_Search
            // 
            this.Tb_Search.Location = new System.Drawing.Point(85, 13);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(150, 28);
            this.Tb_Search.TabIndex = 4;
            this.Tb_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tb_Search_KeyDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 536);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("新細明體", 13F);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 620);
            this.tabControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 620);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.TextBox Tb_Address;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.TextBox Tb_StuId;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cb_Type;
        private System.Windows.Forms.TextBox Tb_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox Tb_num;
        private System.Windows.Forms.Label label5;
    }
}

