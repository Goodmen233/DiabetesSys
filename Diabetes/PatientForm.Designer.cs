
namespace Diabetes
{
    partial class patientForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new Sunny.UI.UITabControlMenu();
            this.index = new System.Windows.Forms.TabPage();
            this.refresh = new Sunny.UI.UIButton();
            this.uiLine1 = new Sunny.UI.UILine();
            this.Fri = new Sunny.UI.UILabel();
            this.Thu = new Sunny.UI.UILabel();
            this.Wed = new Sunny.UI.UILabel();
            this.Tue = new Sunny.UI.UILabel();
            this.MonLbl = new Sunny.UI.UILabel();
            this.infoTips = new Sunny.UI.UILabel();
            this.docTelTips = new Sunny.UI.UILabel();
            this.doctorTips = new Sunny.UI.UILabel();
            this.glycemicTips = new Sunny.UI.UILabel();
            this.uploodData = new System.Windows.Forms.TabPage();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.glycemicBtn = new Sunny.UI.UIButton();
            this.glycemicLbl = new Sunny.UI.UILabel();
            this.glycemicTxt = new Sunny.UI.UITextBox();
            this.timeTips = new Sunny.UI.UILabel();
            this.viewDiagnosis = new System.Windows.Forms.TabPage();
            this.EditInfo = new System.Windows.Forms.TabPage();
            this.typeTxt = new System.Windows.Forms.ComboBox();
            this.illegalAgeLbl = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.wrongOriginPassTips = new System.Windows.Forms.Label();
            this.wrongPassTipsLbl = new System.Windows.Forms.Label();
            this.phoneIllegalTipsLbl = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.nameIllegalTIpsLbl = new System.Windows.Forms.Label();
            this.confirmPassTxt = new System.Windows.Forms.TextBox();
            this.originPassTxt = new System.Windows.Forms.TextBox();
            this.originPassLbl = new System.Windows.Forms.Label();
            this.confirmPassLbl = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.passLbl = new System.Windows.Forms.Label();
            this.glyLevelLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.girlRBTn = new System.Windows.Forms.RadioButton();
            this.boyRBtn = new System.Windows.Forms.RadioButton();
            this.sexLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtmedicine = new Sunny.UI.UITextBox();
            this.txtdes = new Sunny.UI.UITextBox();
            this.medicine = new Sunny.UI.UILabel();
            this.des = new Sunny.UI.UILabel();
            this.txttype = new Sunny.UI.UITextBox();
            this.type = new Sunny.UI.UILabel();
            this.txtpname = new Sunny.UI.UITextBox();
            this.pname = new Sunny.UI.UILabel();
            this.txtpno = new Sunny.UI.UITextBox();
            this.pno = new Sunny.UI.UILabel();
            this.uiTextBox2 = new Sunny.UI.UITextBox();
            this.MainMenu.SuspendLayout();
            this.index.SuspendLayout();
            this.uploodData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.viewDiagnosis.SuspendLayout();
            this.EditInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.MainMenu.Controls.Add(this.index);
            this.MainMenu.Controls.Add(this.uploodData);
            this.MainMenu.Controls.Add(this.viewDiagnosis);
            this.MainMenu.Controls.Add(this.EditInfo);
            this.MainMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.MainMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.MainMenu.ItemSize = new System.Drawing.Size(40, 200);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.MainMenu.Multiline = true;
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.SelectedIndex = 0;
            this.MainMenu.Size = new System.Drawing.Size(1009, 685);
            this.MainMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.MainMenu.Style = Sunny.UI.UIStyle.Custom;
            this.MainMenu.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.MainMenu.TabIndex = 0;
            this.MainMenu.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.MainMenu.TabSelectedForeColor = System.Drawing.Color.White;
            this.MainMenu.TabSelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.MainMenu.TabUnSelectedForeColor = System.Drawing.Color.White;
            // 
            // index
            // 
            this.index.Controls.Add(this.refresh);
            this.index.Controls.Add(this.uiLine1);
            this.index.Controls.Add(this.Fri);
            this.index.Controls.Add(this.Thu);
            this.index.Controls.Add(this.Wed);
            this.index.Controls.Add(this.Tue);
            this.index.Controls.Add(this.MonLbl);
            this.index.Controls.Add(this.infoTips);
            this.index.Controls.Add(this.docTelTips);
            this.index.Controls.Add(this.doctorTips);
            this.index.Controls.Add(this.glycemicTips);
            this.index.Location = new System.Drawing.Point(201, 0);
            this.index.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(808, 685);
            this.index.TabIndex = 0;
            this.index.Text = "首页";
            this.index.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.refresh.Location = new System.Drawing.Point(695, 262);
            this.refresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(100, 35);
            this.refresh.TabIndex = 11;
            this.refresh.Text = "刷新";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // uiLine1
            // 
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.uiLine1.Location = new System.Drawing.Point(3, 216);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(792, 29);
            this.uiLine1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLine1.TabIndex = 10;
            // 
            // Fri
            // 
            this.Fri.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Fri.Location = new System.Drawing.Point(41, 572);
            this.Fri.Name = "Fri";
            this.Fri.Size = new System.Drawing.Size(743, 68);
            this.Fri.TabIndex = 9;
            this.Fri.Text = "Fri:";
            this.Fri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Thu
            // 
            this.Thu.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Thu.Location = new System.Drawing.Point(41, 504);
            this.Thu.Name = "Thu";
            this.Thu.Size = new System.Drawing.Size(743, 68);
            this.Thu.TabIndex = 8;
            this.Thu.Text = "Thu:";
            this.Thu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Wed
            // 
            this.Wed.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Wed.Location = new System.Drawing.Point(41, 436);
            this.Wed.Name = "Wed";
            this.Wed.Size = new System.Drawing.Size(743, 68);
            this.Wed.TabIndex = 7;
            this.Wed.Text = "Wed:";
            this.Wed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Tue
            // 
            this.Tue.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Tue.Location = new System.Drawing.Point(41, 368);
            this.Tue.Name = "Tue";
            this.Tue.Size = new System.Drawing.Size(743, 68);
            this.Tue.TabIndex = 6;
            this.Tue.Text = "Tue:";
            this.Tue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MonLbl
            // 
            this.MonLbl.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MonLbl.Location = new System.Drawing.Point(41, 300);
            this.MonLbl.Name = "MonLbl";
            this.MonLbl.Size = new System.Drawing.Size(743, 68);
            this.MonLbl.TabIndex = 5;
            this.MonLbl.Text = "Mon:";
            this.MonLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoTips
            // 
            this.infoTips.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoTips.Location = new System.Drawing.Point(26, 9);
            this.infoTips.Name = "infoTips";
            this.infoTips.Size = new System.Drawing.Size(585, 68);
            this.infoTips.TabIndex = 4;
            this.infoTips.Text = "张三，你好！";
            this.infoTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // docTelTips
            // 
            this.docTelTips.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.docTelTips.Location = new System.Drawing.Point(26, 145);
            this.docTelTips.Name = "docTelTips";
            this.docTelTips.Size = new System.Drawing.Size(585, 68);
            this.docTelTips.TabIndex = 3;
            this.docTelTips.Text = "主治医生联系电话：10086";
            this.docTelTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // doctorTips
            // 
            this.doctorTips.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.doctorTips.Location = new System.Drawing.Point(26, 77);
            this.doctorTips.Name = "doctorTips";
            this.doctorTips.Size = new System.Drawing.Size(585, 68);
            this.doctorTips.TabIndex = 2;
            this.doctorTips.Text = "你的主治医生为：张三";
            this.doctorTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // glycemicTips
            // 
            this.glycemicTips.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glycemicTips.Location = new System.Drawing.Point(26, 240);
            this.glycemicTips.Name = "glycemicTips";
            this.glycemicTips.Size = new System.Drawing.Size(585, 68);
            this.glycemicTips.TabIndex = 1;
            this.glycemicTips.Text = "你过去5天的血糖值为：";
            this.glycemicTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uploodData
            // 
            this.uploodData.Controls.Add(this.uiLabel2);
            this.uploodData.Controls.Add(this.pictureBox1);
            this.uploodData.Controls.Add(this.uiLabel1);
            this.uploodData.Controls.Add(this.glycemicBtn);
            this.uploodData.Controls.Add(this.glycemicLbl);
            this.uploodData.Controls.Add(this.glycemicTxt);
            this.uploodData.Controls.Add(this.timeTips);
            this.uploodData.Location = new System.Drawing.Point(201, 0);
            this.uploodData.Name = "uploodData";
            this.uploodData.Size = new System.Drawing.Size(808, 685);
            this.uploodData.TabIndex = 1;
            this.uploodData.Text = "上传数据";
            this.uploodData.UseVisualStyleBackColor = true;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.ForeColor = System.Drawing.Color.Black;
            this.uiLabel2.Location = new System.Drawing.Point(514, 152);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(120, 51);
            this.uiLabel2.TabIndex = 7;
            this.uiLabel2.Text = "mmol/L";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diabetes.Properties.Resources.糖尿病判定;
            this.pictureBox1.Location = new System.Drawing.Point(10, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 337);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 203);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(179, 70);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "温馨提示：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // glycemicBtn
            // 
            this.glycemicBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.glycemicBtn.Location = new System.Drawing.Point(597, 203);
            this.glycemicBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.glycemicBtn.Name = "glycemicBtn";
            this.glycemicBtn.Size = new System.Drawing.Size(148, 56);
            this.glycemicBtn.TabIndex = 3;
            this.glycemicBtn.Text = "提交今日血糖值";
            this.glycemicBtn.Click += new System.EventHandler(this.glycemicBtn_Click);
            // 
            // glycemicLbl
            // 
            this.glycemicLbl.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glycemicLbl.Location = new System.Drawing.Point(91, 152);
            this.glycemicLbl.Name = "glycemicLbl";
            this.glycemicLbl.Size = new System.Drawing.Size(120, 51);
            this.glycemicLbl.TabIndex = 2;
            this.glycemicLbl.Text = "血糖值：";
            this.glycemicLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // glycemicTxt
            // 
            this.glycemicTxt.FillColor = System.Drawing.Color.White;
            this.glycemicTxt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.glycemicTxt.Location = new System.Drawing.Point(218, 152);
            this.glycemicTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.glycemicTxt.Maximum = 2147483647D;
            this.glycemicTxt.Minimum = -2147483648D;
            this.glycemicTxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.glycemicTxt.Name = "glycemicTxt";
            this.glycemicTxt.Padding = new System.Windows.Forms.Padding(5);
            this.glycemicTxt.Size = new System.Drawing.Size(289, 51);
            this.glycemicTxt.TabIndex = 1;
            this.glycemicTxt.Text = "例：45.32";
            this.glycemicTxt.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.glycemicTxt.Click += new System.EventHandler(this.glycemicTxt_Click);
            // 
            // timeTips
            // 
            this.timeTips.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeTips.Location = new System.Drawing.Point(14, 67);
            this.timeTips.Name = "timeTips";
            this.timeTips.Size = new System.Drawing.Size(555, 70);
            this.timeTips.TabIndex = 0;
            this.timeTips.Text = "当前时间为：1919-12-12 12:12:12";
            this.timeTips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewDiagnosis
            // 
            this.viewDiagnosis.Controls.Add(this.txtmedicine);
            this.viewDiagnosis.Controls.Add(this.txtdes);
            this.viewDiagnosis.Controls.Add(this.medicine);
            this.viewDiagnosis.Controls.Add(this.des);
            this.viewDiagnosis.Controls.Add(this.txttype);
            this.viewDiagnosis.Controls.Add(this.type);
            this.viewDiagnosis.Controls.Add(this.txtpname);
            this.viewDiagnosis.Controls.Add(this.pname);
            this.viewDiagnosis.Controls.Add(this.txtpno);
            this.viewDiagnosis.Controls.Add(this.pno);
            this.viewDiagnosis.Location = new System.Drawing.Point(201, 0);
            this.viewDiagnosis.Name = "viewDiagnosis";
            this.viewDiagnosis.Size = new System.Drawing.Size(808, 685);
            this.viewDiagnosis.TabIndex = 2;
            this.viewDiagnosis.Text = "查看诊断书";
            this.viewDiagnosis.UseVisualStyleBackColor = true;
            // 
            // EditInfo
            // 
            this.EditInfo.Controls.Add(this.typeTxt);
            this.EditInfo.Controls.Add(this.illegalAgeLbl);
            this.EditInfo.Controls.Add(this.ageTxt);
            this.EditInfo.Controls.Add(this.ageLbl);
            this.EditInfo.Controls.Add(this.wrongOriginPassTips);
            this.EditInfo.Controls.Add(this.wrongPassTipsLbl);
            this.EditInfo.Controls.Add(this.phoneIllegalTipsLbl);
            this.EditInfo.Controls.Add(this.confirmBtn);
            this.EditInfo.Controls.Add(this.nameIllegalTIpsLbl);
            this.EditInfo.Controls.Add(this.confirmPassTxt);
            this.EditInfo.Controls.Add(this.originPassTxt);
            this.EditInfo.Controls.Add(this.originPassLbl);
            this.EditInfo.Controls.Add(this.confirmPassLbl);
            this.EditInfo.Controls.Add(this.passTxt);
            this.EditInfo.Controls.Add(this.passLbl);
            this.EditInfo.Controls.Add(this.glyLevelLbl);
            this.EditInfo.Controls.Add(this.phoneTxt);
            this.EditInfo.Controls.Add(this.nameLbl);
            this.EditInfo.Controls.Add(this.girlRBTn);
            this.EditInfo.Controls.Add(this.boyRBtn);
            this.EditInfo.Controls.Add(this.sexLbl);
            this.EditInfo.Controls.Add(this.phoneLbl);
            this.EditInfo.Controls.Add(this.nameTxt);
            this.EditInfo.Location = new System.Drawing.Point(201, 0);
            this.EditInfo.Name = "EditInfo";
            this.EditInfo.Size = new System.Drawing.Size(808, 685);
            this.EditInfo.TabIndex = 3;
            this.EditInfo.Text = "修改个人信息";
            this.EditInfo.UseVisualStyleBackColor = true;
            // 
            // typeTxt
            // 
            this.typeTxt.FormattingEnabled = true;
            this.typeTxt.Items.AddRange(new object[] {
            "一级",
            "二级",
            "三级"});
            this.typeTxt.Location = new System.Drawing.Point(283, 275);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(231, 29);
            this.typeTxt.TabIndex = 69;
            // 
            // illegalAgeLbl
            // 
            this.illegalAgeLbl.AutoSize = true;
            this.illegalAgeLbl.BackColor = System.Drawing.Color.Transparent;
            this.illegalAgeLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.illegalAgeLbl.ForeColor = System.Drawing.Color.Red;
            this.illegalAgeLbl.Location = new System.Drawing.Point(281, 173);
            this.illegalAgeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.illegalAgeLbl.Name = "illegalAgeLbl";
            this.illegalAgeLbl.Size = new System.Drawing.Size(256, 19);
            this.illegalAgeLbl.TabIndex = 68;
            this.illegalAgeLbl.Text = "年龄输入不合法，请重新输入";
            this.illegalAgeLbl.Visible = false;
            // 
            // ageTxt
            // 
            this.ageTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageTxt.Location = new System.Drawing.Point(283, 142);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(227, 29);
            this.ageTxt.TabIndex = 66;
            this.ageTxt.Leave += new System.EventHandler(this.ageTxt_Leave);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ageLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ageLbl.Location = new System.Drawing.Point(209, 141);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(69, 25);
            this.ageLbl.TabIndex = 65;
            this.ageLbl.Text = "年龄：";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wrongOriginPassTips
            // 
            this.wrongOriginPassTips.AutoSize = true;
            this.wrongOriginPassTips.BackColor = System.Drawing.Color.Transparent;
            this.wrongOriginPassTips.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongOriginPassTips.ForeColor = System.Drawing.Color.Red;
            this.wrongOriginPassTips.Location = new System.Drawing.Point(281, 354);
            this.wrongOriginPassTips.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongOriginPassTips.Name = "wrongOriginPassTips";
            this.wrongOriginPassTips.Size = new System.Drawing.Size(218, 19);
            this.wrongOriginPassTips.TabIndex = 64;
            this.wrongOriginPassTips.Text = "原密码错误，请重新输入";
            this.wrongOriginPassTips.Visible = false;
            // 
            // wrongPassTipsLbl
            // 
            this.wrongPassTipsLbl.AutoSize = true;
            this.wrongPassTipsLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongPassTipsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wrongPassTipsLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongPassTipsLbl.Location = new System.Drawing.Point(281, 450);
            this.wrongPassTipsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wrongPassTipsLbl.Name = "wrongPassTipsLbl";
            this.wrongPassTipsLbl.Size = new System.Drawing.Size(256, 19);
            this.wrongPassTipsLbl.TabIndex = 63;
            this.wrongPassTipsLbl.Text = "两次密码不一致，请重新输入";
            this.wrongPassTipsLbl.Visible = false;
            // 
            // phoneIllegalTipsLbl
            // 
            this.phoneIllegalTipsLbl.AutoSize = true;
            this.phoneIllegalTipsLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneIllegalTipsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneIllegalTipsLbl.ForeColor = System.Drawing.Color.Red;
            this.phoneIllegalTipsLbl.Location = new System.Drawing.Point(280, 247);
            this.phoneIllegalTipsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneIllegalTipsLbl.Name = "phoneIllegalTipsLbl";
            this.phoneIllegalTipsLbl.Size = new System.Drawing.Size(238, 19);
            this.phoneIllegalTipsLbl.TabIndex = 61;
            this.phoneIllegalTipsLbl.Text = "手机号为11位，请重新输入";
            this.phoneIllegalTipsLbl.Visible = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Enabled = false;
            this.confirmBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmBtn.Location = new System.Drawing.Point(414, 493);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(96, 51);
            this.confirmBtn.TabIndex = 60;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // nameIllegalTIpsLbl
            // 
            this.nameIllegalTIpsLbl.AutoSize = true;
            this.nameIllegalTIpsLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameIllegalTIpsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameIllegalTIpsLbl.ForeColor = System.Drawing.Color.Red;
            this.nameIllegalTIpsLbl.Location = new System.Drawing.Point(281, 71);
            this.nameIllegalTIpsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameIllegalTIpsLbl.Name = "nameIllegalTIpsLbl";
            this.nameIllegalTIpsLbl.Size = new System.Drawing.Size(218, 19);
            this.nameIllegalTIpsLbl.TabIndex = 46;
            this.nameIllegalTIpsLbl.Text = "姓名不合法，请重新输入";
            this.nameIllegalTIpsLbl.Visible = false;
            // 
            // confirmPassTxt
            // 
            this.confirmPassTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPassTxt.Location = new System.Drawing.Point(282, 419);
            this.confirmPassTxt.Margin = new System.Windows.Forms.Padding(2);
            this.confirmPassTxt.Name = "confirmPassTxt";
            this.confirmPassTxt.PasswordChar = '*';
            this.confirmPassTxt.Size = new System.Drawing.Size(230, 29);
            this.confirmPassTxt.TabIndex = 57;
            this.confirmPassTxt.Leave += new System.EventHandler(this.confirmPassTxt_Leave);
            // 
            // originPassTxt
            // 
            this.originPassTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.originPassTxt.Location = new System.Drawing.Point(282, 323);
            this.originPassTxt.Margin = new System.Windows.Forms.Padding(2);
            this.originPassTxt.Name = "originPassTxt";
            this.originPassTxt.PasswordChar = '*';
            this.originPassTxt.Size = new System.Drawing.Size(232, 29);
            this.originPassTxt.TabIndex = 56;
            this.originPassTxt.Leave += new System.EventHandler(this.originPassTxt_Leave);
            // 
            // originPassLbl
            // 
            this.originPassLbl.AutoSize = true;
            this.originPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.originPassLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.originPassLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.originPassLbl.Location = new System.Drawing.Point(189, 323);
            this.originPassLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.originPassLbl.Name = "originPassLbl";
            this.originPassLbl.Size = new System.Drawing.Size(88, 25);
            this.originPassLbl.TabIndex = 55;
            this.originPassLbl.Text = "原密码：";
            this.originPassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmPassLbl
            // 
            this.confirmPassLbl.AutoSize = true;
            this.confirmPassLbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmPassLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.confirmPassLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirmPassLbl.Location = new System.Drawing.Point(170, 418);
            this.confirmPassLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPassLbl.Name = "confirmPassLbl";
            this.confirmPassLbl.Size = new System.Drawing.Size(107, 25);
            this.confirmPassLbl.TabIndex = 54;
            this.confirmPassLbl.Text = "确认密码：";
            this.confirmPassLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passTxt.Location = new System.Drawing.Point(283, 375);
            this.passTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(230, 29);
            this.passTxt.TabIndex = 53;
            this.passTxt.Leave += new System.EventHandler(this.passTxt_Leave);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passLbl.Location = new System.Drawing.Point(189, 374);
            this.passLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(88, 25);
            this.passLbl.TabIndex = 52;
            this.passLbl.Text = "新密码：";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // glyLevelLbl
            // 
            this.glyLevelLbl.AutoSize = true;
            this.glyLevelLbl.BackColor = System.Drawing.Color.Transparent;
            this.glyLevelLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glyLevelLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.glyLevelLbl.Location = new System.Drawing.Point(151, 271);
            this.glyLevelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.glyLevelLbl.Name = "glyLevelLbl";
            this.glyLevelLbl.Size = new System.Drawing.Size(126, 25);
            this.glyLevelLbl.TabIndex = 50;
            this.glyLevelLbl.Text = "糖尿病等级：";
            this.glyLevelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneTxt.Location = new System.Drawing.Point(281, 211);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(230, 29);
            this.phoneTxt.TabIndex = 49;
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLbl.Location = new System.Drawing.Point(209, 39);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(69, 25);
            this.nameLbl.TabIndex = 48;
            this.nameLbl.Text = "姓名：";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // girlRBTn
            // 
            this.girlRBTn.AutoSize = true;
            this.girlRBTn.BackColor = System.Drawing.Color.Transparent;
            this.girlRBTn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.girlRBTn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.girlRBTn.Location = new System.Drawing.Point(345, 101);
            this.girlRBTn.Margin = new System.Windows.Forms.Padding(2);
            this.girlRBTn.Name = "girlRBTn";
            this.girlRBTn.Size = new System.Drawing.Size(46, 23);
            this.girlRBTn.TabIndex = 47;
            this.girlRBTn.TabStop = true;
            this.girlRBTn.Text = "女";
            this.girlRBTn.UseVisualStyleBackColor = false;
            this.girlRBTn.Click += new System.EventHandler(this.girlRBTn_Click);
            // 
            // boyRBtn
            // 
            this.boyRBtn.AutoSize = true;
            this.boyRBtn.BackColor = System.Drawing.Color.Transparent;
            this.boyRBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boyRBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.boyRBtn.Location = new System.Drawing.Point(283, 101);
            this.boyRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.boyRBtn.Name = "boyRBtn";
            this.boyRBtn.Size = new System.Drawing.Size(46, 23);
            this.boyRBtn.TabIndex = 45;
            this.boyRBtn.TabStop = true;
            this.boyRBtn.Text = "男";
            this.boyRBtn.UseVisualStyleBackColor = false;
            this.boyRBtn.Click += new System.EventHandler(this.boyRBtn_Click);
            // 
            // sexLbl
            // 
            this.sexLbl.AutoSize = true;
            this.sexLbl.BackColor = System.Drawing.Color.Transparent;
            this.sexLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sexLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sexLbl.Location = new System.Drawing.Point(210, 99);
            this.sexLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexLbl.Name = "sexLbl";
            this.sexLbl.Size = new System.Drawing.Size(69, 25);
            this.sexLbl.TabIndex = 44;
            this.sexLbl.Text = "性别：";
            this.sexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phoneLbl.Location = new System.Drawing.Point(208, 210);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(69, 25);
            this.phoneLbl.TabIndex = 42;
            this.phoneLbl.Text = "手机：";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTxt.Location = new System.Drawing.Point(282, 40);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(228, 29);
            this.nameTxt.TabIndex = 41;
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtmedicine
            // 
            this.txtmedicine.FillColor = System.Drawing.Color.White;
            this.txtmedicine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtmedicine.Location = new System.Drawing.Point(202, 249);
            this.txtmedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmedicine.Maximum = 2147483647D;
            this.txtmedicine.Minimum = -2147483648D;
            this.txtmedicine.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Padding = new System.Windows.Forms.Padding(5);
            this.txtmedicine.Size = new System.Drawing.Size(535, 51);
            this.txtmedicine.TabIndex = 24;
            this.txtmedicine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdes
            // 
            this.txtdes.FillColor = System.Drawing.Color.White;
            this.txtdes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtdes.Location = new System.Drawing.Point(202, 369);
            this.txtdes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdes.Maximum = 2147483647D;
            this.txtdes.Minimum = -2147483648D;
            this.txtdes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtdes.Name = "txtdes";
            this.txtdes.Padding = new System.Windows.Forms.Padding(5);
            this.txtdes.Size = new System.Drawing.Size(535, 51);
            this.txtdes.TabIndex = 22;
            this.txtdes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medicine
            // 
            this.medicine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.medicine.Location = new System.Drawing.Point(72, 249);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(123, 26);
            this.medicine.TabIndex = 23;
            this.medicine.Text = "药方";
            this.medicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // des
            // 
            this.des.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.des.Location = new System.Drawing.Point(72, 369);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(123, 26);
            this.des.TabIndex = 21;
            this.des.Text = "备注";
            this.des.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttype
            // 
            this.txttype.FillColor = System.Drawing.Color.White;
            this.txttype.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txttype.Location = new System.Drawing.Point(569, 95);
            this.txttype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttype.Maximum = 2147483647D;
            this.txttype.Minimum = -2147483648D;
            this.txttype.MinimumSize = new System.Drawing.Size(1, 1);
            this.txttype.Name = "txttype";
            this.txttype.Padding = new System.Windows.Forms.Padding(5);
            this.txttype.Size = new System.Drawing.Size(168, 34);
            this.txttype.TabIndex = 20;
            this.txttype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.type.Location = new System.Drawing.Point(439, 103);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(123, 26);
            this.type.TabIndex = 19;
            this.type.Text = "类型";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpname
            // 
            this.txtpname.FillColor = System.Drawing.Color.White;
            this.txtpname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtpname.Location = new System.Drawing.Point(202, 166);
            this.txtpname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpname.Maximum = 2147483647D;
            this.txtpname.Minimum = -2147483648D;
            this.txtpname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpname.Name = "txtpname";
            this.txtpname.Padding = new System.Windows.Forms.Padding(5);
            this.txtpname.Size = new System.Drawing.Size(167, 34);
            this.txtpname.TabIndex = 18;
            this.txtpname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pname.Location = new System.Drawing.Point(72, 174);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(123, 26);
            this.pname.TabIndex = 17;
            this.pname.Text = "患者姓名";
            this.pname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpno
            // 
            this.txtpno.FillColor = System.Drawing.Color.White;
            this.txtpno.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtpno.Location = new System.Drawing.Point(202, 95);
            this.txtpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpno.Maximum = 2147483647D;
            this.txtpno.Minimum = -2147483648D;
            this.txtpno.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpno.Name = "txtpno";
            this.txtpno.Padding = new System.Windows.Forms.Padding(5);
            this.txtpno.Size = new System.Drawing.Size(168, 34);
            this.txtpno.TabIndex = 16;
            this.txtpno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pno
            // 
            this.pno.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pno.Location = new System.Drawing.Point(72, 103);
            this.pno.Name = "pno";
            this.pno.Size = new System.Drawing.Size(123, 26);
            this.pno.TabIndex = 15;
            this.pno.Text = "患者编号";
            this.pno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiTextBox2
            // 
            this.uiTextBox2.FillColor = System.Drawing.Color.White;
            this.uiTextBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTextBox2.Location = new System.Drawing.Point(202, 369);
            this.uiTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox2.Maximum = 2147483647D;
            this.uiTextBox2.Minimum = -2147483648D;
            this.uiTextBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTextBox2.Name = "uiTextBox2";
            this.uiTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.uiTextBox2.Size = new System.Drawing.Size(535, 51);
            this.uiTextBox2.TabIndex = 22;
            this.uiTextBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // patientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.MainMenu);
            this.Name = "patientForm";
            this.Text = "糖尿病患者界面";
            this.MainMenu.ResumeLayout(false);
            this.index.ResumeLayout(false);
            this.uploodData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.viewDiagnosis.ResumeLayout(false);
            this.EditInfo.ResumeLayout(false);
            this.EditInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu MainMenu;
        private System.Windows.Forms.TabPage index;
        private System.Windows.Forms.TabPage uploodData;
        private System.Windows.Forms.TabPage viewDiagnosis;
        private Sunny.UI.UILabel glycemicTips;
        private Sunny.UI.UILabel timeTips;
        private Sunny.UI.UILabel glycemicLbl;
        private Sunny.UI.UITextBox glycemicTxt;
        private Sunny.UI.UIButton glycemicBtn;
        private Sunny.UI.UILabel doctorTips;
        private Sunny.UI.UILabel infoTips;
        private Sunny.UI.UILabel docTelTips;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.TabPage EditInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label illegalAgeLbl;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label wrongOriginPassTips;
        private System.Windows.Forms.Label wrongPassTipsLbl;
        private System.Windows.Forms.Label phoneIllegalTipsLbl;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label nameIllegalTIpsLbl;
        private System.Windows.Forms.TextBox confirmPassTxt;
        private System.Windows.Forms.TextBox originPassTxt;
        private System.Windows.Forms.Label originPassLbl;
        private System.Windows.Forms.Label confirmPassLbl;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label glyLevelLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.RadioButton girlRBTn;
        private System.Windows.Forms.RadioButton boyRBtn;
        private System.Windows.Forms.Label sexLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private Sunny.UI.UILine uiLine1;
        private Sunny.UI.UILabel Fri;
        private Sunny.UI.UILabel Thu;
        private Sunny.UI.UILabel Wed;
        private Sunny.UI.UILabel Tue;
        private Sunny.UI.UILabel MonLbl;
        private System.Windows.Forms.Timer timer;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton refresh;
        private System.Windows.Forms.ComboBox typeTxt;
        private Sunny.UI.UITextBox txtmedicine;
        private Sunny.UI.UITextBox txtdes;
        private Sunny.UI.UILabel medicine;
        private Sunny.UI.UILabel des;
        private Sunny.UI.UITextBox txttype;
        private Sunny.UI.UILabel type;
        private Sunny.UI.UITextBox txtpname;
        private Sunny.UI.UILabel pname;
        private Sunny.UI.UITextBox txtpno;
        private Sunny.UI.UILabel pno;
        private Sunny.UI.UITextBox uiTextBox2;
    }
}

