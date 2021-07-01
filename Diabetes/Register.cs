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
    public partial class Register : Form
    {
        private String id = "patient";// patient注册为病人，doctor注册为医生
        public Register()
        {
            InitializeComponent();
        }

        private void docBtn_Click(object sender, EventArgs e)
        {
            // 选择注册医生，糖尿病等级选择项消失，修改id，清空输入框
            id = "doctor";
            glyLevelLbl.Visible = false;
            typeTxt.Visible = false;
            nameTxt.Text = "";
            boyRBtn.Checked = false;
            girlRBTn.Checked = false;
            ageTxt.Text = "";
            phoneTxt.Text = "";
            passTxt.Text = "";
        }

        private void patBtn_Click(object sender, EventArgs e)
        {
            // 选择注册病人，糖尿病等级选择项出现，修改id，清空输入框
            id = "patient";
            glyLevelLbl.Visible = true;
            typeTxt.Visible = true;
            nameTxt.Text = "";
            boyRBtn.Checked = false;
            girlRBTn.Checked = false;
            ageTxt.Text = "";
            phoneTxt.Text = "";
            passTxt.Text = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 判断信息是否都填写且没有报错信息，按钮才可用
            if(nameTxt.Text != "" && (boyRBtn.Checked || girlRBTn.Checked) && ageTxt.Text != "" && phoneTxt.Text != "" && passTxt.Text != "" &&
                !nameIllegalTIpsLbl.Visible && ! illegalAgeLbl.Visible && !phoneIllegalTipsLbl.Visible)
            {
                registerBtn.Enabled = true;
            }
            else
            {
                registerBtn.Enabled = false;
            }
            
        }

        private void nameTxt_Leave(object sender, EventArgs e)
        {
            // 姓名是否合法
            String name = nameTxt.Text;
            Boolean isLegal = true;
            foreach (char c in name)
            {
                if (Char.IsNumber(c))
                {
                    isLegal = false;
                }
            }
            if (!isLegal)
            {
                nameIllegalTIpsLbl.Visible = true;
                registerBtn.Enabled = false;
            }
            else
            {
                nameIllegalTIpsLbl.Visible = false;
            }
        }

        private void ageTxt_Leave(object sender, EventArgs e)
        {
            // 年龄是否合法
            try
            {
                int age = Convert.ToInt32(ageTxt.Text);
                illegalAgeLbl.Visible = false;
            }
            catch
            {
                illegalAgeLbl.Visible = true;
            }
        }
        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            // 手机号是否合法
            String phone = phoneTxt.Text;
            if (phone.Length != 11 || phone == "")
            {
                phoneIllegalTipsLbl.Visible = true;
                return;
            }
            else
            {
                phoneIllegalTipsLbl.Visible = false;
            }
            String sql = "";
            // 手机号是否已被注册
            if (id == "doctor")
            {
                sql = "select phone from t_doctor where phone = @phone";
            }
            else
            {
                sql = "select phone from t_patient where phone = @phone";
            }
            SqlParameter phoneParam = new SqlParameter("@phone", phone);
            SqlDataReader reader = DButil.query(sql, phoneParam);
            if (reader.Read())
            {
                phoneIllegalTipsLbl.Visible = true;
            }
            else
            {
                phoneIllegalTipsLbl.Visible = false;
            }
            DButil.close();
        }
        private void registerBtn_Click(object sender, EventArgs e)
        {
            String sql = "";
            int i;
            SqlParameter name = new SqlParameter("@name", nameTxt.Text);
            SqlParameter age = new SqlParameter("@age", ageTxt.Text);
            SqlParameter sex = new SqlParameter("@sex", (boyRBtn.Checked)? "male" : "female");
            SqlParameter phone = new SqlParameter("@phone", phoneTxt.Text);
            SqlParameter password = new SqlParameter("@password", passTxt.Text);
            SqlParameter type = new SqlParameter("@type", typeTxt.Text);
            // 注册医生
            if (id == "doctor")
            {
                sql = "insert into t_doctor(name, age, sex, phone, password, identification, patientsNum) values(@name, @age, @sex, @phone, @password, 0, 0)";
                i = DButil.update(sql, name, age, sex, phone, password);
                DButil.close();
                if(i != 0)
                {
                    MessageBox.Show("注册成功！");
                }
                else
                {
                    MessageBox.Show("注册失败，请联系管理员！");
                }
                return;
            }
            // 找到病人的主治医生
            sql = "select top 1 dno from t_doctor where identification=1 order by patientsNum asc";
            SqlDataReader reader = DButil.query(sql);
            SqlParameter dno;
            if (reader.Read())
            {
                dno = new SqlParameter("@dno", Convert.ToInt32(reader["dno"].ToString()));
            }else
            {
                MessageBox.Show("寻找主治医生错误，请联系管理员！");
                return;
            }
            // 注册病人
            sql = "insert into t_patient(name, age, sex, phone, password, attendingDoctor, type) values(@name, @age, @sex, @phone, @password, @dno, @type)";
            i = DButil.update(sql, name, age, sex, phone, password, dno, type);
            DButil.close();
            if (i != 0)
            {
                MessageBox.Show("注册成功！");
                sql = "select patientsNum from t_doctor where dno = @dno";
                SqlDataReader reader0 = DButil.query(sql, dno);
                reader0.Read();
                int patientsNum = Convert.ToInt32(reader0["patientsNum"].ToString());
                DButil.close();
                patientsNum++;
                sql = "update t_doctor set patientsNum = @num where dno = @dno";
                SqlParameter num = new SqlParameter("@num", patientsNum);
                DButil.update(sql, num, dno);
            }
            else
            {
                MessageBox.Show("注册失败，请联系管理员！");
            }
        }
    }
}
