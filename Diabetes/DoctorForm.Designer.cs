
namespace Diabetes
{
    partial class DoctorForm
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
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.shouye = new System.Windows.Forms.TabPage();
            this.show_num = new Sunny.UI.UILabel();
            this.show_time = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.show_name = new Sunny.UI.UILabel();
            this.select = new System.Windows.Forms.TabPage();
            this.uibtw = new Sunny.UI.UIButton();
            this.lstgly = new System.Windows.Forms.ListView();
            this.chpno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chpname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chvalues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chtime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtpno = new Sunny.UI.UITextBox();
            this.fix = new System.Windows.Forms.TabPage();
            this.woman = new Sunny.UI.UIRadioButton();
            this.man = new Sunny.UI.UIRadioButton();
            this.modificate = new Sunny.UI.UIButton();
            this.txtphone = new Sunny.UI.UITextBox();
            this.phone = new Sunny.UI.UILabel();
            this.txtage = new Sunny.UI.UITextBox();
            this.sex = new Sunny.UI.UILabel();
            this.age = new Sunny.UI.UILabel();
            this.txtname = new Sunny.UI.UITextBox();
            this.dname = new Sunny.UI.UILabel();
            this.m_password = new System.Windows.Forms.TabPage();
            this.update = new Sunny.UI.UIButton();
            this.newpwd2 = new Sunny.UI.UITextBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.newpwd = new Sunny.UI.UITextBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.oldpwd = new Sunny.UI.UITextBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.uiTabControlMenu1.SuspendLayout();
            this.shouye.SuspendLayout();
            this.select.SuspendLayout();
            this.fix.SuspendLayout();
            this.m_password.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.shouye);
            this.uiTabControlMenu1.Controls.Add(this.select);
            this.uiTabControlMenu1.Controls.Add(this.fix);
            this.uiTabControlMenu1.Controls.Add(this.m_password);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(-4, 0);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(1000, 669);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.uiTabControlMenu1.TabIndex = 4;
            this.uiTabControlMenu1.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabSelectedHighColor = System.Drawing.Color.White;
            this.uiTabControlMenu1.TabUnSelectedForeColor = System.Drawing.Color.White;
            // 
            // shouye
            // 
            this.shouye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.shouye.Controls.Add(this.show_num);
            this.shouye.Controls.Add(this.show_time);
            this.shouye.Controls.Add(this.uiLabel2);
            this.shouye.Controls.Add(this.show_name);
            this.shouye.Location = new System.Drawing.Point(201, 0);
            this.shouye.Name = "shouye";
            this.shouye.Size = new System.Drawing.Size(799, 669);
            this.shouye.TabIndex = 2;
            this.shouye.Text = "首页";
            // 
            // show_num
            // 
            this.show_num.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.show_num.Location = new System.Drawing.Point(111, 187);
            this.show_num.Name = "show_num";
            this.show_num.Size = new System.Drawing.Size(379, 46);
            this.show_num.TabIndex = 3;
            this.show_num.Text = "show_num";
            this.show_num.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // show_time
            // 
            this.show_time.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.show_time.Location = new System.Drawing.Point(111, 118);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(379, 46);
            this.show_time.TabIndex = 2;
            this.show_time.Text = "show_time";
            this.show_time.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(111, 262);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(510, 46);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "请查看您的患者信息并上传诊断书，谢谢！";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // show_name
            // 
            this.show_name.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.show_name.Location = new System.Drawing.Point(111, 36);
            this.show_name.Name = "show_name";
            this.show_name.Size = new System.Drawing.Size(379, 46);
            this.show_name.TabIndex = 0;
            this.show_name.Text = "show_name";
            this.show_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.select.Controls.Add(this.uibtw);
            this.select.Controls.Add(this.lstgly);
            this.select.Controls.Add(this.uiButton1);
            this.select.Controls.Add(this.uiLabel1);
            this.select.Controls.Add(this.txtpno);
            this.select.Location = new System.Drawing.Point(201, 0);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(799, 669);
            this.select.TabIndex = 0;
            this.select.Text = "查看数据";
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // uibtw
            // 
            this.uibtw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uibtw.Location = new System.Drawing.Point(147, 499);
            this.uibtw.MinimumSize = new System.Drawing.Size(1, 1);
            this.uibtw.Name = "uibtw";
            this.uibtw.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.RectDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uibtw.Size = new System.Drawing.Size(127, 35);
            this.uibtw.Style = Sunny.UI.UIStyle.Custom;
            this.uibtw.TabIndex = 4;
            this.uibtw.Text = "诊断";
            this.uibtw.Click += new System.EventHandler(this.uibtw_Click);
            // 
            // lstgly
            // 
            this.lstgly.BackColor = System.Drawing.Color.White;
            this.lstgly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chpno,
            this.chpname,
            this.chvalues,
            this.chtime});
            this.lstgly.FullRowSelect = true;
            this.lstgly.GridLines = true;
            this.lstgly.HideSelection = false;
            this.lstgly.Location = new System.Drawing.Point(1, 127);
            this.lstgly.Name = "lstgly";
            this.lstgly.Size = new System.Drawing.Size(795, 352);
            this.lstgly.TabIndex = 3;
            this.lstgly.UseCompatibleStateImageBehavior = false;
            this.lstgly.View = System.Windows.Forms.View.Details;
            this.lstgly.Click += new System.EventHandler(this.lstgly_Click);
            // 
            // chpno
            // 
            this.chpno.Text = "患者编号";
            this.chpno.Width = 100;
            // 
            // chpname
            // 
            this.chpname.Text = "患者姓名";
            this.chpname.Width = 100;
            // 
            // chvalues
            // 
            this.chvalues.Text = "患者血糖值";
            this.chvalues.Width = 100;
            // 
            // chtime
            // 
            this.chtime.Text = "上传时间";
            this.chtime.Width = 200;
            // 
            // uiButton1
            // 
            this.uiButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton1.Location = new System.Drawing.Point(219, 56);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(55, 35);
            this.uiButton1.Style = Sunny.UI.UIStyle.Custom;
            this.uiButton1.TabIndex = 2;
            this.uiButton1.Text = "搜索";
            this.uiButton1.TipsColor = System.Drawing.Color.PaleVioletRed;
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(21, 17);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(191, 36);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "请输入病历号搜索";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpno
            // 
            this.txtpno.FillColor = System.Drawing.Color.White;
            this.txtpno.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtpno.Location = new System.Drawing.Point(62, 58);
            this.txtpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpno.Maximum = 2147483647D;
            this.txtpno.Minimum = -2147483648D;
            this.txtpno.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpno.Name = "txtpno";
            this.txtpno.Padding = new System.Windows.Forms.Padding(5);
            this.txtpno.Size = new System.Drawing.Size(150, 34);
            this.txtpno.TabIndex = 0;
            this.txtpno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fix
            // 
            this.fix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.fix.Controls.Add(this.woman);
            this.fix.Controls.Add(this.man);
            this.fix.Controls.Add(this.modificate);
            this.fix.Controls.Add(this.txtphone);
            this.fix.Controls.Add(this.phone);
            this.fix.Controls.Add(this.txtage);
            this.fix.Controls.Add(this.sex);
            this.fix.Controls.Add(this.age);
            this.fix.Controls.Add(this.txtname);
            this.fix.Controls.Add(this.dname);
            this.fix.Location = new System.Drawing.Point(201, 0);
            this.fix.Name = "fix";
            this.fix.Size = new System.Drawing.Size(799, 669);
            this.fix.TabIndex = 1;
            this.fix.Text = "修改信息";
            // 
            // woman
            // 
            this.woman.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.woman.Location = new System.Drawing.Point(368, 179);
            this.woman.MinimumSize = new System.Drawing.Size(1, 1);
            this.woman.Name = "woman";
            this.woman.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.woman.Size = new System.Drawing.Size(126, 29);
            this.woman.TabIndex = 23;
            this.woman.Text = "女";
            // 
            // man
            // 
            this.man.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.man.Location = new System.Drawing.Point(212, 179);
            this.man.MinimumSize = new System.Drawing.Size(1, 1);
            this.man.Name = "man";
            this.man.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.man.Size = new System.Drawing.Size(117, 29);
            this.man.TabIndex = 22;
            this.man.Text = "男";
            // 
            // modificate
            // 
            this.modificate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.modificate.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.modificate.Location = new System.Drawing.Point(261, 419);
            this.modificate.MinimumSize = new System.Drawing.Size(1, 1);
            this.modificate.Name = "modificate";
            this.modificate.Size = new System.Drawing.Size(157, 56);
            this.modificate.Style = Sunny.UI.UIStyle.Custom;
            this.modificate.TabIndex = 21;
            this.modificate.Text = "修改";
            this.modificate.Click += new System.EventHandler(this.modificate_Click);
            // 
            // txtphone
            // 
            this.txtphone.FillColor = System.Drawing.Color.White;
            this.txtphone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtphone.Location = new System.Drawing.Point(213, 245);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtphone.Maximum = 2147483647D;
            this.txtphone.Minimum = -2147483648D;
            this.txtphone.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtphone.Name = "txtphone";
            this.txtphone.Padding = new System.Windows.Forms.Padding(5);
            this.txtphone.Size = new System.Drawing.Size(281, 34);
            this.txtphone.TabIndex = 16;
            this.txtphone.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone
            // 
            this.phone.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.phone.Location = new System.Drawing.Point(83, 253);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(123, 26);
            this.phone.TabIndex = 15;
            this.phone.Text = "电话";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtage
            // 
            this.txtage.FillColor = System.Drawing.Color.White;
            this.txtage.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtage.Location = new System.Drawing.Point(213, 101);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtage.Maximum = 2147483647D;
            this.txtage.Minimum = -2147483648D;
            this.txtage.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtage.Name = "txtage";
            this.txtage.Padding = new System.Windows.Forms.Padding(5);
            this.txtage.Size = new System.Drawing.Size(281, 34);
            this.txtage.TabIndex = 13;
            this.txtage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sex
            // 
            this.sex.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sex.Location = new System.Drawing.Point(83, 182);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(123, 26);
            this.sex.TabIndex = 14;
            this.sex.Text = "性别";
            this.sex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // age
            // 
            this.age.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.age.Location = new System.Drawing.Point(83, 109);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(123, 26);
            this.age.TabIndex = 12;
            this.age.Text = "年龄";
            this.age.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtname
            // 
            this.txtname.FillColor = System.Drawing.Color.White;
            this.txtname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtname.Location = new System.Drawing.Point(213, 19);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Maximum = 2147483647D;
            this.txtname.Minimum = -2147483648D;
            this.txtname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtname.Name = "txtname";
            this.txtname.Padding = new System.Windows.Forms.Padding(5);
            this.txtname.Size = new System.Drawing.Size(281, 34);
            this.txtname.TabIndex = 11;
            this.txtname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dname
            // 
            this.dname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dname.Location = new System.Drawing.Point(83, 27);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(123, 26);
            this.dname.TabIndex = 10;
            this.dname.Text = "姓名";
            this.dname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_password
            // 
            this.m_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.m_password.Controls.Add(this.update);
            this.m_password.Controls.Add(this.newpwd2);
            this.m_password.Controls.Add(this.uiLabel7);
            this.m_password.Controls.Add(this.newpwd);
            this.m_password.Controls.Add(this.uiLabel6);
            this.m_password.Controls.Add(this.oldpwd);
            this.m_password.Controls.Add(this.uiLabel5);
            this.m_password.Location = new System.Drawing.Point(201, 0);
            this.m_password.Name = "m_password";
            this.m_password.Size = new System.Drawing.Size(799, 669);
            this.m_password.TabIndex = 3;
            this.m_password.Text = "修改密码";
            // 
            // update
            // 
            this.update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.update.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.update.Location = new System.Drawing.Point(265, 343);
            this.update.MinimumSize = new System.Drawing.Size(1, 1);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(146, 53);
            this.update.Style = Sunny.UI.UIStyle.Custom;
            this.update.TabIndex = 25;
            this.update.Text = "修改密码";
            this.update.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // newpwd2
            // 
            this.newpwd2.FillColor = System.Drawing.Color.White;
            this.newpwd2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.newpwd2.Location = new System.Drawing.Point(265, 221);
            this.newpwd2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newpwd2.Maximum = 2147483647D;
            this.newpwd2.Minimum = -2147483648D;
            this.newpwd2.MinimumSize = new System.Drawing.Size(1, 1);
            this.newpwd2.Name = "newpwd2";
            this.newpwd2.Padding = new System.Windows.Forms.Padding(5);
            this.newpwd2.Size = new System.Drawing.Size(281, 34);
            this.newpwd2.TabIndex = 24;
            this.newpwd2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel7.Location = new System.Drawing.Point(70, 229);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(188, 26);
            this.uiLabel7.TabIndex = 23;
            this.uiLabel7.Text = "再一次输入新密码";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newpwd
            // 
            this.newpwd.FillColor = System.Drawing.Color.White;
            this.newpwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.newpwd.Location = new System.Drawing.Point(265, 135);
            this.newpwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newpwd.Maximum = 2147483647D;
            this.newpwd.Minimum = -2147483648D;
            this.newpwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.newpwd.Name = "newpwd";
            this.newpwd.Padding = new System.Windows.Forms.Padding(5);
            this.newpwd.Size = new System.Drawing.Size(281, 34);
            this.newpwd.TabIndex = 22;
            this.newpwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel6.Location = new System.Drawing.Point(135, 143);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(123, 26);
            this.uiLabel6.TabIndex = 21;
            this.uiLabel6.Text = "新密码";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oldpwd
            // 
            this.oldpwd.FillColor = System.Drawing.Color.White;
            this.oldpwd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.oldpwd.Location = new System.Drawing.Point(265, 55);
            this.oldpwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oldpwd.Maximum = 2147483647D;
            this.oldpwd.Minimum = -2147483648D;
            this.oldpwd.MinimumSize = new System.Drawing.Size(1, 1);
            this.oldpwd.Name = "oldpwd";
            this.oldpwd.Padding = new System.Windows.Forms.Padding(5);
            this.oldpwd.Size = new System.Drawing.Size(281, 34);
            this.oldpwd.TabIndex = 20;
            this.oldpwd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel5.Location = new System.Drawing.Point(135, 63);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(123, 26);
            this.uiLabel5.TabIndex = 19;
            this.uiLabel5.Text = "原密码";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "DoctorForm";
            this.Text = "医生界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.shouye.ResumeLayout(false);
            this.select.ResumeLayout(false);
            this.fix.ResumeLayout(false);
            this.m_password.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage shouye;
        private Sunny.UI.UILabel show_num;
        private Sunny.UI.UILabel show_time;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel show_name;
        private System.Windows.Forms.TabPage select;
        private Sunny.UI.UIButton uibtw;
        private System.Windows.Forms.ListView lstgly;
        private System.Windows.Forms.ColumnHeader chpno;
        private System.Windows.Forms.ColumnHeader chpname;
        private System.Windows.Forms.ColumnHeader chvalues;
        private System.Windows.Forms.ColumnHeader chtime;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtpno;
        private System.Windows.Forms.TabPage fix;
        private Sunny.UI.UIRadioButton woman;
        private Sunny.UI.UIRadioButton man;
        private Sunny.UI.UIButton modificate;
        private Sunny.UI.UITextBox txtphone;
        private Sunny.UI.UILabel phone;
        private Sunny.UI.UITextBox txtage;
        private Sunny.UI.UILabel sex;
        private Sunny.UI.UILabel age;
        private Sunny.UI.UITextBox txtname;
        private Sunny.UI.UILabel dname;
        private System.Windows.Forms.TabPage m_password;
        private Sunny.UI.UIButton update;
        private Sunny.UI.UITextBox newpwd2;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UITextBox newpwd;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UITextBox oldpwd;
        private Sunny.UI.UILabel uiLabel5;
        private System.Windows.Forms.Timer timer;
    }
}