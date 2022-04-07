using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assembly;
using Alex_Component; 

namespace obiz_SqlCRUD
{
    public partial class Form1 : Form
    {
        DataTable Dt;
        SchoolEntities db = new SchoolEntities();

        string AppName = "obiz_SqlCRUD_Form1";
        Msg_log msg_Log = new Msg_log();

        public Form1()
        {
            InitializeComponent();
            setup();
        }

        //初次設定
        public void setup()
        {
            try
            {
                String[] items = new String[] { "Name", "StuId", "Phone", "Address" };

                for (int i = 0; i < items.Length; i++)
                {
                    chkType.Items.Add(items[i]);
                }
                chkType.SelectedIndex = 0;

                Dgv_load();
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        //按下新增後
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form = new Form2(dgResults);
                form.Show();
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        //搜尋
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (chkType.Text.Length != 0)
                    {
                        Dt = null;
                        string SearchQuery = $"SELECT * FROM StudentInfo WHERE {chkType.Text} like '%{txtSearch.Text}%'";
                        Dt = SqlCRUD.SqlTable(SearchQuery);

                        dgResults.DataSource = Dt;
                    }
                    else
                    {
                        Dgv_load();
                    }
                }catch(Exception ex)
                {
                    msg_Log.save_log(AppName, ex);
                }
            }
        }

        //重新整理
        public void Dgv_load()
        {
            try
            {
                string SearchQuery = "SELECT * FROM StudentInfo";
                Dt = SqlCRUD.SqlTable(SearchQuery);

                dgResults.DataSource = Dt;
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        //刪除事件
        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNum.Text.Length != 0)
                {
                    string Select_Query = $"SELECT * FROM StudentInfo WHERE id = {txtNum.Text}";
                    DataTable dt = SqlCRUD.SqlTable(Select_Query);
                    if (dt.Rows.Count > 0)
                    {
                        string Update_Query = $"Delete StudentInfo WHERE Id = {txtNum.Text}";
                        new SqlCRUD(Update_Query);
                        Dgv_load();
                    }
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }
        //編輯
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNum.Text.Length != 0)
                {
                    string Select_Query = $"SELECT * FROM StudentInfo WHERE id = {txtNum.Text}";
                    DataTable dt = SqlCRUD.SqlTable(Select_Query);
                    if (dt.Rows.Count > 0)
                    {
                        string Update_Query = $"UPDATE  StudentInfo SET Name='{txtName.Text}',StuID='{txtStuId.Text}',Phone='{txtPhone.Text}',Address='{txtAddress.Text}' WHERE Id = '{txtNum.Text}'";
                        new SqlCRUD(Update_Query);
                        Dgv_load();
                    }
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string Select_Query = $"SELECT * FROM StudentInfo WHERE ID = '{txtNum.Text}'";
                DataTable dt = SqlCRUD.SqlTable(Select_Query);
                if(dt.Rows.Count == 0)
                {
                    MessageBox.Show("查無資料");
                    return;
                }
                
                txtName.Text = dt.Rows[0]["Name"].ToString();
                txtStuId.Text = dt.Rows[0]["StuId"].ToString();
                txtPhone.Text = dt.Rows[0]["Phone"].ToString();
                txtAddress.Text = dt.Rows[0]["Address"].ToString();
            }
        }
    }
}
