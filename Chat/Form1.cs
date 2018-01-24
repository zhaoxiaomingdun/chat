using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要链接的数据库名称:");
            }
            else
            {
                try
                {
                    string Constr = "server=39.107.94.124,1433;datase=" + textBox1.Text.Trim() +
                        ";uid=sa;pwd=13733686727dun,.";
                    SqlConnection conn = new SqlConnection(Constr);
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        label2.Text = "数据库打开";

                    }
                }
                catch
                {
                    MessageBox.Show("连接失败");
                }
            }
         }
    }
}
