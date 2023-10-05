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
using System.IO;

namespace ExamOnline
{
    public partial class Register : Form
    {
        ValidateCode code = new ValidateCode();//实例化生成验证码的类
        private string vcode = string.Empty;//声明存储验证码的字符串变量
        public Register()
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

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
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
            //3.再次确认密码
            if (this.txtPassWordAgain.Text.Trim()!=this.txtPassWord.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPassWordAgain.Focus();//光标归为到确认密码
                return;
            }
            //4.验证用户类型不能为空
            if (this.cmbType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请选择用户类型", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbType.Focus();//光标归位到用户类型
                return;
            }
            else if(this.cmbType.Text.Trim() != "学生" )
            {
                MessageBox.Show("只能进行学生注册", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cmbType.Focus();
                return;
            }
            //5.验证姓名不能为空
            if (this.txtName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入姓名", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtName.Focus();//光标归为到姓名
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
            //6.判断数据库中是否存在该账户
            string connStr = @"Data Source=LAPTOP-GLILAS4P;Initial Catalog=ExamOnline;User Id=sa;Password=123456";
            SqlConnection conn = new SqlConnection(connStr);
            string strsql1 = "select count(*) from admin where loginUserName='" + txtUserName.Text + "'";
            string strsql2 = "insert into admin(loginUserName,loginPassWord,loginUserType,Name) values('" + txtUserName.Text + "', '" + txtPassWord.Text + "', '" + cmbType.Text + "', '"+ txtName.Text +"')";
            conn.Open();
            SqlCommand cmd1 = new SqlCommand(strsql1, conn);
            int count = Convert.ToInt32(cmd1.ExecuteScalar());
            conn.Close();
            if (count > 0)
            {
                MessageBox.Show("用户名已存在", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                //写入用户
                SqlCommand cmd2 = new SqlCommand(strsql2, conn);
                conn.Open();
                if (Convert.ToInt32(cmd2.ExecuteNonQuery()) > 0)
                {
                    MessageBox.Show("注册成功", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                conn.Close();
            }
        }

        private void lblPassWordAgain_Click(object sender, EventArgs e)
        {

        }

        private void btnCacel_Click(object sender, EventArgs e)
        {
            //取消按钮
            DialogResult result = MessageBox.Show("确定关闭吗？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowCode();//刷新验证码
        }
    }
}
