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
    public partial class RefactorDoc : Form
    {
        Doctor doctor;
        SqlConnection sqlcon = new SqlConnection("server=DESKTOP-Q01BBV8;user id=sa;password=333;database=Diabetes");
        public RefactorDoc(Doctor doctor)
        {
            this.doctor = doctor;
            InitializeComponent();
            dnoLB2.Text = Convert.ToString(doctor.Dno);
            nameTxB.Text = doctor.Name;
            identifacationLB2.Text = Convert.ToString(doctor.Identification);
            patientNumLB2.Text = Convert.ToString(doctor.PatientsNum);
            ageTxB.Text = Convert.ToString(doctor.Age);
            if (doctor.Sex == "female")
            {
                girl.Checked = true;
                boy.Checked = false;
            }
            else
            {
                boy.Checked = true;
                girl.Checked = false;
            }
        }
        private void resetBTN_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = new SqlCommand("update t_doctor set password = '123456' where dno = @dno");
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@dno", doctor.Dno);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("重置密码成功，新密码为123456");
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string msg = "确定要删除" + doctor.Name + "医生执照吗？";
            if ((int)MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
            {
                return;
            }
            else
            {
                SqlCommand sqlcom = new SqlCommand("update t_doctor set identification = 0 where dno = @dno");
                sqlcom.Connection = sqlcon;
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                sqlcon.Open();
                sqlcom.Parameters.Clear();
                sqlcom.Parameters.AddWithValue("@dno", doctor.Dno);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("删除执照成功");
                return;
            }
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = new SqlCommand("update t_doctor set name = @name,age = @age,sex = @sex where dno = @dno");
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.Parameters.Clear();
            doctor.Name = nameTxB.Text;
            doctor.Age = Convert.ToInt32(ageTxB.Text);
            if (girl.Checked == true)
            {
                doctor.Sex = "female";
            }
            else
            {
                doctor.Sex = "male";
            }
            sqlcom.Parameters.AddWithValue("@name", doctor.Name);
            sqlcom.Parameters.AddWithValue("@age", doctor.Age);
            sqlcom.Parameters.AddWithValue("@sex", doctor.Sex);
            sqlcom.Parameters.AddWithValue("@dno", doctor.Dno);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("修改成功");
        }
    }
}
