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
    public partial class Diagnose : Form
    {
        public static int No;
        //定义数据库连接
        SqlConnection sqlCon = new SqlConnection();
        SqlCommand sqlCmd = new SqlCommand();

        Doctor doc = new Doctor();

        public Diagnose()
        {
            InitializeComponent();
        }

        public Diagnose(Doctor doctor)
        {
            InitializeComponent();
            this.doc = doctor;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void diagnose_Load(object sender, EventArgs e)
        {
            txtpno.Text = DoctorForm.pno;
            txtpname.Text = DoctorForm.pname;

            //连接数据库
            sqlCon.ConnectionString = "server=DESKTOP-Q01BBV8;user id=sa;password=333;database=Diabetes";
            if (sqlCon.State == ConnectionState.Open) sqlCon.Close();
            sqlCon.Open();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            if (txttype.Text == "")
            {
                MessageBox.Show("没有填写糖尿病类型，请填写");
                return;
            }

            if (txtmedicine.Text == "")
            {
                MessageBox.Show("没有填写药方，请填写");
                return;
            }

            if (txtdes.Text == "")
            {
                MessageBox.Show("没有填写备注，请填写");
                return;
            }

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "insert into t_diagnosis values('" + txtpno.Text + "','" + doc.Dno + "','" + txttype.Text + "',getdate(),'" + txtdes.Text + "')";
            sqlCmd.ExecuteNonQuery();

            //获得新诊断书编号
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "select top 1 digno from t_diagnosis where pno = '" + DoctorForm.pno + "' and dno = '" + doc.Dno + "' order by time desc";
            No = Convert.ToInt32(sqlCmd.ExecuteScalar());

            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandText = "insert into t_prescription values('" + No + "','" + txtmedicine.Text + "')";
            sqlCmd.ExecuteNonQuery();

            txttype.Text = "";
            txtmedicine.Text = "";
            txtdes.Text = "";
        }
    }
}
