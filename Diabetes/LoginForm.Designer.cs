
namespace Diabetes
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.Register = new Sunny.UI.UILabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AccountPic = new System.Windows.Forms.PictureBox();
            this.LoginBTN = new Sunny.UI.UIButton();
            this.PwdBtn = new Sunny.UI.UITextBox();
            this.AccountTxB = new Sunny.UI.UITextBox();
            this.TitileLogin = new Sunny.UI.UILabel();
            this.pwdTips = new Sunny.UI.UITextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPic)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.uiLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.uiLabel1.Location = new System.Drawing.Point(690, 493);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 16;
            this.uiLabel1.Text = "忘记密码";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Register.ForeColor = System.Drawing.SystemColors.Window;
            this.Register.Location = new System.Drawing.Point(811, 444);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 23);
            this.Register.TabIndex = 15;
            this.Register.Text = "注册";
            this.Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(539, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // AccountPic
            // 
            this.AccountPic.BackColor = System.Drawing.SystemColors.Window;
            this.AccountPic.Image = ((System.Drawing.Image)(resources.GetObject("AccountPic.Image")));
            this.AccountPic.Location = new System.Drawing.Point(541, 265);
            this.AccountPic.Name = "AccountPic";
            this.AccountPic.Size = new System.Drawing.Size(49, 49);
            this.AccountPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AccountPic.TabIndex = 13;
            this.AccountPic.TabStop = false;
            // 
            // LoginBTN
            // 
            this.LoginBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.LoginBTN.FillHoverColor = System.Drawing.Color.LightSeaGreen;
            this.LoginBTN.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.LoginBTN.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.LoginBTN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LoginBTN.Location = new System.Drawing.Point(555, 434);
            this.LoginBTN.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Radius = 10;
            this.LoginBTN.Size = new System.Drawing.Size(235, 42);
            this.LoginBTN.Style = Sunny.UI.UIStyle.Custom;
            this.LoginBTN.TabIndex = 12;
            this.LoginBTN.Text = "登录";
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // PwdBtn
            // 
            this.PwdBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PwdBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.PwdBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.PwdBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.PwdBtn.Location = new System.Drawing.Point(588, 349);
            this.PwdBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PwdBtn.Maximum = 2147483647D;
            this.PwdBtn.Minimum = -2147483648D;
            this.PwdBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.PwdBtn.Name = "PwdBtn";
            this.PwdBtn.Padding = new System.Windows.Forms.Padding(5);
            this.PwdBtn.Radius = 0;
            this.PwdBtn.RectColor = System.Drawing.Color.White;
            this.PwdBtn.Size = new System.Drawing.Size(280, 49);
            this.PwdBtn.Style = Sunny.UI.UIStyle.Custom;
            this.PwdBtn.TabIndex = 11;
            this.PwdBtn.Text = "密码";
            this.PwdBtn.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.PwdBtn.Click += new System.EventHandler(this.PwdBtn_Click);
            // 
            // AccountTxB
            // 
            this.AccountTxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccountTxB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.AccountTxB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.AccountTxB.ForeColor = System.Drawing.Color.DarkGray;
            this.AccountTxB.Location = new System.Drawing.Point(588, 265);
            this.AccountTxB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccountTxB.Maximum = 2147483647D;
            this.AccountTxB.Minimum = -2147483648D;
            this.AccountTxB.MinimumSize = new System.Drawing.Size(1, 1);
            this.AccountTxB.Name = "AccountTxB";
            this.AccountTxB.Padding = new System.Windows.Forms.Padding(5);
            this.AccountTxB.RectColor = System.Drawing.Color.White;
            this.AccountTxB.Size = new System.Drawing.Size(280, 49);
            this.AccountTxB.Style = Sunny.UI.UIStyle.Custom;
            this.AccountTxB.TabIndex = 10;
            this.AccountTxB.Text = "账号";
            this.AccountTxB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.AccountTxB.Click += new System.EventHandler(this.AccountTxB_MouseClick);
            // 
            // TitileLogin
            // 
            this.TitileLogin.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitileLogin.ForeColor = System.Drawing.Color.White;
            this.TitileLogin.Location = new System.Drawing.Point(97, 165);
            this.TitileLogin.Name = "TitileLogin";
            this.TitileLogin.Size = new System.Drawing.Size(328, 78);
            this.TitileLogin.TabIndex = 9;
            this.TitileLogin.Text = "糖尿病医患交流平台";
            this.TitileLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pwdTips
            // 
            this.pwdTips.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdTips.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pwdTips.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.pwdTips.ForeColor = System.Drawing.Color.DarkGray;
            this.pwdTips.Location = new System.Drawing.Point(588, 349);
            this.pwdTips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwdTips.Maximum = 2147483647D;
            this.pwdTips.Minimum = -2147483648D;
            this.pwdTips.MinimumSize = new System.Drawing.Size(1, 1);
            this.pwdTips.Name = "pwdTips";
            this.pwdTips.Padding = new System.Windows.Forms.Padding(5);
            this.pwdTips.Radius = 0;
            this.pwdTips.RectColor = System.Drawing.Color.White;
            this.pwdTips.Size = new System.Drawing.Size(280, 49);
            this.pwdTips.Style = Sunny.UI.UIStyle.Custom;
            this.pwdTips.TabIndex = 11;
            this.pwdTips.Text = "密码";
            this.pwdTips.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AccountPic);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.PwdBtn);
            this.Controls.Add(this.AccountTxB);
            this.Controls.Add(this.TitileLogin);
            this.Name = "LoginForm";
            this.Text = "登录";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel Register;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox AccountPic;
        private Sunny.UI.UIButton LoginBTN;
        private Sunny.UI.UITextBox PwdBtn;
        private Sunny.UI.UITextBox AccountTxB;
        private Sunny.UI.UILabel TitileLogin;
        private Sunny.UI.UITextBox pwdTips;
    }
}