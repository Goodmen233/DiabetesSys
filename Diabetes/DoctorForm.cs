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
using System.Text.RegularExpressions;

namespace Diabetes
{
    public partial class DoctorForm : Form
    {
        public static string pno; // 定义全局变量患者编号
        public static string pname; // 定义全局变量患者姓名

        Doctor doc = new Doctor();

        //定义数据库连接
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();

        public DoctorForm()
        {
            InitializeComponent();

        }

        public DoctorForm(Doctor doctor)
        {
            InitializeComponent();

            this.doc = doctor;
        }



        public void FillList()
        {
            //定义填充ListView函数
            lstgly.Items.Clear();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "select p.pno,name ,value,time from t_patient p ,t_glycemicIndex g where p.pno = g.pno ; ";
            SqlDataReader sqldr = sqlCmd.ExecuteReader();
            while (sqldr.Read())
            {
                ListViewItem lvi = new ListViewItem(sqldr[0].ToString());
                lvi.SubItems.Add(sqldr[1].ToString());
                lvi.SubItems.Add(sqldr[2].ToString());
                lvi.SubItems.Add(sqldr[3].ToString());
                //lvi.SubItems.Add(sqldr[4].ToString());


                this.lstgly.Items.Add(lvi);


            }
            sqldr.Close();
        }

        public void Clear()
        {
            txtname.Text = "";
            txtage.Text = "";
            txtphone.Text = "";
            man.Checked = true;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //连接数据库
            sqlCon.ConnectionString = "server=DESKTOP-Q01BBV8;user id=sa;password=333;database=Diabetes";
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            sqlCon.Open();
            FillList();

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "select name,patientsNum from t_doctor where dno = '" + doc.Dno + "'";
            SqlDataReader sqldr = sqlCmd.ExecuteReader();
            while (sqldr.Read())
            {
                show_name.Text = "欢迎亲爱的 " + sqldr[0].ToString() + " 医生 ,您好";
                show_num.Text = "您有 " + sqldr[1].ToString() + " 位病人等待诊断";
            }
            sqldr.Close();
        }

        private void uibtw_Click(object sender, EventArgs e)
        {
            Diagnose diagnose = new Diagnose();
            diagnose.Show();
        }

        private void lstgly_Click(object sender, EventArgs e)
        {
            pno = this.lstgly.SelectedItems[0].Text;
            pname = this.lstgly.SelectedItems[0].SubItems[1].Text;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (txtpno.Text != "")
            {
                //定义填充ListView函数
                lstgly.Items.Clear();
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "select p.pno,name ,value,time from t_patient p ,t_glycemicIndex g where p.pno = g.pno and p.pno = '" + txtpno.Text + "'";
                SqlDataReader sqldr = sqlCmd.ExecuteReader();
                while (sqldr.Read())
                {
                    ListViewItem lvi = new ListViewItem(sqldr[0].ToString());
                    lvi.SubItems.Add(sqldr[1].ToString());
                    lvi.SubItems.Add(sqldr[2].ToString());
                    lvi.SubItems.Add(sqldr[3].ToString());

                    this.lstgly.Items.Add(lvi);


                }
                sqldr.Close();
            }
        }

        private void modificate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("没有要修改的姓名信息，请在表中选择要修改的用户");
                return;
            }

            if (txtage.Text == "")
            {
                MessageBox.Show("没有要修改的年龄信息，请在表中选择要修改的用户");
                return;
            }

            if (txtphone.Text != "")
            {
                //判断联系方式位数规范
                if (txtphone.Text.Length != 11)
                {
                    MessageBox.Show("联系方式位数不符");
                    return;
                }
                //判断联系方式字符规范
                string RegexStr = string.Empty;
                RegexStr = "^[0-9]+$";  //匹配字符串的开始和结束是否为0-9的数字[定位字符]
                Boolean phone;
                phone = Regex.IsMatch(txtphone.Text, RegexStr);
                if (phone == false)
                {
                    MessageBox.Show("请按电脑号码输入格式输入");
                    txtphone.SelectionStart = 0;
                    txtphone.SelectionLength = txtphone.TextLength;
                    txtphone.Focus();
                    return;
                }
                string st = "";
                if (man.Checked == true)
                    st = "男";
                else
                    st = "女";
                sqlCmd.Connection = sqlCon;
                sqlCmd.CommandText = "update t_doctor set name = '" + txtname.Text + "',age = '" + txtage.Text + "',phone = '" + txtphone.Text + "',sex = '" + st + "'where dno = '" + doc.Dno + "'";
                sqlCmd.ExecuteNonQuery();

                Clear();
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (oldpwd.Text == "")
            {
                MessageBox.Show("没有要修改的原密码信息，请在表中选择要修改的用户");
                return;
            }

            if (newpwd.Text == "")
            {
                MessageBox.Show("没有要修改的新密码信息，请在表中选择要修改的用户");
                return;
            }

            if (newpwd2.Text == "")
            {
                MessageBox.Show("没有要修改的再一次新密码信息，请在表中选择要修改的用户");
                return;
            }

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "select password from t_doctor where dno = '" + doc.Dno + "'";


            if (oldpwd.Text.Equals(sqlCmd.ExecuteScalar()))
            {
                if (newpwd.Text == newpwd2.Text)
                {
                    sqlCmd.Connection = sqlCon;
                    sqlCmd.CommandText = "update t_doctor set password = '" + newpwd2.Text + "' where dno = '" + doc.Dno + "'";
                    sqlCmd.ExecuteNonQuery();

                    oldpwd.Text = "";
                    newpwd.Text = "";
                    newpwd2.Text = "";
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致，请重新输入");
                    return;
                }
            }
            else
            {
                MessageBox.Show("密码输入不正确，请重新输入");
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            show_time.Text = DateTime.Now.ToString("yyyy年MM月dd日hh时mm分ss秒");
        }

        private void select_Click(object sender, EventArgs e)
        {
            FillList();
        }
    }
}
