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

namespace Diabetes
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlcon =
            new SqlConnection("server=DESKTOP-Q01BBV8;user id=sa;password=333;database=Diabetes");
        public LoginForm()
        {
            InitializeComponent();//初始化界面
        }

        private void LoginBTN_Click(object sender, EventArgs e)//登录按钮点击事件
        {
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.CommandText = "select * from t_admin where phone = @phone";//从管理员表开始查找
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@phone", AccountTxB.Text);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())//如果有找到，则进行密码正确性比较
            {
                Admin a1 = new Admin();//创建一个管理员对象
                a1.Ano = Convert.ToInt32(reader["ano"].ToString());
                a1.Name = reader["name"].ToString();
                a1.Age = Convert.ToInt32(reader["age"].ToString());
                a1.Sex = reader["sex"].ToString();
                a1.Phone = reader["phone"].ToString();
                a1.Email = reader["email"].ToString();
                a1.Password = reader["password"].ToString();
                if (string.Equals(a1.Password, PwdBtn.Text))
                {
                    Form ad = new AdminForm(a1);
                    ad.Show();
                }
                else//如果验证未通过，弹出窗口提示
                {
                    MessageBox.Show("密码不对");
                    MessageBox.Show("密码用户名不存在或密码输入错误");
                    reader.Close();
                    sqlcon.Close();
                }
            }
            else//管理员表中没有找到该数据，开始遍历医生表
            {
                reader.Close();
                sqlcom.CommandText = "select * from t_doctor where phone = @phone;";
                sqlcom.Parameters.Clear();
                sqlcom.Parameters.AddWithValue("@phone", AccountTxB.Text);
                reader = sqlcom.ExecuteReader();
                if (reader.Read())
                {
                    Doctor d1 = new Doctor();
                    d1.Dno = Convert.ToInt32(reader["dno"].ToString());
                    d1.Name = reader["name"].ToString();
                    d1.Age = Convert.ToInt32(reader["age"].ToString());
                    d1.Phone = reader["phone"].ToString();
                    d1.Password = reader["password"].ToString();
                    if (reader["identification"].ToString() == "True")
                    {
                        d1.Identification = true;
                    }
                    else
                    {
                        d1.Identification = false;
                    }
                    d1.PatientsNum = Convert.ToInt32(reader["patientsNum"].ToString());
                    if (d1.Password == PwdBtn.Text)
                    {
                        //生成医生窗口
                        new DoctorForm(d1).Show();

                    }
                    else
                    {
                        MessageBox.Show("用户名不存在或密码错误");
                        PwdBtn.Text = "";
                    }
                }
                else//医生表中还是没有找到，遍历用户列表
                {
                    reader.Close();
                    sqlcom.CommandText = "select * from t_patient where phone = @phone;";
                    sqlcom.Parameters.Clear();
                    sqlcom.Parameters.AddWithValue("@phone", AccountTxB.Text);
                    reader = sqlcom.ExecuteReader();
                    if (reader.Read())
                    {
                        Patient p1 = new Patient();
                        p1.Pno = Convert.ToInt32(reader["pno"].ToString());
                        p1.Name = reader["name"].ToString();
                        p1.Age = Convert.ToInt32(reader["age"].ToString());
                        p1.Sex = reader["sex"].ToString();
                        p1.Phone = reader["phone"].ToString();
                        p1.Password = reader["password"].ToString();
                        p1.AttendingDoctor = Convert.ToInt32(reader["attendingDoctor"].ToString());
                        p1.Type = reader["type"].ToString();
                        if (p1.Password == PwdBtn.Text)
                        {
                            //弹出患者窗口
                            new patientForm(p1).Show();
                        }
                        else
                        {
                            MessageBox.Show("用户名不存在或密码错误");
                            PwdBtn.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("用户名不存在或密码错误");
                        PwdBtn.Text = "";
                    }
                }
                reader.Close();
                sqlcon.Close();
            }

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("密码都记不住，吃屎长大的你 \n 爬去找管理员");
        }
        private void AccountTxB_MouseClick(object sender, EventArgs e)
        {
            if (AccountTxB.Text == "账号")
            {
                AccountTxB.Text = "";
            }
        }

        private void PwdBtn_Click(object sender, EventArgs e)
        {
            if (PwdBtn.Text == "密码")
            {
                PwdBtn.Text = "";
            }
            PwdBtn.PasswordChar = '*';
        }
    }
}
