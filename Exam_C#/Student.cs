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
    public partial class Student : Form
    {
        public string name, username;
        public int time = 3600;
        public int xz = 1, pd = 1, tk = 1, jd = 2, score;
        public int xznum = 10, pdnum = 10, tknum = 10;
        //定义学生的选项数组
        string[] xuanze = new string[10];
        //定义学生的判断数组
        string[] panduan = new string[10];
        //定义学生的填空数组
        string[] tiankong = new string[10];

        private void rbtn_A_CheckedChanged(object sender, EventArgs e)
        {
            xuanze[xz - 1] = "A";
        }

        private void rbtn_B_CheckedChanged(object sender, EventArgs e)
        {
            xuanze[xz - 1] = "B";
        }

        private void rbtn_C_CheckedChanged(object sender, EventArgs e)
        {
            xuanze[xz - 1] = "C";
        }

        private void rbtn_D_CheckedChanged(object sender, EventArgs e)
        {
            xuanze[xz - 1] = "D";
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            //显示姓名和用户名
            lblName.Text = name;
            lblUserName.Text = username;
            //初始化选择题第一题
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string strsql = "select * from choice_questions where number = '" + xz + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(strsql, conn);
            SqlDataReader read = comm.ExecuteReader();
            if (read.Read())
            {
                lblExam.Text = xz + "." + read["title"].ToString();
                rbtn_A.Text = "A." + read["option_A"].ToString();
                rbtn_B.Text = "B." + read["option_B"].ToString();
                rbtn_C.Text = "C." + read["option_C"].ToString();
                rbtn_D.Text = "D." + read["option_D"].ToString();
                conn.Close();
            }
            //初始化判断题第一题
            string strsql2 = "select * from judge_questions where number = '" + pd + "'";
            conn.Open();
            SqlCommand comm2 = new SqlCommand(strsql2, conn);
            SqlDataReader read2 = comm2.ExecuteReader();
            if (read2.Read())
            {
                lblpdExam.Text = pd + "." + read2["title"].ToString();
                conn.Close();
            }
            //初始化填空题
            string strsql3 = "select * from tiankong_questions where number = '"+ tk +"'";
            conn.Open();
            SqlCommand comm3 = new SqlCommand(strsql3, conn);
            SqlDataReader read3 = comm3.ExecuteReader();
            if(read3.Read())
            {
                lbltk.Text =tk + "." + read3["title"].ToString();
                conn.Close();
            }
            //初始化简答题
            string strsql4 = "select * from jianda_questions where number = '" + jd + "'";
            conn.Open();
            SqlCommand comm4 = new SqlCommand(strsql4, conn);
            SqlDataReader read4 = comm4.ExecuteReader();
            if (read4.Read())
            {
                lbljd.Text = read4["title"].ToString();
                conn.Close();
            }
        }

        private void btnpdUp_Click(object sender, EventArgs e)
        {
            //判断是否为第一题
            if (pd>1)
            {
                pd--;
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string strsql2 = "select * from judge_questions where number = '" + pd + "'";
                conn.Open();
                SqlCommand comm2 = new SqlCommand(strsql2, conn);
                SqlDataReader read2 = comm2.ExecuteReader();
                //写入题目
                if (read2.Read())
                {
                    lblpdExam.Text = pd + "." + read2["title"].ToString();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("已经是第一题", "提示", MessageBoxButtons.OK);
                return;
            }
            //重置选项
            if(panduan[pd-1]=="√")
            {
                rbtnpd_true.Checked = true;
            }
            else if(panduan[pd-1]=="×")
            {
                rbtnpd_false.Checked = true;
            }
            else
            {
                rbtnpd_true.Checked = false;
                rbtnpd_false.Checked = false;
                panduan[pd - 1] = "0";
            }
        }

        private void btnpdNext_Click(object sender, EventArgs e)
        {
            //判断是否为最后一题
            if (pd < pdnum)
            {
                pd++;
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string strsql2 = "select * from judge_questions where number = '" + pd + "'";
                conn.Open();
                SqlCommand comm2 = new SqlCommand(strsql2, conn);
                SqlDataReader read2 = comm2.ExecuteReader();
                //写入题目
                if (read2.Read())
                {
                    lblpdExam.Text = pd + "." + read2["title"].ToString();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("已经是最后一题", "提示", MessageBoxButtons.OK);
                return;
            }
            //重置选项
            if (panduan[pd - 1] == "√")
            {
                rbtnpd_true.Checked = true;
            }
            else if (panduan[pd - 1] == "×")
            {
                rbtnpd_false.Checked = true;
            }
            else
            {
                rbtnpd_true.Checked = false;
                rbtnpd_false.Checked = false;
                panduan[pd - 1] = "0";
            }
        }

        private void rbtnpd_true_CheckedChanged(object sender, EventArgs e)
        {
            panduan[pd - 1] = "√";
        }

        private void rbtnpd_false_CheckedChanged(object sender, EventArgs e)
        {
            panduan[pd - 1] = "×";
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btntkNext_Click(object sender, EventArgs e)
        {
            //判断是否为最后一题
            if (tk >= tknum)
            {
                MessageBox.Show("已经是最后一题", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                tk++;
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string strsql3 = "select * from tiankong_questions where number = '" + tk + "'";
                conn.Open();
                SqlCommand comm3 = new SqlCommand(strsql3, conn);
                SqlDataReader read3 = comm3.ExecuteReader();
                //写入题目
                if (read3.Read())
                {
                    lbltk.Text = tk + "." + read3["title"].ToString();
                    conn.Close();
                }
                if (tiankong[tk - 1] != null)
                {
                    txttk.Text = tiankong[tk - 1];
                }
                else
                {
                    txttk.Text = null;
                    tiankong[tk - 1] = null;
                }
            }
        }

        private void txtjd_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void btnJiaojuan_Click(object sender, EventArgs e)
        {
            //交卷按钮
            DialogResult result = MessageBox.Show("确定交卷吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                int a=1, b=1, c=1;
                string xz_answer = null;
                foreach(string i in xuanze)
                {
                    string s1 = a.ToString();
                    xz_answer +=  s1 + '.' + i;
                    a++;
                    continue;
                }
                string pd_answer = null;
                foreach (string j in panduan)
                {
                    string s2 = b.ToString();
                    pd_answer += s2 + '.' + j;
                    b++;
                    continue;
                }
                string tk_answer = null;
                foreach (string k in tiankong)
                {
                    string s3 = c.ToString();
                    tk_answer += s3 + '.' + k;
                    c++;
                    continue;
                }
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string tijiao = "insert into student_answer(loginUserName,choice,judge,tiankong,jianda) values('" + username + "','" + xz_answer + "','" + tk_answer + "','" + pd_answer + "','" + txtjd.Text + "')";
                //验证是否重复交卷
                string jiancha = "select count(*) from student_answer where loginUserName = '" + username + "'";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(jiancha, conn);
                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                conn.Close();
                if (count > 0)
                {
                    MessageBox.Show("请勿重复作答", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //交卷
                    SqlCommand cmd2 = new SqlCommand(tijiao, conn);
                    conn.Open();
                    if (Convert.ToInt32(cmd2.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("交卷成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    timer1.Stop();
                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //开始倒计时
            time = time - 1;
            int hour = time / 3600;
            int min = time / 60;
            int sec = time % 60;
            //判断是否交卷
            if (hour == 0 && min == 0 && sec == 0)
            {
                timer1.Stop();
                int a = 1, b = 1, c = 1;
                string xz_answer = null;
                foreach (string i in xuanze)
                {
                    string s1 = a.ToString();
                    xz_answer += s1 + '.' + i;
                    a++;
                    continue;
                }
                string pd_answer = null;
                foreach (string j in panduan)
                {
                    string s2 = b.ToString();
                    pd_answer += s2 + '.' + j;
                    b++;
                    continue;
                }
                string tk_answer = null;
                foreach (string k in tiankong)
                {
                    string s3 = c.ToString();
                    tk_answer += s3 + '.' + k;
                    c++;
                    continue;
                }
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string tijiao = "insert into student_answer(loginUserName,choice,judge,tiankong,jianda) values('" + username + "','" + xz_answer + "','" + tk_answer + "','" + pd_answer + "','" + txtjd.Text + "')";
                //验证是否重复交卷
                string jiancha = "select count(*) from student_answer where loginUserName = '" + username + "'";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(jiancha, conn);
                int count = Convert.ToInt32(cmd1.ExecuteScalar());
                conn.Close();
                if (count > 0)
                {
                    MessageBox.Show("请勿重复作答", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //交卷
                    SqlCommand cmd2 = new SqlCommand(tijiao, conn);
                    conn.Open();
                    if (Convert.ToInt32(cmd2.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("交卷成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                    this.Close();
                }
            }
            //显示剩余时间
            DjsXianshi.Text = hour.ToString() + "时" + min.ToString() + "分" + sec.ToString() + "秒";
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {
            tiankong[tk - 1] = txttk.Text;
        }

        private void btntkUp_Click(object sender, EventArgs e)
        {
            //判断是否为第一题
            if (tk <= 1)
            {
                MessageBox.Show("已经是第一题", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                tk--;
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string strsql3 = "select * from tiankong_questions where number = '" + tk + "'";
                conn.Open();
                SqlCommand comm3 = new SqlCommand(strsql3, conn);
                SqlDataReader read3 = comm3.ExecuteReader();
                //写入题目
                if (read3.Read())
                {
                    lbltk.Text = tk + "." + read3["title"].ToString();
                    conn.Close();
                }
                if (tiankong[tk - 1] != null)
                {
                    txttk.Text = tiankong[tk - 1];
                }
                else
                {
                    txttk.Text = null;
                    tiankong[tk - 1] = null;
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (xz <= 1)
            {
                MessageBox.Show("已经是第一题", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                xz--;
                //重置按钮
                if (xuanze[xz - 1] == "A")
                {
                    rbtn_A.Checked = true;
                    rbtn_B.Checked = false;
                    rbtn_C.Checked = false;
                    rbtn_D.Checked = false;
                }
                else if (xuanze[xz - 1] == "B")
                {
                    rbtn_B.Checked = true;
                    rbtn_A.Checked = false;
                    rbtn_C.Checked = false;
                    rbtn_D.Checked = false;
                }
                else if (xuanze[xz - 1] == "C")
                {
                    rbtn_C.Checked = true;
                    rbtn_A.Checked = false;
                    rbtn_B.Checked = false;
                    rbtn_D.Checked = false;
                }
                else if (xuanze[xz - 1] == "D")
                {
                    rbtn_D.Checked = true;
                    rbtn_A.Checked = false;
                    rbtn_B.Checked = false;
                    rbtn_C.Checked = false;
                }
                else
                {
                    rbtn_A.Checked = false;
                    rbtn_B.Checked = false;
                    rbtn_C.Checked = false;
                    rbtn_D.Checked = false;
                    xuanze[xz - 1] = "0";
                }
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string strsql = "select * from choice_questions where number = '" + xz + "'";
                conn.Open();
                SqlCommand comm = new SqlCommand(strsql, conn);
                SqlDataReader read = comm.ExecuteReader();
                if (read.Read())
                {
                    lblExam.Text = xz + "." + read["title"].ToString();
                    rbtn_A.Text = "A." + read["option_A"].ToString();
                    rbtn_B.Text = "B." + read["option_B"].ToString();
                    rbtn_C.Text = "C." + read["option_C"].ToString();
                    rbtn_D.Text = "D." + read["option_D"].ToString();
                    conn.Close();
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //判断是否为最后一题
            if (xz >= xznum)
            {
                MessageBox.Show("已经是最后一题", "提示", MessageBoxButtons.OK);
                return;
            }
            else
            {
                xz++;
                //重置按钮
                if (xuanze[xz - 1] == "A")
                {
                    rbtn_A.Checked = true;
                    rbtn_B.Checked = false;
                    rbtn_C.Checked = false;
                    rbtn_D.Checked = false;
                }
                else if (xuanze[xz - 1] == "B")
                {
                    rbtn_B.Checked = true;
                    rbtn_A.Checked = false;
                    rbtn_C.Checked = false;
                    rbtn_D.Checked = false;
                }
                else if (xuanze[xz - 1] == "C")
                {
                    rbtn_C.Checked = true;
                    rbtn_A.Checked = false;
                    rbtn_B.Checked = false;
                    rbtn_D.Checked = false;
                }
                else if (xuanze[xz - 1] == "D")
                {
                    rbtn_D.Checked = true;
                    rbtn_A.Checked = false;
                    rbtn_B.Checked = false;
                    rbtn_C.Checked = false;
                }
                else
                {
                    rbtn_A.Checked = false;
                    rbtn_B.Checked = false;
                    rbtn_C.Checked = false;
                    rbtn_D.Checked = false;
                    xuanze[xz - 1] = "0";
                }
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string strsql = "select * from choice_questions where number = '" + xz + "'";
                conn.Open();
                SqlCommand comm = new SqlCommand(strsql, conn);
                SqlDataReader read = comm.ExecuteReader();
                if (read.Read())
                {
                    lblExam.Text = xz + "." + read["title"].ToString();
                    rbtn_A.Text = "A." + read["option_A"].ToString();
                    rbtn_B.Text = "B." + read["option_B"].ToString();
                    rbtn_C.Text = "C." + read["option_C"].ToString();
                    rbtn_D.Text = "D." + read["option_D"].ToString();
                    conn.Close();
                }
            }
        }
    }
}
