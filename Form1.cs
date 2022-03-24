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

namespace obiz_SqlCRUD
{
    public partial class Form1 : Form
    {
        DataTable Dt;
        public Form1()
        {
            InitializeComponent();
            setup();
        }

        public void setup()
        {
            String[] items = new String[] {"Name", "StuId","Phone","Address" };

            for (int i = 0; i < items.Length; i++)
            {
                Cb_Type.Items.Add(items[i]);
            }
            Cb_Type.SelectedIndex = 0;

            Dgv_load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Tb_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Cb_Type.Text.Length != 0)
                {
                    Dt = null;
                    string SearchQuery = $"select * from StudentInfo where {Cb_Type.Text} like '%{Tb_Search.Text}%'";
                    Dt = SqlCRUD.SqlTable(SearchQuery);

                    dataGridView1.DataSource = Dt;
                }
                else
                {
                    Dgv_load();
                }
            }
        }

        public void Dgv_load()
        {
            string SearchQuery = "select * from StudentInfo";
            Dt = SqlCRUD.SqlTable(SearchQuery);

            dataGridView1.DataSource = Dt;
        }
    }
}
