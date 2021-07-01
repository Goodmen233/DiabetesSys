
namespace Diabetes
{
    partial class AdminForm
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
            this.AdminTabCtrl = new Sunny.UI.UITabControlMenu();
            this.GetAllPhd = new System.Windows.Forms.TabPage();
            this.DocLVW = new System.Windows.Forms.ListView();
            this.DocLB2 = new Sunny.UI.UILabel();
            this.DocBTN = new Sunny.UI.UIButton();
            this.DocLB1 = new Sunny.UI.UILabel();
            this.DocTxB = new Sunny.UI.UITextBox();
            this.GetAllUser = new System.Windows.Forms.TabPage();
            this.UserLVW = new System.Windows.Forms.ListView();
            this.UserLB2 = new Sunny.UI.UILabel();
            this.UserBTN = new Sunny.UI.UIButton();
            this.UserLB1 = new Sunny.UI.UILabel();
            this.UserTxB = new Sunny.UI.UITextBox();
            this.Approval = new System.Windows.Forms.TabPage();
            this.ApprovalLVW = new System.Windows.Forms.ListView();
            this.ApprovalLB2 = new Sunny.UI.UILabel();
            this.ApprovalBTN = new Sunny.UI.UIButton();
            this.ApprovalTB1 = new Sunny.UI.UILabel();
            this.ApprovalTxB = new Sunny.UI.UITextBox();
            this.AdminTabCtrl.SuspendLayout();
            this.GetAllPhd.SuspendLayout();
            this.GetAllUser.SuspendLayout();
            this.Approval.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminTabCtrl
            // 
            this.AdminTabCtrl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.AdminTabCtrl.Controls.Add(this.GetAllPhd);
            this.AdminTabCtrl.Controls.Add(this.GetAllUser);
            this.AdminTabCtrl.Controls.Add(this.Approval);
            this.AdminTabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.AdminTabCtrl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.AdminTabCtrl.ItemSize = new System.Drawing.Size(80, 180);
            this.AdminTabCtrl.Location = new System.Drawing.Point(1, 64);
            this.AdminTabCtrl.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.AdminTabCtrl.Multiline = true;
            this.AdminTabCtrl.Name = "AdminTabCtrl";
            this.AdminTabCtrl.SelectedIndex = 0;
            this.AdminTabCtrl.Size = new System.Drawing.Size(1005, 617);
            this.AdminTabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.AdminTabCtrl.Style = Sunny.UI.UIStyle.Custom;
            this.AdminTabCtrl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.AdminTabCtrl.TabIndex = 1;
            this.AdminTabCtrl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.AdminTabCtrl.TabSelectedForeColor = System.Drawing.Color.White;
            this.AdminTabCtrl.TabSelectedHighColor = System.Drawing.Color.White;
            this.AdminTabCtrl.TabUnSelectedForeColor = System.Drawing.Color.White;
            // 
            // GetAllPhd
            // 
            this.GetAllPhd.Controls.Add(this.DocLVW);
            this.GetAllPhd.Controls.Add(this.DocLB2);
            this.GetAllPhd.Controls.Add(this.DocBTN);
            this.GetAllPhd.Controls.Add(this.DocLB1);
            this.GetAllPhd.Controls.Add(this.DocTxB);
            this.GetAllPhd.Location = new System.Drawing.Point(181, 0);
            this.GetAllPhd.Name = "GetAllPhd";
            this.GetAllPhd.Size = new System.Drawing.Size(824, 617);
            this.GetAllPhd.TabIndex = 0;
            this.GetAllPhd.Text = "查看所有医生";
            this.GetAllPhd.UseVisualStyleBackColor = true;
            this.GetAllPhd.Click += new System.EventHandler(this.GetAllPhd_Click);
            // 
            // DocLVW
            // 
            this.DocLVW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DocLVW.FullRowSelect = true;
            this.DocLVW.HideSelection = false;
            this.DocLVW.Location = new System.Drawing.Point(17, 143);
            this.DocLVW.Name = "DocLVW";
            this.DocLVW.Size = new System.Drawing.Size(796, 463);
            this.DocLVW.TabIndex = 8;
            this.DocLVW.UseCompatibleStateImageBehavior = false;
            this.DocLVW.View = System.Windows.Forms.View.Details;
            this.DocLVW.ItemActivate += new System.EventHandler(this.DocLVW_ItemActivate);
            // 
            // DocLB2
            // 
            this.DocLB2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DocLB2.Location = new System.Drawing.Point(195, 96);
            this.DocLB2.Name = "DocLB2";
            this.DocLB2.Size = new System.Drawing.Size(269, 44);
            this.DocLB2.TabIndex = 3;
            this.DocLB2.Text = "查无此人！";
            this.DocLB2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocLB2.Visible = false;
            // 
            // DocBTN
            // 
            this.DocBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DocBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.DocBTN.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.DocBTN.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.DocBTN.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.DocBTN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DocBTN.Location = new System.Drawing.Point(555, 58);
            this.DocBTN.MinimumSize = new System.Drawing.Size(1, 1);
            this.DocBTN.Name = "DocBTN";
            this.DocBTN.Radius = 10;
            this.DocBTN.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.DocBTN.Size = new System.Drawing.Size(100, 35);
            this.DocBTN.Style = Sunny.UI.UIStyle.Custom;
            this.DocBTN.TabIndex = 2;
            this.DocBTN.Text = "查询";
            this.DocBTN.Click += new System.EventHandler(this.DocBTN_Click);
            // 
            // DocLB1
            // 
            this.DocLB1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DocLB1.Location = new System.Drawing.Point(90, 61);
            this.DocLB1.Name = "DocLB1";
            this.DocLB1.Size = new System.Drawing.Size(119, 23);
            this.DocLB1.TabIndex = 1;
            this.DocLB1.Text = "医生姓名：";
            this.DocLB1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DocTxB
            // 
            this.DocTxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocTxB.FillColor = System.Drawing.Color.White;
            this.DocTxB.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.DocTxB.Location = new System.Drawing.Point(213, 57);
            this.DocTxB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DocTxB.Maximum = 2147483647D;
            this.DocTxB.Minimum = -2147483648D;
            this.DocTxB.MinimumSize = new System.Drawing.Size(1, 1);
            this.DocTxB.Name = "DocTxB";
            this.DocTxB.RectColor = System.Drawing.Color.Gray;
            this.DocTxB.Size = new System.Drawing.Size(254, 34);
            this.DocTxB.Style = Sunny.UI.UIStyle.Custom;
            this.DocTxB.TabIndex = 0;
            this.DocTxB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GetAllUser
            // 
            this.GetAllUser.Controls.Add(this.UserLVW);
            this.GetAllUser.Controls.Add(this.UserLB2);
            this.GetAllUser.Controls.Add(this.UserBTN);
            this.GetAllUser.Controls.Add(this.UserLB1);
            this.GetAllUser.Controls.Add(this.UserTxB);
            this.GetAllUser.Location = new System.Drawing.Point(181, 0);
            this.GetAllUser.Name = "GetAllUser";
            this.GetAllUser.Size = new System.Drawing.Size(824, 617);
            this.GetAllUser.TabIndex = 1;
            this.GetAllUser.Text = "查看所有用户";
            this.GetAllUser.UseVisualStyleBackColor = true;
            this.GetAllUser.Click += new System.EventHandler(this.GetAllUser_Click);
            // 
            // UserLVW
            // 
            this.UserLVW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLVW.FullRowSelect = true;
            this.UserLVW.HideSelection = false;
            this.UserLVW.Location = new System.Drawing.Point(17, 143);
            this.UserLVW.Name = "UserLVW";
            this.UserLVW.Size = new System.Drawing.Size(796, 463);
            this.UserLVW.TabIndex = 7;
            this.UserLVW.UseCompatibleStateImageBehavior = false;
            this.UserLVW.View = System.Windows.Forms.View.Details;
            this.UserLVW.ItemActivate += new System.EventHandler(this.UserLVW_ItemActivate);
            // 
            // UserLB2
            // 
            this.UserLB2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserLB2.Location = new System.Drawing.Point(195, 96);
            this.UserLB2.Name = "UserLB2";
            this.UserLB2.Size = new System.Drawing.Size(269, 44);
            this.UserLB2.TabIndex = 6;
            this.UserLB2.Text = "查无此人！";
            this.UserLB2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserLB2.Visible = false;
            // 
            // UserBTN
            // 
            this.UserBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.UserBTN.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.UserBTN.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.UserBTN.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.UserBTN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserBTN.Location = new System.Drawing.Point(555, 58);
            this.UserBTN.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserBTN.Name = "UserBTN";
            this.UserBTN.Radius = 10;
            this.UserBTN.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.UserBTN.Size = new System.Drawing.Size(100, 35);
            this.UserBTN.Style = Sunny.UI.UIStyle.Custom;
            this.UserBTN.TabIndex = 5;
            this.UserBTN.Text = "查询";
            this.UserBTN.Click += new System.EventHandler(this.UserBTN_Click);
            // 
            // UserLB1
            // 
            this.UserLB1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserLB1.Location = new System.Drawing.Point(90, 61);
            this.UserLB1.Name = "UserLB1";
            this.UserLB1.Size = new System.Drawing.Size(119, 23);
            this.UserLB1.TabIndex = 4;
            this.UserLB1.Text = "用户姓名：";
            this.UserLB1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserTxB
            // 
            this.UserTxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserTxB.FillColor = System.Drawing.Color.White;
            this.UserTxB.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.UserTxB.Location = new System.Drawing.Point(213, 57);
            this.UserTxB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTxB.Maximum = 2147483647D;
            this.UserTxB.Minimum = -2147483648D;
            this.UserTxB.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserTxB.Name = "UserTxB";
            this.UserTxB.RectColor = System.Drawing.Color.Gray;
            this.UserTxB.Size = new System.Drawing.Size(254, 34);
            this.UserTxB.Style = Sunny.UI.UIStyle.Custom;
            this.UserTxB.TabIndex = 3;
            this.UserTxB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Approval
            // 
            this.Approval.Controls.Add(this.ApprovalLVW);
            this.Approval.Controls.Add(this.ApprovalLB2);
            this.Approval.Controls.Add(this.ApprovalBTN);
            this.Approval.Controls.Add(this.ApprovalTB1);
            this.Approval.Controls.Add(this.ApprovalTxB);
            this.Approval.Location = new System.Drawing.Point(181, 0);
            this.Approval.Name = "Approval";
            this.Approval.Size = new System.Drawing.Size(824, 617);
            this.Approval.TabIndex = 2;
            this.Approval.Text = "审批";
            this.Approval.UseVisualStyleBackColor = true;
            this.Approval.Click += new System.EventHandler(this.Approval_Click);
            // 
            // ApprovalLVW
            // 
            this.ApprovalLVW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApprovalLVW.FullRowSelect = true;
            this.ApprovalLVW.HideSelection = false;
            this.ApprovalLVW.Location = new System.Drawing.Point(17, 143);
            this.ApprovalLVW.Name = "ApprovalLVW";
            this.ApprovalLVW.Size = new System.Drawing.Size(796, 463);
            this.ApprovalLVW.TabIndex = 8;
            this.ApprovalLVW.UseCompatibleStateImageBehavior = false;
            this.ApprovalLVW.View = System.Windows.Forms.View.Details;
            this.ApprovalLVW.ItemActivate += new System.EventHandler(this.ApprovalLVW_ItemActivate);
            // 
            // ApprovalLB2
            // 
            this.ApprovalLB2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ApprovalLB2.Location = new System.Drawing.Point(195, 96);
            this.ApprovalLB2.Name = "ApprovalLB2";
            this.ApprovalLB2.Size = new System.Drawing.Size(269, 44);
            this.ApprovalLB2.TabIndex = 7;
            this.ApprovalLB2.Text = "查无此人！";
            this.ApprovalLB2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApprovalLB2.Visible = false;
            // 
            // ApprovalBTN
            // 
            this.ApprovalBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApprovalBTN.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.ApprovalBTN.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.ApprovalBTN.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.ApprovalBTN.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.ApprovalBTN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ApprovalBTN.Location = new System.Drawing.Point(555, 58);
            this.ApprovalBTN.MinimumSize = new System.Drawing.Size(1, 1);
            this.ApprovalBTN.Name = "ApprovalBTN";
            this.ApprovalBTN.Radius = 10;
            this.ApprovalBTN.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.ApprovalBTN.Size = new System.Drawing.Size(100, 35);
            this.ApprovalBTN.Style = Sunny.UI.UIStyle.Custom;
            this.ApprovalBTN.TabIndex = 6;
            this.ApprovalBTN.Text = "查询";
            this.ApprovalBTN.Click += new System.EventHandler(this.ApprovalBTN_Click);
            // 
            // ApprovalTB1
            // 
            this.ApprovalTB1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ApprovalTB1.Location = new System.Drawing.Point(90, 61);
            this.ApprovalTB1.Name = "ApprovalTB1";
            this.ApprovalTB1.Size = new System.Drawing.Size(119, 23);
            this.ApprovalTB1.TabIndex = 5;
            this.ApprovalTB1.Text = "手机号：";
            this.ApprovalTB1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ApprovalTxB
            // 
            this.ApprovalTxB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ApprovalTxB.FillColor = System.Drawing.Color.White;
            this.ApprovalTxB.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ApprovalTxB.Location = new System.Drawing.Point(213, 57);
            this.ApprovalTxB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApprovalTxB.Maximum = 2147483647D;
            this.ApprovalTxB.Minimum = -2147483648D;
            this.ApprovalTxB.MinimumSize = new System.Drawing.Size(1, 1);
            this.ApprovalTxB.Name = "ApprovalTxB";
            this.ApprovalTxB.RectColor = System.Drawing.Color.Gray;
            this.ApprovalTxB.Size = new System.Drawing.Size(254, 34);
            this.ApprovalTxB.Style = Sunny.UI.UIStyle.Custom;
            this.ApprovalTxB.TabIndex = 4;
            this.ApprovalTxB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.AdminTabCtrl);
            this.Name = "AdminForm";
            this.Text = "管理员界面";
            this.AdminTabCtrl.ResumeLayout(false);
            this.GetAllPhd.ResumeLayout(false);
            this.GetAllUser.ResumeLayout(false);
            this.Approval.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu AdminTabCtrl;
        private System.Windows.Forms.TabPage GetAllPhd;
        private System.Windows.Forms.ListView DocLVW;
        private Sunny.UI.UILabel DocLB2;
        private Sunny.UI.UIButton DocBTN;
        private Sunny.UI.UILabel DocLB1;
        private Sunny.UI.UITextBox DocTxB;
        private System.Windows.Forms.TabPage GetAllUser;
        private System.Windows.Forms.ListView UserLVW;
        private Sunny.UI.UILabel UserLB2;
        private Sunny.UI.UIButton UserBTN;
        private Sunny.UI.UILabel UserLB1;
        private Sunny.UI.UITextBox UserTxB;
        private System.Windows.Forms.TabPage Approval;
        private System.Windows.Forms.ListView ApprovalLVW;
        private Sunny.UI.UILabel ApprovalLB2;
        private Sunny.UI.UIButton ApprovalBTN;
        private Sunny.UI.UILabel ApprovalTB1;
        private Sunny.UI.UITextBox ApprovalTxB;
    }
}