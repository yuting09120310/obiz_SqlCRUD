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
using obiz_load_data;

namespace obiz_SqlCRUD
{
    public partial class Form2 : Form
    {
        string AppName = "obiz_SqlCRUD_Form1";
        Msg_log msg_Log = new Msg_log();

        DataGridView Dgv;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(DataGridView dgv)
        {
            InitializeComponent();

            this.Dgv = dgv;
        }

        public void Dgv_load(DataGridView dgv)
        {
            try
            {
                string SearchQuery = "select * from StudentInfo";
                DataTable Dt = SqlCRUD.SqlTable(SearchQuery);

                dgv.DataSource = Dt;
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check() == true)
                {
                    string Sql_Inset = $"Insert into StudentInfo (Name,StuId,Phone,Address) VALUES ('{Tb_Name.Text}' , '{Tb_StuId.Text}' , '{Tb_Phone.Text}' , '{Tb_Address.Text}')";
                    new SqlCRUD(Sql_Inset);
                    Clear();
                }
                Dgv_load(Dgv);
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private void Clear()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c.Name.Contains("Tb"))
                    {
                        c.Text = "";
                    }
                }
            }catch(Exception ex)
            {
                msg_Log.save_log(AppName, ex);
            }
        }

        private bool Check()
        {
            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c.Name.Contains("Tb"))
                    {
                        if (c.Text.Length == 0)
                        {
                            MessageBox.Show($"{c.Name} 沒填入");
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
