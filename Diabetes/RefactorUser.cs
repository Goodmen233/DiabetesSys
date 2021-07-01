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
    public partial class RefactorUser : Form
    {
        SqlConnection sqlcon = new SqlConnection("server=DESKTOP-Q01BBV8;user id=sa;password=333;database=Diabetes");
        Patient patient;
        public RefactorUser(Patient patient)
        {
            this.patient = patient;
            InitializeComponent();
            pnoLB2.Text = Convert.ToString(patient.Pno);
            nameTxB.Text = patient.Name;
            ageTxB.Text = Convert.ToString(patient.Age);
            phoneTxB.Text = patient.Phone;
            attendingDocLB2.Text = Convert.ToString(patient.AttendingDoctor);
            if (patient.Sex == "female")
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
            SqlCommand sqlcom = new SqlCommand("update t_patient set password = '123456' where pno = @pno");
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@pno", patient.Pno);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("重置密码成功，新密码为123456");
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string msg = "确定要删除" + patient.Name + "吗？";
            if ((int)MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
            {
                return;
            }
            else
            {
                SqlCommand sqlcom = new SqlCommand("update t_patient set phone='####' where pno = @pno");
                sqlcom.Connection = sqlcon;
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                sqlcon.Open();
                sqlcom.Parameters.Clear();
                sqlcom.Parameters.AddWithValue("@pno", patient.Pno);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("删除成功");
                return;
            }
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            SqlCommand sqlcom = new SqlCommand("update t_patient set name = @name,age = @age,sex = @sex,phone = @phone where pno = @pno");
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.Parameters.Clear();
            patient.Name = nameTxB.Text;
            patient.Age = Convert.ToInt32(ageTxB.Text);
            if (girl.Checked == true)
            {
                patient.Sex = "female";
            }
            else
            {
                patient.Sex = "male";
            }
            patient.Phone = phoneTxB.Text;
            sqlcom.Parameters.AddWithValue("@name", patient.Name);
            sqlcom.Parameters.AddWithValue("@age", patient.Age);
            sqlcom.Parameters.AddWithValue("@sex", patient.Sex);
            sqlcom.Parameters.AddWithValue("@phone", patient.Phone);
            sqlcom.Parameters.AddWithValue("@pno", patient.Pno);
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            MessageBox.Show("修改成功");
        }
    }
}
