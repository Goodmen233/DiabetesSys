
namespace Diabetes
{
    partial class Diagnose
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
            this.uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.upload = new Sunny.UI.UIButton();
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
            this.uiTabControlMenu1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTabControlMenu1
            // 
            this.uiTabControlMenu1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.uiTabControlMenu1.Controls.Add(this.tabPage1);
            this.uiTabControlMenu1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.uiTabControlMenu1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiTabControlMenu1.ItemSize = new System.Drawing.Size(40, 200);
            this.uiTabControlMenu1.Location = new System.Drawing.Point(2, 2);
            this.uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiTabControlMenu1.Multiline = true;
            this.uiTabControlMenu1.Name = "uiTabControlMenu1";
            this.uiTabControlMenu1.SelectedIndex = 0;
            this.uiTabControlMenu1.Size = new System.Drawing.Size(1005, 676);
            this.uiTabControlMenu1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.uiTabControlMenu1.Style = Sunny.UI.UIStyle.Custom;
            this.uiTabControlMenu1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.uiTabControlMenu1.TabIndex = 1;
            this.uiTabControlMenu1.TabSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(195)))), ((int)(((byte)(193)))));
            this.tabPage1.Controls.Add(this.upload);
            this.tabPage1.Controls.Add(this.txtmedicine);
            this.tabPage1.Controls.Add(this.txtdes);
            this.tabPage1.Controls.Add(this.medicine);
            this.tabPage1.Controls.Add(this.des);
            this.tabPage1.Controls.Add(this.txttype);
            this.tabPage1.Controls.Add(this.type);
            this.tabPage1.Controls.Add(this.txtpname);
            this.tabPage1.Controls.Add(this.pname);
            this.tabPage1.Controls.Add(this.txtpno);
            this.tabPage1.Controls.Add(this.pno);
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(804, 676);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "诊断";
            // 
            // upload
            // 
            this.upload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.upload.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.upload.Location = new System.Drawing.Point(199, 456);
            this.upload.MinimumSize = new System.Drawing.Size(1, 1);
            this.upload.Name = "upload";
            this.upload.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.upload.Size = new System.Drawing.Size(164, 58);
            this.upload.Style = Sunny.UI.UIStyle.Custom;
            this.upload.TabIndex = 14;
            this.upload.Text = "上传";
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // txtmedicine
            // 
            this.txtmedicine.FillColor = System.Drawing.Color.White;
            this.txtmedicine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtmedicine.Location = new System.Drawing.Point(195, 174);
            this.txtmedicine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmedicine.Maximum = 2147483647D;
            this.txtmedicine.Minimum = -2147483648D;
            this.txtmedicine.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Padding = new System.Windows.Forms.Padding(5);
            this.txtmedicine.Size = new System.Drawing.Size(535, 51);
            this.txtmedicine.TabIndex = 13;
            this.txtmedicine.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtdes
            // 
            this.txtdes.FillColor = System.Drawing.Color.White;
            this.txtdes.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtdes.Location = new System.Drawing.Point(195, 294);
            this.txtdes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdes.Maximum = 2147483647D;
            this.txtdes.Minimum = -2147483648D;
            this.txtdes.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtdes.Name = "txtdes";
            this.txtdes.Padding = new System.Windows.Forms.Padding(5);
            this.txtdes.Size = new System.Drawing.Size(535, 51);
            this.txtdes.TabIndex = 11;
            this.txtdes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medicine
            // 
            this.medicine.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.medicine.Location = new System.Drawing.Point(65, 174);
            this.medicine.Name = "medicine";
            this.medicine.Size = new System.Drawing.Size(123, 26);
            this.medicine.TabIndex = 12;
            this.medicine.Text = "药方";
            this.medicine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // des
            // 
            this.des.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.des.Location = new System.Drawing.Point(65, 294);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(123, 26);
            this.des.TabIndex = 10;
            this.des.Text = "备注";
            this.des.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txttype
            // 
            this.txttype.FillColor = System.Drawing.Color.White;
            this.txttype.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txttype.Location = new System.Drawing.Point(562, 20);
            this.txttype.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttype.Maximum = 2147483647D;
            this.txttype.Minimum = -2147483648D;
            this.txttype.MinimumSize = new System.Drawing.Size(1, 1);
            this.txttype.Name = "txttype";
            this.txttype.Padding = new System.Windows.Forms.Padding(5);
            this.txttype.Size = new System.Drawing.Size(168, 34);
            this.txttype.TabIndex = 7;
            this.txttype.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // type
            // 
            this.type.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.type.Location = new System.Drawing.Point(432, 28);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(123, 26);
            this.type.TabIndex = 6;
            this.type.Text = "类型";
            this.type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpname
            // 
            this.txtpname.FillColor = System.Drawing.Color.White;
            this.txtpname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtpname.Location = new System.Drawing.Point(195, 91);
            this.txtpname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpname.Maximum = 2147483647D;
            this.txtpname.Minimum = -2147483648D;
            this.txtpname.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpname.Name = "txtpname";
            this.txtpname.Padding = new System.Windows.Forms.Padding(5);
            this.txtpname.Size = new System.Drawing.Size(167, 34);
            this.txtpname.TabIndex = 5;
            this.txtpname.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pname
            // 
            this.pname.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pname.Location = new System.Drawing.Point(65, 99);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(123, 26);
            this.pname.TabIndex = 4;
            this.pname.Text = "患者姓名";
            this.pname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtpno
            // 
            this.txtpno.FillColor = System.Drawing.Color.White;
            this.txtpno.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtpno.Location = new System.Drawing.Point(195, 20);
            this.txtpno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpno.Maximum = 2147483647D;
            this.txtpno.Minimum = -2147483648D;
            this.txtpno.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtpno.Name = "txtpno";
            this.txtpno.Padding = new System.Windows.Forms.Padding(5);
            this.txtpno.Size = new System.Drawing.Size(168, 34);
            this.txtpno.TabIndex = 3;
            this.txtpno.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pno
            // 
            this.pno.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pno.Location = new System.Drawing.Point(65, 28);
            this.pno.Name = "pno";
            this.pno.Size = new System.Drawing.Size(123, 26);
            this.pno.TabIndex = 2;
            this.pno.Text = "患者编号";
            this.pno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Diagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.uiTabControlMenu1);
            this.Name = "Diagnose";
            this.Text = "诊断书";
            this.Load += new System.EventHandler(this.diagnose_Load);
            this.uiTabControlMenu1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UIButton upload;
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
    }
}