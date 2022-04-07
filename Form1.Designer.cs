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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtStuId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkType = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
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
            this.tabPage2.Controls.Add(this.txtNum);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.btnDel);
            this.tabPage2.Controls.Add(this.txtAddress);
            this.tabPage2.Controls.Add(this.txtPhone);
            this.tabPage2.Controls.Add(this.txtStuId);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "修改.刪除";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.txtNum.Location = new System.Drawing.Point(224, 42);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(205, 33);
            this.txtNum.TabIndex = 20;
            this.txtNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNum_KeyDown);
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
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(337, 498);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(92, 33);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "刪除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.txtAddress.Location = new System.Drawing.Point(224, 398);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(205, 33);
            this.txtAddress.TabIndex = 17;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.txtPhone.Location = new System.Drawing.Point(224, 311);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(205, 33);
            this.txtPhone.TabIndex = 16;
            // 
            // txtStuId
            // 
            this.txtStuId.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.txtStuId.Location = new System.Drawing.Point(224, 215);
            this.txtStuId.Name = "txtStuId";
            this.txtStuId.Size = new System.Drawing.Size(205, 33);
            this.txtStuId.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.txtName.Location = new System.Drawing.Point(224, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 33);
            this.txtName.TabIndex = 14;
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
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(183, 498);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(92, 33);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOpen);
            this.tabPage1.Controls.Add(this.chkType);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.dgResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "搜尋.建立";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("新細明體", 9F);
            this.btnOpen.Location = new System.Drawing.Point(499, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "建立";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chkType
            // 
            this.chkType.FormattingEnabled = true;
            this.chkType.Location = new System.Drawing.Point(8, 15);
            this.chkType.Name = "chkType";
            this.chkType.Size = new System.Drawing.Size(71, 25);
            this.chkType.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(85, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 28);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgResults
            // 
            this.dgResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(3, 50);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowTemplate.Height = 24;
            this.dgResults.Size = new System.Drawing.Size(620, 536);
            this.dgResults.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtStuId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox chkType;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label5;
    }
}

