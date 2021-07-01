using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using System.Data.SqlClient;

namespace Diabetes
{
    public partial class patientForm : Form
    {
        public Patient patient = new Patient();// 当前登录的用户对象
        public Patient ePatient = new Patient();// 要修改的对象
        public patientForm()
        {
            InitializeComponent();
            
        }
        public patientForm(Patient patient)
        {
            this.patient = patient;
            this.ePatient = patient;
            InitializeComponent();
            // 获取用户名
            infoTips.Text = patient.Name + "，你好！";
            // 获取主治医生的姓名和联系电话
            String sql = "select * from t_doctor where dno = @dno";
            SqlParameter attendingDoctor = new SqlParameter("@dno", patient.AttendingDoctor);
            Doctor doc = Doctor.ToBean(DButil.query(sql, attendingDoctor));
            docTelTips.Text = "主治医生联系电话：" + doc.Phone;
            doctorTips.Text = "你的主治医生为：" + doc.Name;
            DButil.close();
            // 获取过去五天的血糖值
            updateGly();
            // 将用户信息填写到对应的文本上
            nameTxt.Text = patient.Name;
            if (patient.Sex == "male") boyRBtn.Checked = true;
            else girlRBTn.Checked = true;
            ageTxt.Text = patient.Age + "";
            phoneTxt.Text = patient.Phone;
            typeTxt.Text = patient.Type;
            // 获取最新的诊断书
            sql = "select top 1 * from t_diagnosis where pno = @pno order by time desc";
            SqlParameter pno = new SqlParameter("@pno", patient.Pno);
            Diagnosis dig = Diagnosis.ToBean(DButil.query(sql, pno));
            txtpno.Text = dig.Digno + "";
            txttype.Text = dig.Type;
            txtpname.Text = patient.Name;
            txtdes.Text = dig.Description;
            DButil.close();
            // 药方
            sql = "select * from t_prescription where digno = @digno";
            SqlParameter digno = new SqlParameter("@digno", dig.Digno);
            Prescription pre = Prescription.ToBean(DButil.query(sql, digno));
            txtmedicine.Text = (pre == null) ? "" : pre.Medicine;
            DButil.close();
        }

        private void updateGly()
        {
            String sql = "select top 5 * from t_glycemicIndex where pno = @pno order by time desc";
            SqlParameter pno = new SqlParameter("@pno", patient.Pno);
            List<GlycemicIndex> list = GlycemicIndex.ToBeanList(DButil.query(sql, pno));
            int len = list.ToArray().Length - 1 ;
            if (len >= 0) MonLbl.Text = list[0].Time.ToString("yyyy-MM-dd hh:mm:ss") + " : " + list[0].Value + " mmol/L";
            else MonLbl.Text = "空";
            if (len >= 1) Tue.Text = list[1].Time.ToString("yyyy-MM-dd hh:mm:ss") + " : " + list[1].Value + " mmol/L";
            else Tue.Text = "空";
            if (len >= 2) Wed.Text = list[2].Time.ToString("yyyy-MM-dd hh:mm:ss") + " : " + list[2].Value + " mmol/L";
            else Wed.Text = "空";
            if (len >= 3) Thu.Text = list[3].Time.ToString("yyyy-MM-dd hh:mm:ss") + " : " + list[3].Value + " mmol/L";
            else Thu.Text = "空";
            if (len >= 4) Fri.Text = list[4].Time.ToString("yyyy-MM-dd hh:mm:ss") + " : " + list[4].Value + " mmol/L";
            else Fri.Text = "空";
        }

        private void glycemicBtn_Click(object sender, EventArgs e)
        {
            // 提交血糖值，保存到数据库
            DateTime dateTime = DateTime.Now;
            String sql = "select top 1 * from t_glycemicIndex where pno = @pno order by time desc";
            SqlParameter pno = new SqlParameter("@pno", patient.Pno);
            GlycemicIndex gly = GlycemicIndex.ToBean(DButil.query(sql, pno));
            DateTime glyTime = (gly == null) ? Convert.ToDateTime("1919-12-12 12:12:12") : gly.Time;
            if(glyTime.Year == dateTime.Year && glyTime.Month == glyTime.Month && glyTime.Day == dateTime.Day)
            {
                MessageBox.Show("今天已提交，不能再提交了！");
                return;
            }
            // 如果今天没有提交
            DialogResult result = MessageBox.Show("一天只能提交一次，确定要提交了吗？", "Tips", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.ToString() == "No")
            {
                return;
            }
            try
            {
                Decimal gValue = Convert.ToDecimal(glycemicTxt.Text);
                sql = "insert into t_glycemicIndex values(@pno, @value, @time)";
                SqlParameter value = new SqlParameter("@value", gValue);
                SqlParameter time = new SqlParameter("@time", dateTime.ToString("yyyy-MM-dd hh:mm:ss"));
                int i = DButil.update(sql, pno, value, time);
                if(i == 0)
                {
                    MessageBox.Show("提交失败，请联系管理员！");
                    return;
                }
                MessageBox.Show("提交成功！");
            }
            catch
            {
                MessageBox.Show("血糖值不合法，请重新输入");
                glycemicTxt.Text = "";
            }
            DButil.close();

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // 修改个人信息
            // 修改
            SqlConnection conn = DButil.getSqlConnection();
            String sql = "";
            SqlParameter pno = new SqlParameter("@pno", patient.Pno);
            // 改姓名，性别，年龄，手机，糖尿病等级，密码
            sql = "update t_patient set name = @name where pno = @pno";
            SqlParameter name = new SqlParameter("@name", ePatient.Name);
            DButil.update(conn, sql, name, pno);

            sql = "update t_patient set age = @age where pno = @pno";
            SqlParameter age = new SqlParameter("@age", ePatient.Age);
            DButil.update(conn, sql, age, pno);

            sql = "update t_patient set sex = @sex where pno = @pno";
            SqlParameter sex = new SqlParameter("@sex", ePatient.Sex);
            DButil.update(conn, sql, sex, pno);

            sql = "update t_patient set phone = @phone where pno = @pno";
            SqlParameter phone = new SqlParameter("@phone", ePatient.Phone);
            DButil.update(conn, sql, phone, pno);

            sql = "update t_patient set type = @type where pno = @pno";
            SqlParameter type = new SqlParameter("@type", ePatient.Type);
            DButil.update(conn, sql, type, pno);

            sql = "update t_patient set password = @password where pno = @pno";
            SqlParameter pwd = new SqlParameter("@password", ePatient.Password);
            DButil.update(conn, sql, pwd, pno);
            
            DButil.close();

            MessageBox.Show("修改成功！");
            sql = "select * from t_patient where pno = @pno";
            patient = Patient.ToBean(DButil.query(sql, pno));
            DButil.close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // 刷新填写血糖界面的时间
            timeTips.Text = "当前时间为：" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            // 没有报红，按钮可用，并且两个“用户”不相等
            if (!patient.Equals(ePatient) && !nameIllegalTIpsLbl.Visible && !phoneIllegalTipsLbl.Visible && !illegalAgeLbl.Visible && !wrongOriginPassTips.Visible &&
                !wrongPassTipsLbl.Visible)
            {
                confirmBtn.Enabled = true;
            }
            else
            {
                confirmBtn.Enabled = false;
            }
        }
        private void glycemicTxt_Click(object sender, EventArgs e)
        {
            // 清空血糖值的输入框
            glycemicTxt.Text = "";
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            updateGly();
        }
        // 与修改界面有关的方法
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
            }
            else
            {
                nameIllegalTIpsLbl.Visible = false;
                updatePatient();
            }
        }
        private void phoneTxt_Leave(object sender, EventArgs e)
        {
            // 手机号是否合法
            String phone = phoneTxt.Text;
            if (phone.Length != 11 || phone == "")
            {
                phoneIllegalTipsLbl.Visible = true;
                updatePatient();
            }
            else
            {
                phoneIllegalTipsLbl.Visible = false;
            }
        }

        private void ageTxt_Leave(object sender, EventArgs e)
        {
            // 年龄是否合法
            try
            {
                int age = Convert.ToInt32(ageTxt.Text);
                illegalAgeLbl.Visible = false;
                updatePatient();
            }
            catch
            {
                illegalAgeLbl.Visible = true;
            }
        }
        private void originPassTxt_Leave(object sender, EventArgs e)
        {
            // 判断原始密码是否符合
            String pass = originPassTxt.Text;
            if (pass != "" && pass != patient.Password)
            {
                wrongOriginPassTips.Visible = true;
            }
            else
            {
                wrongOriginPassTips.Visible = false;
                updatePatient();
            }
        }
        private void confirmPassTxt_Leave(object sender, EventArgs e)
        {
            // 密码是否一致
            String pass = passTxt.Text;
            String pass0 = confirmPassTxt.Text;
            if (pass != "" && pass0 != "" && !(pass == pass0))
            {
                wrongPassTipsLbl.Visible = true;
            }
            else
            {
                wrongPassTipsLbl.Visible = false;
                updatePatient();
            }
        }
        private void passTxt_Leave(object sender, EventArgs e)
        {
            // 密码是否一致
            String pass = passTxt.Text;
            String pass0 = confirmPassTxt.Text;
            if (!(pass == pass0))
            {
                wrongPassTipsLbl.Visible = true;
            }
            else
            {
                wrongPassTipsLbl.Visible = false;
                updatePatient();
            }
        }
        private void boyRBtn_Click(object sender, EventArgs e)
        {
            updatePatient();
        }

        private void girlRBTn_Click(object sender, EventArgs e)
        {
            updatePatient();
        }
        private void updatePatient()
        {
            // 更新用户修改数据
            String sex0 = (boyRBtn.Checked) ? "male" : "female";
            String password0 = patient.Password;
            if (confirmPassTxt.Text != "" && originPassTxt.Text != "")
            {
                password0 = confirmPassTxt.Text;
            }
            ePatient = new Patient(patient.Pno, nameTxt.Text, Convert.ToInt32(ageTxt.Text), sex0, phoneTxt.Text, password0, patient.AttendingDoctor, typeTxt.Text);
        }
    }
}
