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

namespace obiz_SqlCRUD
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                string Sql_Inset = $"Insert into StudentInfo (Name,StuId,Phone,Address) VALUES ('{Tb_Name.Text}' , '{Tb_StuId.Text}' , '{Tb_Phone.Text}' , '{Tb_Address.Text}')";
                new SqlCRUD(Sql_Inset);
                //Clear();
            }
        }

        private void Clear()
        {
            foreach (Control c in this.Controls)
            {
                if (c.Name.Contains("Tb"))
                {
                    c.Text = "";
                }
            }
        }

        private bool Check()
        {
            foreach(Control c in this.Controls)
            {
                if (c.Name.Contains("Tb"))
                {
                    if(c.Text.Length == 0)
                    {
                        MessageBox.Show($"{c.Name} 沒填入");
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
