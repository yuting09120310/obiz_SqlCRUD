using Assembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alex_Component;

namespace obiz_SqlCRUD
{
    public partial class Form2 : Form
    {
        string AppName = "obiz_SqlCRUD_Form1";
        Msg_log msg_Log = new Msg_log();

        DataGridView dgResults;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DataGridView dgResults)
        {
            InitializeComponent();

            this.dgResults = dgResults;
        }

        public void dg_load(DataGridView dgv)
        {
            try
            {
                string SearchQuery = "SELECT * FROM StudentInfo";
                DataTable Dt = SqlCRUD.SqlTable(SearchQuery);

                dgv.DataSource = Dt;
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (check() == true)
                {
                    string Sql_Inset = $"INSERT INTO StudentInfo (Name,StuId,Phone,Address) VALUES ('{txtName.Text}' , '{txtStuId.Text}' , '{txtPhone.Text}' , '{txtAddress.Text}')";
                    new SqlCRUD(Sql_Inset);
                    clear();
                }
                dg_load(dgResults);
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void clear()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Name.Contains("txt"))
                    {
                        item.Text = "";
                    }
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private bool check()
        {
            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Name.Contains("txt"))
                    {
                        if (item.Text.Length == 0)
                        {
                            MessageBox.Show($"{item.Name} 沒填入");
                            return false;
                        }
                    }
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
            return true;
        }
    }
}
