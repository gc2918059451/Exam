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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.验证学号不能为空
            if (this.txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus();//光标归位到学号
                return;
            }
            string Xuehao, Xingming, Fenshu;
            dataGridView1.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select UserName,Name,score from student_score where UserName = '"+ txtUserName.Text +"'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while(read.Read())
            {
                Xuehao = read[0].ToString();
                Xingming = read[1].ToString();
                Fenshu = read[2].ToString();
                string[] table = { Xuehao, Xingming, Fenshu };
                dataGridView1.Rows.Add(table);
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Xuehao, Xingming, Fenshu;
            dataGridView1.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql1 = "select UserName,Name,score from student_score";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql1, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Xuehao = read[0].ToString();
                Xingming = read[1].ToString();
                Fenshu = read[2].ToString();
                string[] table = { Xuehao, Xingming, Fenshu };
                dataGridView1.Rows.Add(table);
            }
            conn.Close();
        }

        private void btnxgcx_Click(object sender, EventArgs e)
        {
            //1.验证学号不能为空
            if (this.txtxgxh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxgxh.Focus();//光标归位到学号
                return;
            }
            string Xuehao, Xingming, Fenshu;
            dataGridView2.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select UserName,Name,score from student_score where UserName = '" + txtxgxh.Text + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                Xuehao = read[0].ToString();
                Xingming = read[1].ToString();
                Fenshu = read[2].ToString();
                string[] table = { Xuehao, Xingming, Fenshu };
                dataGridView2.Rows.Add(table);
            }
            conn.Close();
        }

        private void btnxgxg_Click(object sender, EventArgs e)
        {
            int x;
            //验证学号不能为空
            if (this.txtxgxh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxgxh.Focus();
                return;
            }
            //验证修改内容不能为空
            if (this.txtxgcj.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入成绩", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxgcj.Focus();
                return;
            }
            //分数在0-150之间
            x = Convert.ToInt32(txtxgcj.Text);
            if(x<0 || x>150)
            {
                MessageBox.Show("请输入正确的成绩（0~150）", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxgcj.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定修改吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string sql = "update student_score set score= '" + txtxgcj.Text + "' where UserName = '" + txtxgxh.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                string sql2 = "update student_answer set score= '" + txtxgcj.Text + "' where loginUserName = '" + txtxgxh.Text + "'";
                SqlCommand comm2 = new SqlCommand(sql2, conn);
                conn.Open();
                if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0 && Convert.ToInt32(comm2.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            btnxgcx_Click(null, null);
            button2_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string number, title, option_A, option_B, option_C, option_D, answer;
            dataGridView3.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from choice_questions";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                number = read[0].ToString();
                title = read[1].ToString();
                option_A = read[2].ToString();
                option_B = read[3].ToString();
                option_C = read[4].ToString();
                option_D = read[5].ToString();
                answer = read[6].ToString();
                string[] table = { number, title, option_A, option_B, option_C, option_D, answer };
                dataGridView3.Rows.Add(table);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //number
            if (this.txtnumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnumber.Focus();
                return;
            }
            int y = Convert.ToInt32(txtnumber.Text);
            if (y < 1 || y > 10)
            {
                MessageBox.Show("题目请输入1~10其中一个选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtnumber.Focus();
                return;
            }
            //title
            if (this.txttitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题目", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txttitle.Focus();
                return;
            }
            //A
            if (this.txta.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入A选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txta.Focus();
                return;
            }
            //B
            if (this.txtb.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入B选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtb.Focus();
                return;
            }
            //C
            if (this.txtc.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入C选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtc.Focus();
                return;
            }
            //D
            if (this.txtd.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入D选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtd.Focus();
                return;
            }
            //answer
            if (this.txtanswer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入答案", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtanswer.Focus();
                return;
            }
            char x = Convert.ToChar(txtanswer.Text);
            if(x!='A'&& x!='B'&& x!='C' && x!='D')
            {
                MessageBox.Show("答案请输入A、B、C、D其中一个选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtanswer.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定修改吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string sql = "update choice_questions set title='" + txttitle.Text + "',option_A='" + txta.Text + "',option_B='" + txtb.Text + "',option_C='" + txtc.Text + "',option_D='" + txtd.Text + "',answer='" + txtanswer.Text + "' where number='" + txtnumber.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                button4_Click(null, null);
            }
        }

        private void btnpdall_Click(object sender, EventArgs e)
        {
            string number, title, answer;
            dataGridView4.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from judge_questions";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                number = read[0].ToString();
                title = read[1].ToString();
                answer = read[2].ToString();
                string[] table = { number, title, answer };
                dataGridView4.Rows.Add(table);
            }
            conn.Close();
        }

        private void btnpdxg_Click(object sender, EventArgs e)
        {
            //number
            if (this.txtpdnumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpdnumber.Focus();
                return;
            }
            int y = Convert.ToInt32(txtpdnumber.Text);
            if (y < 1 || y > 10)
            {
                MessageBox.Show("题目请输入1~10其中一个选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpdnumber.Focus();
                return;
            }
            //title
            if (this.txtpdtitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题目", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpdtitle.Focus();
                return;
            }
            //answer
            if (this.txtpdanswer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入答案", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpdanswer.Focus();
                return;
            }
            char x = Convert.ToChar(txtpdanswer.Text);
            if (x != '√' && x != '×')
            {
                MessageBox.Show("答案请输入√、×其中一个选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpdanswer.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定修改吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string sql = "update judge_questions set title='" + txtpdtitle.Text + "',answer='" + txtpdanswer.Text + "' where number='" + txtpdnumber.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                btnpdall_Click(null, null);
            }
        }

        private void btntkall_Click(object sender, EventArgs e)
        {
            string number, title/*, answer*/;
            dataGridView5.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from tiankong_questions";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                number = read[0].ToString();
                title = read[1].ToString();
                //answer = read[2].ToString();
                string[] table = { number, title, /*answer*/ };
                dataGridView5.Rows.Add(table);
            }
            conn.Close();
        }

        private void btntkxg_Click(object sender, EventArgs e)
        {
            //number
            if (this.txttknumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txttknumber.Focus();
                return;
            }
            int y = Convert.ToInt32(txttknumber.Text);
            if (y < 1 || y > 10)
            {
                MessageBox.Show("题目请输入1~10其中一个选项", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txttknumber.Focus();
                return;
            }
            //title
            if (this.txttktitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题目", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txttktitle.Focus();
                return;
            }
            //answer
            if (this.txttkanswer.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入答案", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txttkanswer.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定修改吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string sql = "update tiankong_questions set title='" + txttktitle.Text + "',answer='" + txttkanswer.Text + "' where number='" + txttknumber.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                btntkall_Click(null, null);
            }
        }

        private void btnjdall_Click(object sender, EventArgs e)
        {
            string number,title;
            dataGridView6.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from jianda_questions";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                number = read[0].ToString();
                title = read[1].ToString();
                string[] table = { number,title };
                dataGridView6.Rows.Add(table);
            }
            conn.Close();
        }

        private void btnjdxg_Click(object sender, EventArgs e)
        {
            //number
            if (this.txtjdnumber.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtjdnumber.Focus();
                return;
            }
            //title
            if (this.txtjdtitle.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入题目", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtjdtitle.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定修改吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string sql = "update jianda_questions set title='" + txtjdtitle.Text + "' where number='" + txtjdnumber.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
                btnjdall_Click(null, null);
            }
        }

        private void btnpgcx_Click(object sender, EventArgs e)
        {
            string number, choice, judge, tiankong,jianda,score;
            dataGridView7.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from student_answer";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                number = read[0].ToString();
                choice = read[1].ToString();
                judge = read[2].ToString();
                tiankong = read[3].ToString();
                jianda = read[4].ToString();
                score = read[5].ToString();
                string[] table = { number, choice, judge, tiankong, jianda, score };
                dataGridView7.Rows.Add(table);
            }
            conn.Close();
        }

        private void btnpgtj_Click(object sender, EventArgs e)
        {
            if(this.lblpgname.Text.Trim() == "**")
            {
                MessageBox.Show("请点击姓名查询", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //number
            if (this.txtpgxh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpgxh.Focus();
                return;
            }
            //成绩
            if (this.txtpgcj.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入成绩", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpgcj.Focus();
                return;
            }
            //分数在0-150之间
            int x = Convert.ToInt32(txtpgcj.Text);
            if (x < 0 || x > 150)
            {
                MessageBox.Show("请输入正确的成绩（0~150）", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpgcj.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定提交吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                string sql1 = "select count(*)from student_score where UserName =  '" + txtpgxh.Text + "'";
                SqlCommand comm1 = new SqlCommand(sql1, conn);
                int count = Convert.ToInt32(comm1.ExecuteScalar());
                if (count > 0)
                {
                    string sql = "update student_score set score= '" + txtpgcj.Text + "' where UserName = '" + txtpgxh.Text + "'";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    string sql2 = "update student_answer set score= '" + txtpgcj.Text + "' where loginUserName = '" + txtpgxh.Text + "'";
                    SqlCommand comm2 = new SqlCommand(sql2, conn);
                    if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0 && Convert.ToInt32(comm2.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
                else
                {
                    string sql = "insert into student_score(UserName,Name,score) values('" + txtpgxh.Text + "','" + lblpgname.Text + "','" + txtpgcj.Text + "')";
                    SqlCommand comm = new SqlCommand(sql, conn);
                    string sql2 = "update student_answer set score= '" + txtpgcj.Text + "' where loginUserName = '" + txtpgxh.Text + "'";
                    SqlCommand comm2 = new SqlCommand(sql2, conn);
                    if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0 && Convert.ToInt32(comm2.ExecuteNonQuery()) > 0)
                    {
                        MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn.Close();
                }
            }
            btnpgcx_Click(null, null);
        }

        private void Teacher_Load(object sender, EventArgs e)
        {

        }

        private void btnxxcx_Click(object sender, EventArgs e)
        {
            //number
            if (this.txtxxxh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxxxh.Focus();
                return;
            }
            string number, name, password, type;
            dataGridView8.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select * from admin where loginUserName = '" + txtxxxh.Text + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                number = read[0].ToString();
                password = read[1].ToString();
                type = read[2].ToString();
                name = read[3].ToString();
                string[] table = { number, password, name, type };
                dataGridView8.Rows.Add(table);
                txtxxxm.Text = name;
            }
            conn.Close();
        }

        private void btnxxxg_Click(object sender, EventArgs e)
        {
            //number
            if (this.txtxxxh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxxxh.Focus();
                return;
            }
            //name
            if (this.txtxxxm.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxxxm.Focus();
                return;
            }
            //password
            if (this.txtxxmm.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtxxmm.Focus();
                return;
            }
            //修改
            DialogResult result = MessageBox.Show("确定修改吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
                SqlConnection conn = new SqlConnection(connStr);
                string sql = "update admin set loginUserName= '" + txtxxxh.Text + "', loginPassWord = '" + txtxxmm.Text + "', Name = '" + txtxxxm.Text + "' where loginUserName = '" + txtxxxh.Text + "'";
                SqlCommand comm = new SqlCommand(sql, conn);
                conn.Open();
                if (Convert.ToInt32(comm.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("修改成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
            btnxxcx_Click(null, null);
        }

        private void btnpgxhcx_Click(object sender, EventArgs e)
        {
            //1.验证学号不能为空
            if (this.txtpgxh.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入学号", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtpgxh.Focus();//光标归位到学号
                return;
            }
            string name;
            dataGridView2.Rows.Clear();
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string sql = "select Name from admin where loginUserName = '" + txtpgxh.Text + "'";
            conn.Open();
            SqlCommand comm = new SqlCommand(sql, conn);
            SqlDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                name = read[0].ToString();
                lblpgname.Text = name;
            }
            conn.Close();
        }

        private void lblpgname_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
    }
}
