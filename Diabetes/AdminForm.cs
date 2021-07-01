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
    public partial class AdminForm : Form
    {
        Admin admin;
        SqlConnection sqlcon = new SqlConnection("server=DESKTOP-Q01BBV8;user id=sa;password=333;database=Diabetes");
        public AdminForm(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;

            //初始化查找医生的窗体
            updateDocView();

            //初始化搜索用户界面的窗体
            updateUserView();

            //初始化审批窗体
            updateAprView();
        }
        private void updateAprView()
        {
            ApprovalLB2.Visible = false;
            ApprovalLVW.Clear();
            ApprovalLVW.Columns.Add("医生编号");
            ApprovalLVW.Columns[0].Width = 100;
            ApprovalLVW.Columns.Add("名字");
            ApprovalLVW.Columns[1].Width = 120;
            ApprovalLVW.Columns.Add("性别");
            ApprovalLVW.Columns[2].Width = 120;
            ApprovalLVW.Columns.Add("手机号");
            ApprovalLVW.Columns[3].Width = 150;
            ApprovalLVW.Columns.Add("是否审批");
            ApprovalLVW.Columns[4].Width = 100;
            ApprovalLVW.Columns.Add("");
            ApprovalLVW.Columns[5].Width = 60;

            SqlCommand unAproval = new SqlCommand();
            unAproval.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            unAproval.CommandText = "select * from t_doctor where identification = 0";
            SqlDataReader unreader = unAproval.ExecuteReader();
            while (unreader.Read())
            {
                ListViewItem it = new ListViewItem(unreader["dno"].ToString());
                it.SubItems.Add(unreader["name"].ToString());
                it.SubItems.Add(unreader["sex"].ToString());
                it.SubItems.Add(unreader["phone"].ToString());
                it.SubItems.Add(unreader["identification"].ToString());
                it.SubItems.Add("审批");

                ApprovalLVW.Items.Add(it);
            }
            if (ApprovalLVW.Items.Count == 0)
            {
                ApprovalLB2.Visible = true;
            }
            unreader.Close();
            sqlcon.Close();
        }
        private void updateDocView()
        {
            DocLVW.Clear();
            DocLVW.Columns.Add("医生编号");
            DocLVW.Columns[0].Width = 100;
            DocLVW.Columns.Add("名字");
            DocLVW.Columns[1].Width = 120;
            DocLVW.Columns.Add("性别");
            DocLVW.Columns[2].Width = 120;
            DocLVW.Columns.Add("手机号");
            DocLVW.Columns[3].Width = 150;
            DocLVW.Columns.Add("是否审批");
            DocLVW.Columns[4].Width = 100;
            DocLVW.Columns.Add("病人数");
            DocLVW.Columns[5].Width = 100;
            DocLVW.Columns.Add("");
            DocLVW.Columns[6].Width = 60;
            DocLVW.Columns.Add("");
            DocLVW.Columns[7].Width = 60;

            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.CommandText = "select * from t_doctor;";
            SqlDataReader allDoc = sqlcom.ExecuteReader();
            while (allDoc.Read())
            {
                ListViewItem it = new ListViewItem(allDoc["dno"].ToString());
                it.SubItems.Add(allDoc["name"].ToString());
                it.SubItems.Add(allDoc["sex"].ToString());
                it.SubItems.Add(allDoc["phone"].ToString());
                it.SubItems.Add(allDoc["identification"].ToString());
                it.SubItems.Add(allDoc["patientsNum"].ToString());
                it.SubItems.Add("编辑");
                it.SubItems.Add("删除");
                DocLVW.Items.Add(it);
            }
            allDoc.Close();
            sqlcon.Close();
        }

        private void updateUserView()
        {
            UserLVW.Clear();
            UserLVW.Columns.Add("用户编号");
            UserLVW.Columns[0].Width = 100;
            UserLVW.Columns.Add("名字");
            UserLVW.Columns[1].Width = 120;
            UserLVW.Columns.Add("性别");
            UserLVW.Columns[2].Width = 120;
            UserLVW.Columns.Add("手机号");
            UserLVW.Columns[3].Width = 150;
            UserLVW.Columns.Add("主治医生");
            UserLVW.Columns[4].Width = 150;
            UserLVW.Columns.Add("");
            UserLVW.Columns[5].Width = 60;
            UserLVW.Columns.Add("");
            UserLVW.Columns[6].Width = 60;
            SqlCommand sqlcomuser = new SqlCommand("select * from t_patient");
            sqlcomuser.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            SqlDataReader allPatients = sqlcomuser.ExecuteReader();
            while (allPatients.Read())
            {
                ListViewItem it = new ListViewItem(allPatients["pno"].ToString());
                it.SubItems.Add(allPatients["name"].ToString());
                it.SubItems.Add(allPatients["sex"].ToString());
                it.SubItems.Add(allPatients["phone"].ToString());
                it.SubItems.Add(allPatients["attendingDoctor"].ToString());
                it.SubItems.Add("编辑");
                it.SubItems.Add("删除");

                UserLVW.Items.Add(it);
            }
            allPatients.Close();
            sqlcon.Close();
        }

        private void DocBTN_Click(object sender, EventArgs e)//点击医生界面的按钮事件
        {
            DocLB2.Visible = false;

            DocLVW.Clear();
            DocLVW.Columns.Add("医生编号");
            DocLVW.Columns[0].Width = 100;
            DocLVW.Columns.Add("名字");
            DocLVW.Columns[1].Width = 120;
            DocLVW.Columns.Add("性别");
            DocLVW.Columns[2].Width = 120;
            DocLVW.Columns.Add("手机号");
            DocLVW.Columns[3].Width = 150;
            DocLVW.Columns.Add("是否审批");
            DocLVW.Columns[4].Width = 100;
            DocLVW.Columns.Add("病人数");
            DocLVW.Columns[5].Width = 100;
            DocLVW.Columns.Add("");
            DocLVW.Columns[6].Width = 60;
            DocLVW.Columns.Add("");
            DocLVW.Columns[7].Width = 60;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.CommandText = "select * from t_doctor where name like @doc_name;";
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@doc_name", "%" + DocTxB.Text + "%");
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                while (reader.Read())
                {
                    ListViewItem it = new ListViewItem(reader["dno"].ToString());
                    it.SubItems.Add(reader["name"].ToString());
                    it.SubItems.Add(reader["sex"].ToString());
                    it.SubItems.Add(reader["phone"].ToString());
                    it.SubItems.Add(reader["identification"].ToString());
                    it.SubItems.Add(reader["patientsNum"].ToString());
                    it.SubItems.Add("编辑");
                    it.SubItems.Add("删除");
                    DocLVW.Items.Add(it);
                }
            }
            else
            {
                DocLB2.Visible = true;
            }
            reader.Close();
            sqlcon.Close();
        }

        private void UserBTN_Click(object sender, EventArgs e)//点击用户界面的按钮事件
        {
            UserLVW.Clear();
            UserLVW.Columns.Add("用户编号");
            UserLVW.Columns[0].Width = 100;
            UserLVW.Columns.Add("名字");
            UserLVW.Columns[1].Width = 120;
            UserLVW.Columns.Add("性别");
            UserLVW.Columns[2].Width = 120;
            UserLVW.Columns.Add("手机号");
            UserLVW.Columns[3].Width = 150;
            UserLVW.Columns.Add("主治医生");
            UserLVW.Columns[4].Width = 150;
            UserLVW.Columns.Add("");
            UserLVW.Columns[5].Width = 60;
            UserLVW.Columns.Add("");
            UserLVW.Columns[6].Width = 60;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.CommandText = "select * from t_patient where name like @name";
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@name", "%" + UserTxB.Text + "%");
            SqlDataReader userReader = sqlcom.ExecuteReader();
            while (userReader.Read())
            {
                ListViewItem it = new ListViewItem(userReader["pno"].ToString());
                it.SubItems.Add(userReader["name"].ToString());
                it.SubItems.Add(userReader["sex"].ToString());
                it.SubItems.Add(userReader["phone"].ToString());
                it.SubItems.Add(userReader["attendingDoctor"].ToString());
                it.SubItems.Add("编辑");
                it.SubItems.Add("删除");

                UserLVW.Items.Add(it);
            }
            userReader.Close();
            sqlcon.Close();
        }

        private void ApprovalBTN_Click(object sender, EventArgs e)//点击审批页面的修改按钮事件
        {
            ApprovalLB2.Visible = false;
            ApprovalLVW.Clear();
            ApprovalLVW.Columns.Add("医生编号");
            ApprovalLVW.Columns[0].Width = 100;
            ApprovalLVW.Columns.Add("名字");
            ApprovalLVW.Columns[1].Width = 120;
            ApprovalLVW.Columns.Add("性别");
            ApprovalLVW.Columns[2].Width = 120;
            ApprovalLVW.Columns.Add("手机号");
            ApprovalLVW.Columns[3].Width = 150;
            ApprovalLVW.Columns.Add("是否审批");
            ApprovalLVW.Columns[4].Width = 100;
            ApprovalLVW.Columns.Add("");
            ApprovalLVW.Columns[5].Width = 60;
            SqlCommand sqlcom = new SqlCommand();
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.CommandText = "select * from t_doctor where phone = @phone and identification = 0";
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@phone", ApprovalTxB.Text);
            SqlDataReader reader = sqlcom.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem it = new ListViewItem(reader["dno"].ToString());
                it.SubItems.Add(reader["name"].ToString());
                it.SubItems.Add(reader["sex"].ToString());
                it.SubItems.Add(reader["phone"].ToString());
                it.SubItems.Add(reader["identification"].ToString());
                it.SubItems.Add("审批");

                ApprovalLVW.Items.Add(it);
            }
            if(ApprovalLVW.Items.Count == 0)
            {
                ApprovalLB2.Visible = true;
            }
            reader.Close();
            sqlcon.Close();
        }

        private void DocLVW_ItemActivate(object sender, EventArgs e)//双击医生界面的listview，可以修改医生信息
        {
            Doctor doc = new Doctor();
            string dno = DocLVW.SelectedItems[0].SubItems[0].Text;
            SqlCommand sqlcom = new SqlCommand("select * from t_doctor where dno = @dno;");
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@dno", dno);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                doc.Dno = Convert.ToInt32(reader["dno"].ToString());
                doc.Name = reader["name"].ToString();
                doc.Age = Convert.ToInt32(reader["age"].ToString());
                doc.Phone = reader["phone"].ToString();
                doc.Password = reader["password"].ToString();
                if (reader["identification"].ToString() == "True")
                {
                    doc.Identification = true;
                }
                else
                {
                    doc.Identification = false;
                }
                doc.PatientsNum = Convert.ToInt32(reader["patientsNum"].ToString());
            }
            reader.Close();
            sqlcon.Close();
            //有一个医生对象，接下来修改医生的信息
            Form re = new RefactorDoc(doc);
            re.Show();

        }

        private void UserLVW_ItemActivate(object sender, EventArgs e)//双击用户界面的listview，可以修改用户信息
        {
            Patient pat = new Patient();
            string pno = UserLVW.SelectedItems[0].SubItems[0].Text;
            SqlCommand sqlcom = new SqlCommand("select * from t_patient where pno = @pno;");
            sqlcom.Connection = sqlcon;
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            sqlcon.Open();
            sqlcom.Parameters.Clear();
            sqlcom.Parameters.AddWithValue("@pno", pno);
            SqlDataReader reader = sqlcom.ExecuteReader();
            if (reader.Read())
            {
                pat.Pno = Convert.ToInt32(reader["pno"].ToString());
                pat.Name = reader["name"].ToString();
                pat.Age = Convert.ToInt32(reader["age"].ToString());
                pat.Sex = reader["sex"].ToString();
                pat.Phone = reader["phone"].ToString();
                pat.Password = reader["password"].ToString();
                pat.AttendingDoctor = Convert.ToInt32(reader["attendingDoctor"].ToString());
                pat.Type = reader["type"].ToString();
            }
            reader.Close();
            sqlcon.Close();
            //生成了一个用户对象，进入修改信息界面
            Form pa = new RefactorUser(pat);
            pa.Show();
        }

        private void ApprovalLVW_ItemActivate(object sender, EventArgs e)//双击审批页面的listview，可以修改未审批医生的审批状态。
        {
            string str = ApprovalLVW.SelectedItems[0].SubItems[0].Text;
            string name = ApprovalLVW.SelectedItems[0].SubItems[1].Text;
            string msg = "确定要将" + name + "审核为医生吗？";

            if ((int)MessageBox.Show(msg, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
            {
                return;
            }
            else
            {
                SqlCommand sqlcom = new SqlCommand("update t_doctor set identification = 1 where dno = @dno");
                sqlcom.Connection = sqlcon;
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                sqlcon.Open();
                sqlcom.Parameters.Clear();
                sqlcom.Parameters.AddWithValue("@dno", str);
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                MessageBox.Show("审批成功");
                //刷新界面
                ApprovalLB2.Visible = false;
                ApprovalLVW.Clear();
                ApprovalLVW.Columns.Add("医生编号");
                ApprovalLVW.Columns[0].Width = 100;
                ApprovalLVW.Columns.Add("名字");
                ApprovalLVW.Columns[1].Width = 120;
                ApprovalLVW.Columns.Add("性别");
                ApprovalLVW.Columns[2].Width = 120;
                ApprovalLVW.Columns.Add("手机号");
                ApprovalLVW.Columns[3].Width = 150;
                ApprovalLVW.Columns.Add("是否审批");
                ApprovalLVW.Columns[4].Width = 100;
                ApprovalLVW.Columns.Add("");
                ApprovalLVW.Columns[5].Width = 60;

                SqlCommand unAproval = new SqlCommand();
                unAproval.Connection = sqlcon;
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
                sqlcon.Open();
                unAproval.CommandText = "select * from t_doctor where identification = 0";
                SqlDataReader unreader = unAproval.ExecuteReader();
                if (unreader.Read())
                {
                    while (unreader.Read())
                    {
                        ListViewItem it = new ListViewItem(unreader["dno"].ToString());
                        it.SubItems.Add(unreader["name"].ToString());
                        it.SubItems.Add(unreader["sex"].ToString());
                        it.SubItems.Add(unreader["phone"].ToString());
                        it.SubItems.Add(unreader["identification"].ToString());
                        it.SubItems.Add("审批");

                        ApprovalLVW.Items.Add(it);
                    }
                }
                else
                {
                    ApprovalLB2.Visible = true;
                }
                unreader.Close();
                sqlcon.Close();
            }
        }

        private void Approval_Click(object sender, EventArgs e)
        {
            updateAprView();
        }

        private void GetAllUser_Click(object sender, EventArgs e)
        {
            updateUserView();
        }

        private void GetAllPhd_Click(object sender, EventArgs e)
        {
            updateDocView();
        }
    }
}
