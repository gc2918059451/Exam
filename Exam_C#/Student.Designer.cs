
namespace ExamOnline
{
    partial class Student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rbtn_D = new System.Windows.Forms.RadioButton();
            this.rbtn_C = new System.Windows.Forms.RadioButton();
            this.rbtn_B = new System.Windows.Forms.RadioButton();
            this.rbtn_A = new System.Windows.Forms.RadioButton();
            this.lblExam = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rbtnpd_false = new System.Windows.Forms.RadioButton();
            this.rbtnpd_true = new System.Windows.Forms.RadioButton();
            this.lblpdExam = new System.Windows.Forms.Label();
            this.btnpdNext = new System.Windows.Forms.Button();
            this.btnpdUp = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btntkUp = new System.Windows.Forms.Button();
            this.btntkNext = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.lbltk = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtjd = new System.Windows.Forms.TextBox();
            this.lbljd = new System.Windows.Forms.Label();
            this.btnJiaojuan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.Daojishi = new System.Windows.Forms.Label();
            this.DjsXianshi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(60, 40);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1279, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.rbtn_D);
            this.tabPage1.Controls.Add(this.rbtn_C);
            this.tabPage1.Controls.Add(this.rbtn_B);
            this.tabPage1.Controls.Add(this.rbtn_A);
            this.tabPage1.Controls.Add(this.lblExam);
            this.tabPage1.Controls.Add(this.btnNext);
            this.tabPage1.Controls.Add(this.btnUp);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 44);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1271, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单选题";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // rbtn_D
            // 
            this.rbtn_D.AutoSize = true;
            this.rbtn_D.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_D.Location = new System.Drawing.Point(11, 152);
            this.rbtn_D.Name = "rbtn_D";
            this.rbtn_D.Size = new System.Drawing.Size(46, 29);
            this.rbtn_D.TabIndex = 6;
            this.rbtn_D.TabStop = true;
            this.rbtn_D.Text = "D";
            this.rbtn_D.UseVisualStyleBackColor = true;
            this.rbtn_D.CheckedChanged += new System.EventHandler(this.rbtn_D_CheckedChanged);
            // 
            // rbtn_C
            // 
            this.rbtn_C.AutoSize = true;
            this.rbtn_C.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_C.Location = new System.Drawing.Point(11, 117);
            this.rbtn_C.Name = "rbtn_C";
            this.rbtn_C.Size = new System.Drawing.Size(46, 29);
            this.rbtn_C.TabIndex = 5;
            this.rbtn_C.TabStop = true;
            this.rbtn_C.Text = "C";
            this.rbtn_C.UseVisualStyleBackColor = true;
            this.rbtn_C.CheckedChanged += new System.EventHandler(this.rbtn_C_CheckedChanged);
            // 
            // rbtn_B
            // 
            this.rbtn_B.AutoSize = true;
            this.rbtn_B.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_B.Location = new System.Drawing.Point(11, 82);
            this.rbtn_B.Name = "rbtn_B";
            this.rbtn_B.Size = new System.Drawing.Size(46, 29);
            this.rbtn_B.TabIndex = 4;
            this.rbtn_B.TabStop = true;
            this.rbtn_B.Text = "B";
            this.rbtn_B.UseVisualStyleBackColor = true;
            this.rbtn_B.CheckedChanged += new System.EventHandler(this.rbtn_B_CheckedChanged);
            // 
            // rbtn_A
            // 
            this.rbtn_A.AutoSize = true;
            this.rbtn_A.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtn_A.Location = new System.Drawing.Point(11, 47);
            this.rbtn_A.Name = "rbtn_A";
            this.rbtn_A.Size = new System.Drawing.Size(46, 29);
            this.rbtn_A.TabIndex = 3;
            this.rbtn_A.TabStop = true;
            this.rbtn_A.Text = "A";
            this.rbtn_A.UseVisualStyleBackColor = true;
            this.rbtn_A.CheckedChanged += new System.EventHandler(this.rbtn_A_CheckedChanged);
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExam.Location = new System.Drawing.Point(6, 3);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(73, 30);
            this.lblExam.TabIndex = 2;
            this.lblExam.Text = "题目";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Gold;
            this.btnNext.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNext.Location = new System.Drawing.Point(155, 195);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(103, 46);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Gold;
            this.btnUp.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUp.Location = new System.Drawing.Point(11, 195);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(103, 46);
            this.btnUp.TabIndex = 0;
            this.btnUp.Text = "上一题";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.rbtnpd_false);
            this.tabPage2.Controls.Add(this.rbtnpd_true);
            this.tabPage2.Controls.Add(this.lblpdExam);
            this.tabPage2.Controls.Add(this.btnpdNext);
            this.tabPage2.Controls.Add(this.btnpdUp);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 44);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1271, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "判断题";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rbtnpd_false
            // 
            this.rbtnpd_false.AutoSize = true;
            this.rbtnpd_false.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnpd_false.Location = new System.Drawing.Point(11, 86);
            this.rbtnpd_false.Name = "rbtnpd_false";
            this.rbtnpd_false.Size = new System.Drawing.Size(61, 32);
            this.rbtnpd_false.TabIndex = 11;
            this.rbtnpd_false.TabStop = true;
            this.rbtnpd_false.Text = "×";
            this.rbtnpd_false.UseVisualStyleBackColor = true;
            this.rbtnpd_false.CheckedChanged += new System.EventHandler(this.rbtnpd_false_CheckedChanged);
            // 
            // rbtnpd_true
            // 
            this.rbtnpd_true.AutoSize = true;
            this.rbtnpd_true.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbtnpd_true.Location = new System.Drawing.Point(11, 48);
            this.rbtnpd_true.Name = "rbtnpd_true";
            this.rbtnpd_true.Size = new System.Drawing.Size(61, 32);
            this.rbtnpd_true.TabIndex = 10;
            this.rbtnpd_true.TabStop = true;
            this.rbtnpd_true.Text = "√";
            this.rbtnpd_true.UseVisualStyleBackColor = true;
            this.rbtnpd_true.CheckedChanged += new System.EventHandler(this.rbtnpd_true_CheckedChanged);
            // 
            // lblpdExam
            // 
            this.lblpdExam.AutoSize = true;
            this.lblpdExam.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblpdExam.Location = new System.Drawing.Point(6, 3);
            this.lblpdExam.Name = "lblpdExam";
            this.lblpdExam.Size = new System.Drawing.Size(73, 30);
            this.lblpdExam.TabIndex = 9;
            this.lblpdExam.Text = "题目";
            // 
            // btnpdNext
            // 
            this.btnpdNext.BackColor = System.Drawing.Color.Gold;
            this.btnpdNext.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnpdNext.Location = new System.Drawing.Point(153, 141);
            this.btnpdNext.Name = "btnpdNext";
            this.btnpdNext.Size = new System.Drawing.Size(103, 44);
            this.btnpdNext.TabIndex = 8;
            this.btnpdNext.Text = "下一题";
            this.btnpdNext.UseVisualStyleBackColor = false;
            this.btnpdNext.Click += new System.EventHandler(this.btnpdNext_Click);
            // 
            // btnpdUp
            // 
            this.btnpdUp.BackColor = System.Drawing.Color.Gold;
            this.btnpdUp.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnpdUp.Location = new System.Drawing.Point(6, 139);
            this.btnpdUp.Name = "btnpdUp";
            this.btnpdUp.Size = new System.Drawing.Size(103, 46);
            this.btnpdUp.TabIndex = 7;
            this.btnpdUp.Text = "上一题";
            this.btnpdUp.UseVisualStyleBackColor = false;
            this.btnpdUp.Click += new System.EventHandler(this.btnpdUp_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.btntkUp);
            this.tabPage3.Controls.Add(this.btntkNext);
            this.tabPage3.Controls.Add(this.txttk);
            this.tabPage3.Controls.Add(this.lbltk);
            this.tabPage3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1271, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "填空题";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btntkUp
            // 
            this.btntkUp.BackColor = System.Drawing.Color.Gold;
            this.btntkUp.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btntkUp.Location = new System.Drawing.Point(11, 97);
            this.btntkUp.Name = "btntkUp";
            this.btntkUp.Size = new System.Drawing.Size(103, 44);
            this.btntkUp.TabIndex = 11;
            this.btntkUp.Text = "上一题";
            this.btntkUp.UseVisualStyleBackColor = false;
            this.btntkUp.Click += new System.EventHandler(this.btntkUp_Click);
            // 
            // btntkNext
            // 
            this.btntkNext.BackColor = System.Drawing.Color.Gold;
            this.btntkNext.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btntkNext.Location = new System.Drawing.Point(158, 97);
            this.btntkNext.Name = "btntkNext";
            this.btntkNext.Size = new System.Drawing.Size(103, 44);
            this.btntkNext.TabIndex = 10;
            this.btntkNext.Text = "下一题";
            this.btntkNext.UseVisualStyleBackColor = false;
            this.btntkNext.Click += new System.EventHandler(this.btntkNext_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(11, 49);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(250, 30);
            this.txttk.TabIndex = 1;
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            // 
            // lbltk
            // 
            this.lbltk.AutoSize = true;
            this.lbltk.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbltk.Location = new System.Drawing.Point(6, 3);
            this.lbltk.Name = "lbltk";
            this.lbltk.Size = new System.Drawing.Size(73, 30);
            this.lbltk.TabIndex = 0;
            this.lbltk.Text = "题目";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtjd);
            this.tabPage4.Controls.Add(this.lbljd);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1271, 530);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "简答题";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // txtjd
            // 
            this.txtjd.Location = new System.Drawing.Point(11, 47);
            this.txtjd.Multiline = true;
            this.txtjd.Name = "txtjd";
            this.txtjd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtjd.Size = new System.Drawing.Size(398, 257);
            this.txtjd.TabIndex = 1;
            this.txtjd.TextChanged += new System.EventHandler(this.txtjd_TextChanged);
            // 
            // lbljd
            // 
            this.lbljd.AutoSize = true;
            this.lbljd.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbljd.Location = new System.Drawing.Point(6, 3);
            this.lbljd.Name = "lbljd";
            this.lbljd.Size = new System.Drawing.Size(73, 30);
            this.lbljd.TabIndex = 0;
            this.lbljd.Text = "题目";
            // 
            // btnJiaojuan
            // 
            this.btnJiaojuan.BackColor = System.Drawing.Color.Gold;
            this.btnJiaojuan.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJiaojuan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnJiaojuan.Location = new System.Drawing.Point(1131, 38);
            this.btnJiaojuan.Name = "btnJiaojuan";
            this.btnJiaojuan.Size = new System.Drawing.Size(116, 53);
            this.btnJiaojuan.TabIndex = 1;
            this.btnJiaojuan.Text = "交 卷";
            this.btnJiaojuan.UseVisualStyleBackColor = false;
            this.btnJiaojuan.Click += new System.EventHandler(this.btnJiaojuan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "用户名：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(119, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "label3";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(119, 52);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(90, 25);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "label4";
            // 
            // Daojishi
            // 
            this.Daojishi.AutoSize = true;
            this.Daojishi.BackColor = System.Drawing.SystemColors.Control;
            this.Daojishi.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Daojishi.Location = new System.Drawing.Point(645, 47);
            this.Daojishi.Name = "Daojishi";
            this.Daojishi.Size = new System.Drawing.Size(163, 30);
            this.Daojishi.TabIndex = 6;
            this.Daojishi.Text = "剩余时间：";
            // 
            // DjsXianshi
            // 
            this.DjsXianshi.AutoSize = true;
            this.DjsXianshi.BackColor = System.Drawing.Color.Cornsilk;
            this.DjsXianshi.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DjsXianshi.Location = new System.Drawing.Point(814, 47);
            this.DjsXianshi.Name = "DjsXianshi";
            this.DjsXianshi.Size = new System.Drawing.Size(148, 30);
            this.DjsXianshi.TabIndex = 7;
            this.DjsXianshi.Text = "?时?分?秒";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 687);
            this.Controls.Add(this.DjsXianshi);
            this.Controls.Add(this.Daojishi);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJiaojuan);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生端";
            this.Load += new System.EventHandler(this.Student_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnJiaojuan;
        private System.Windows.Forms.RadioButton rbtn_D;
        private System.Windows.Forms.RadioButton rbtn_C;
        private System.Windows.Forms.RadioButton rbtn_B;
        private System.Windows.Forms.RadioButton rbtn_A;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.RadioButton rbtnpd_false;
        private System.Windows.Forms.RadioButton rbtnpd_true;
        private System.Windows.Forms.Label lblpdExam;
        private System.Windows.Forms.Button btnpdNext;
        private System.Windows.Forms.Button btnpdUp;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label lbltk;
        private System.Windows.Forms.Button btntkNext;
        private System.Windows.Forms.Button btntkUp;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtjd;
        private System.Windows.Forms.Label lbljd;
        private System.Windows.Forms.Label Daojishi;
        private System.Windows.Forms.Label DjsXianshi;
        private System.Windows.Forms.Timer timer1;
    }
}