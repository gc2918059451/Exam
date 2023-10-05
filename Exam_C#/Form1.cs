using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//和SQL相关的命名空间
using System.IO;


namespace ExamOnline
{
    public partial class Form1 : Form
    {
        ValidateCode code = new ValidateCode();//实例化生成验证码的类
        private string vcode = string.Empty;//声明存储验证码的字符串变量
        public Form1()
        {
            InitializeComponent();
            ShowCode();//调用生成验证码的方法
        }

        //生成验证码的方法
        private void ShowCode()
        {
            vcode = code.CreateValidateCode(4);//把生成的验证码赋值给变量
            byte[] buffer = code.CreateValidateGraphic(vcode);//把字符串转成字节流
            pictureBox1.Image = ByteToImage(buffer);//把字节流转成图片显示在窗体中的pictureBox1控件
        }

        /// <summary>
        /// 字节流转成图片
        /// </summary>
        /// <param name="buffer">需要转换的字节流</param>
        /// <returns>返回生成图片</returns>
        private Image ByteToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            return Image.FromStream(ms, true);
        }
        //看不清换一张，重新调用一下生成验证码的方法
        private void label1_Click(object sender, EventArgs e)
        {
            ShowCode();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            //取消按钮
            DialogResult result=MessageBox.Show("确定关闭吗？","提示信息",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1.验证用户名不能为空
            if (this.txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入用户名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtUserName.Focus();//光标归位到用户名
                return;
            }
            //2.验证密码不能为空
            if (this.txtPassWord.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入密码", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPassWord.Focus();//光标归位到密码
                return;
            }
            //3.验证用户类型不能为空
            if (this.cmbType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请选择用户类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbType.Focus();//光标归位到用户类型
                return;
            }
            //登录按钮验证输入的验证码是否正确
            if (textBox1.Text.Trim() != vcode)
            {
                MessageBox.Show("验证码错误", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();//输入错误，输入框获取焦点
                label1_Click(null, null);
                return;
            }
            //验证数据库中用户名、密码、用户类型是否正确
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string strsql = "select count(*) from admin where loginUserName='"+ txtUserName.Text +"' and loginPassWord='"+ txtPassWord.Text +"' and loginUserType='"+ cmbType.Text +"'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(strsql, conn);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("登录成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("用户名密码或登录类型不正确", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //显示主窗体
            if (this.cmbType.Text.Trim() == "学生")
            {
                ExamStar examStar = new ExamStar();
                examStar.username = this.txtUserName.Text;
                examStar.Show();
            }
            else if (this.cmbType.Text.Trim() == "教师")
            {
                Teacher teacher = new Teacher();
                teacher.Show();
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            ShowCode();//刷新验证码
        }
    }
}
