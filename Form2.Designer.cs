namespace obiz_SqlCRUD
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_Name = new System.Windows.Forms.TextBox();
            this.Tb_StuId = new System.Windows.Forms.TextBox();
            this.Tb_Phone = new System.Windows.Forms.TextBox();
            this.Tb_Address = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(50, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "姓名 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "學生編號 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(8, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "手機號碼 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(50, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "地址 :";
            // 
            // Tb_Name
            // 
            this.Tb_Name.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Name.Location = new System.Drawing.Point(118, 44);
            this.Tb_Name.Name = "Tb_Name";
            this.Tb_Name.Size = new System.Drawing.Size(205, 33);
            this.Tb_Name.TabIndex = 5;
            // 
            // Tb_StuId
            // 
            this.Tb_StuId.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_StuId.Location = new System.Drawing.Point(118, 145);
            this.Tb_StuId.Name = "Tb_StuId";
            this.Tb_StuId.Size = new System.Drawing.Size(205, 33);
            this.Tb_StuId.TabIndex = 6;
            // 
            // Tb_Phone
            // 
            this.Tb_Phone.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Phone.Location = new System.Drawing.Point(118, 241);
            this.Tb_Phone.Name = "Tb_Phone";
            this.Tb_Phone.Size = new System.Drawing.Size(205, 33);
            this.Tb_Phone.TabIndex = 7;
            // 
            // Tb_Address
            // 
            this.Tb_Address.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.Tb_Address.Location = new System.Drawing.Point(118, 328);
            this.Tb_Address.Name = "Tb_Address";
            this.Tb_Address.Size = new System.Drawing.Size(205, 33);
            this.Tb_Address.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 472);
            this.Controls.Add(this.Tb_Address);
            this.Controls.Add(this.Tb_Phone);
            this.Controls.Add(this.Tb_StuId);
            this.Controls.Add(this.Tb_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "新增學生";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.TextBox Tb_StuId;
        private System.Windows.Forms.TextBox Tb_Phone;
        private System.Windows.Forms.TextBox Tb_Address;
    }
}