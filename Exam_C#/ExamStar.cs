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

namespace ExamOnline
{
    public partial class ExamStar : Form
    {
        public string name, username;
        public ExamStar()
        {
            InitializeComponent();
        }

        private void btnExamStar_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = this.lblName.Text;
            student.username = this.lblUserName.Text;
            student.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //取消按钮
            DialogResult result = MessageBox.Show("确定关闭吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ExamStar_Load(object sender, EventArgs e)
        {
            this.lblUserName.Text = username;
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string strsql = "select Name from admin where loginUserName = '"+ username +"'";
            conn.Open();
            SqlCommand comm = new SqlCommand(strsql, conn);
            SqlDataReader read = comm.ExecuteReader();
            if (read.Read())
            {
                name = read["Name"].ToString();
                conn.Close();
            }
            this.lblName.Text = name;
        }
    }
}
