
namespace Diabetes
{
    partial class Register
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
            this.typeTxt = new System.Windows.Forms.ComboBox();
            this.illegalAgeLbl = new System.Windows.Forms.Label();
            this.ageTxt = new System.Windows.Forms.TextBox();
            this.ageLbl = new System.Windows.Forms.Label();
            this.phoneIllegalTipsLbl = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.nameIllegalTIpsLbl = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.tips = new Sunny.UI.UILabel();
            this.docBtn = new System.Windows.Forms.Button();
            this.patBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // typeTxt
            // 
            this.typeTxt.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.typeTxt.FormattingEnabled = true;
            this.typeTxt.Items.AddRange(new object[] {
            "一级",
            "二级",
            "三级"});
            this.typeTxt.Location = new System.Drawing.Point(441, 393);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(231, 28);
            this.typeTxt.TabIndex = 92;
            this.typeTxt.Text = "三级";
            // 
            // illegalAgeLbl
            // 
            this.illegalAgeLbl.AutoSize = true;
            this.illegalAgeLbl.BackColor = System.Drawing.Color.Transparent;
            this.illegalAgeLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.illegalAgeLbl.ForeColor = System.Drawing.Color.Red;
            this.illegalAgeLbl.Location = new System.Drawing.Point(441, 222);
            this.illegalAgeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.illegalAgeLbl.Name = "illegalAgeLbl";
            this.illegalAgeLbl.Size = new System.Drawing.Size(256, 19);
            this.illegalAgeLbl.TabIndex = 91;
            this.illegalAgeLbl.Text = "年龄输入不合法，请重新输入";
            this.illegalAgeLbl.Visible = false;
            // 
            // ageTxt
            // 
            this.ageTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageTxt.Location = new System.Drawing.Point(443, 191);
            this.ageTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ageTxt.Name = "ageTxt";
            this.ageTxt.Size = new System.Drawing.Size(227, 29);
            this.ageTxt.TabIndex = 90;
            this.ageTxt.Leave += new System.EventHandler(this.ageTxt_Leave);
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.BackColor = System.Drawing.Color.Transparent;
            this.ageLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ageLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ageLbl.Location = new System.Drawing.Point(369, 190);
            this.ageLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(69, 25);
            this.ageLbl.TabIndex = 89;
            this.ageLbl.Text = "年龄：";
            this.ageLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneIllegalTipsLbl
            // 
            this.phoneIllegalTipsLbl.AutoSize = true;
            this.phoneIllegalTipsLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneIllegalTipsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneIllegalTipsLbl.ForeColor = System.Drawing.Color.Red;
            this.phoneIllegalTipsLbl.Location = new System.Drawing.Point(440, 296);
            this.phoneIllegalTipsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneIllegalTipsLbl.Name = "phoneIllegalTipsLbl";
            this.phoneIllegalTipsLbl.Size = new System.Drawing.Size(238, 19);
            this.phoneIllegalTipsLbl.TabIndex = 86;
            this.phoneIllegalTipsLbl.Text = "手机号没到11位或已被注册";
            this.phoneIllegalTipsLbl.Visible = false;
            // 
            // registerBtn
            // 
            this.registerBtn.Enabled = false;
            this.registerBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.registerBtn.Location = new System.Drawing.Point(582, 453);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(96, 51);
            this.registerBtn.TabIndex = 85;
            this.registerBtn.Text = "注册";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // nameIllegalTIpsLbl
            // 
            this.nameIllegalTIpsLbl.AutoSize = true;
            this.nameIllegalTIpsLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameIllegalTIpsLbl.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameIllegalTIpsLbl.ForeColor = System.Drawing.Color.Red;
            this.nameIllegalTIpsLbl.Location = new System.Drawing.Point(441, 120);
            this.nameIllegalTIpsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameIllegalTIpsLbl.Name = "nameIllegalTIpsLbl";
            this.nameIllegalTIpsLbl.Size = new System.Drawing.Size(218, 19);
            this.nameIllegalTIpsLbl.TabIndex = 74;
            this.nameIllegalTIpsLbl.Text = "姓名不合法，请重新输入";
            this.nameIllegalTIpsLbl.Visible = false;
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passTxt.Location = new System.Drawing.Point(441, 326);
            this.passTxt.Margin = new System.Windows.Forms.Padding(2);
            this.passTxt.Name = "passTxt";
            this.passTxt.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(230, 29);
            this.passTxt.TabIndex = 80;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.BackColor = System.Drawing.Color.Transparent;
            this.passLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passLbl.Location = new System.Drawing.Point(369, 326);
            this.passLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(69, 25);
            this.passLbl.TabIndex = 79;
            this.passLbl.Text = "密码：";
            this.passLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // glyLevelLbl
            // 
            this.glyLevelLbl.AutoSize = true;
            this.glyLevelLbl.BackColor = System.Drawing.Color.Transparent;
            this.glyLevelLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.glyLevelLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.glyLevelLbl.Location = new System.Drawing.Point(313, 393);
            this.glyLevelLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.glyLevelLbl.Name = "glyLevelLbl";
            this.glyLevelLbl.Size = new System.Drawing.Size(126, 25);
            this.glyLevelLbl.TabIndex = 78;
            this.glyLevelLbl.Text = "糖尿病等级：";
            this.glyLevelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneTxt.Location = new System.Drawing.Point(441, 260);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(2);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(230, 29);
            this.phoneTxt.TabIndex = 77;
            this.phoneTxt.Leave += new System.EventHandler(this.phoneTxt_Leave);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLbl.Location = new System.Drawing.Point(369, 88);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(69, 25);
            this.nameLbl.TabIndex = 76;
            this.nameLbl.Text = "姓名：";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // girlRBTn
            // 
            this.girlRBTn.AutoSize = true;
            this.girlRBTn.BackColor = System.Drawing.Color.Transparent;
            this.girlRBTn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.girlRBTn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.girlRBTn.Location = new System.Drawing.Point(505, 150);
            this.girlRBTn.Margin = new System.Windows.Forms.Padding(2);
            this.girlRBTn.Name = "girlRBTn";
            this.girlRBTn.Size = new System.Drawing.Size(46, 23);
            this.girlRBTn.TabIndex = 75;
            this.girlRBTn.TabStop = true;
            this.girlRBTn.Text = "女";
            this.girlRBTn.UseVisualStyleBackColor = false;
            // 
            // boyRBtn
            // 
            this.boyRBtn.AutoSize = true;
            this.boyRBtn.BackColor = System.Drawing.Color.Transparent;
            this.boyRBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boyRBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.boyRBtn.Location = new System.Drawing.Point(443, 150);
            this.boyRBtn.Margin = new System.Windows.Forms.Padding(2);
            this.boyRBtn.Name = "boyRBtn";
            this.boyRBtn.Size = new System.Drawing.Size(46, 23);
            this.boyRBtn.TabIndex = 73;
            this.boyRBtn.TabStop = true;
            this.boyRBtn.Text = "男";
            this.boyRBtn.UseVisualStyleBackColor = false;
            // 
            // sexLbl
            // 
            this.sexLbl.AutoSize = true;
            this.sexLbl.BackColor = System.Drawing.Color.Transparent;
            this.sexLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sexLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sexLbl.Location = new System.Drawing.Point(370, 148);
            this.sexLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexLbl.Name = "sexLbl";
            this.sexLbl.Size = new System.Drawing.Size(69, 25);
            this.sexLbl.TabIndex = 72;
            this.sexLbl.Text = "性别：";
            this.sexLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.BackColor = System.Drawing.Color.Transparent;
            this.phoneLbl.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phoneLbl.Location = new System.Drawing.Point(368, 259);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(69, 25);
            this.phoneLbl.TabIndex = 71;
            this.phoneLbl.Text = "手机：";
            this.phoneLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameTxt.Location = new System.Drawing.Point(442, 89);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(2);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(228, 29);
            this.nameTxt.TabIndex = 70;
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(311, 490);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 93;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tips
            // 
            this.tips.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tips.ForeColor = System.Drawing.Color.White;
            this.tips.Location = new System.Drawing.Point(12, 9);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(335, 65);
            this.tips.TabIndex = 94;
            this.tips.Text = "请选择要注册的身份（默认为病人）：";
            this.tips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // docBtn
            // 
            this.docBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.docBtn.Location = new System.Drawing.Point(169, 67);
            this.docBtn.Margin = new System.Windows.Forms.Padding(2);
            this.docBtn.Name = "docBtn";
            this.docBtn.Size = new System.Drawing.Size(96, 51);
            this.docBtn.TabIndex = 95;
            this.docBtn.Text = "医生";
            this.docBtn.UseVisualStyleBackColor = true;
            this.docBtn.Click += new System.EventHandler(this.docBtn_Click);
            // 
            // patBtn
            // 
            this.patBtn.Font = new System.Drawing.Font("宋体", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.patBtn.Location = new System.Drawing.Point(169, 136);
            this.patBtn.Margin = new System.Windows.Forms.Padding(2);
            this.patBtn.Name = "patBtn";
            this.patBtn.Size = new System.Drawing.Size(96, 51);
            this.patBtn.TabIndex = 96;
            this.patBtn.Text = "病人";
            this.patBtn.UseVisualStyleBackColor = true;
            this.patBtn.Click += new System.EventHandler(this.patBtn_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.patBtn);
            this.Controls.Add(this.docBtn);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTxt);
            this.Controls.Add(this.illegalAgeLbl);
            this.Controls.Add(this.ageTxt);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.phoneIllegalTipsLbl);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.nameIllegalTIpsLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.glyLevelLbl);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.girlRBTn);
            this.Controls.Add(this.boyRBtn);
            this.Controls.Add(this.sexLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.nameTxt);
            this.Name = "Register";
            this.Text = "注册界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeTxt;
        private System.Windows.Forms.Label illegalAgeLbl;
        private System.Windows.Forms.TextBox ageTxt;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label phoneIllegalTipsLbl;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label nameIllegalTIpsLbl;
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
        private System.Windows.Forms.Label label1;
        private Sunny.UI.UILabel tips;
        private System.Windows.Forms.Button docBtn;
        private System.Windows.Forms.Button patBtn;
        private System.Windows.Forms.Timer timer;
    }
}