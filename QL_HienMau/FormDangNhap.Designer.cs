
namespace QL_HienMau
{
    partial class FormDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_showpass = new System.Windows.Forms.CheckBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_role);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_showpass);
            this.panel1.Controls.Add(this.bt_close);
            this.panel1.Controls.Add(this.bt_login);
            this.panel1.Controls.Add(this.txt_pass);
            this.panel1.Controls.Add(this.txt_user);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(150, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 338);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmb_role
            // 
            this.cmb_role.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.cmb_role.Location = new System.Drawing.Point(146, 79);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(299, 29);
            this.cmb_role.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "ROLE:";
            // 
            // cb_showpass
            // 
            this.cb_showpass.AutoSize = true;
            this.cb_showpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_showpass.Location = new System.Drawing.Point(150, 216);
            this.cb_showpass.Name = "cb_showpass";
            this.cb_showpass.Size = new System.Drawing.Size(126, 23);
            this.cb_showpass.TabIndex = 17;
            this.cb_showpass.Text = "Show password";
            this.cb_showpass.UseVisualStyleBackColor = true;
            this.cb_showpass.CheckedChanged += new System.EventHandler(this.cb_showpass_CheckedChanged);
            // 
            // bt_close
            // 
            this.bt_close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_close.ImageKey = "(none)";
            this.bt_close.Location = new System.Drawing.Point(245, 260);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(141, 44);
            this.bt_close.TabIndex = 16;
            this.bt_close.Text = "Thoát";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Image = global::QL_HienMau.Properties.Resources.Keys_icon__1_;
            this.bt_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_login.Location = new System.Drawing.Point(60, 260);
            this.bt_login.Name = "bt_login";
            this.bt_login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_login.Size = new System.Drawing.Size(141, 44);
            this.bt_login.TabIndex = 15;
            this.bt_login.Text = "Đăng nhập";
            this.bt_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(146, 174);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(299, 29);
            this.txt_pass.TabIndex = 13;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // txt_user
            // 
            this.txt_user.AutoCompleteCustomSource.AddRange(new string[] {
            "admin",
            "admin_1",
            "user",
            "user_1"});
            this.txt_user.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_user.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(146, 122);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(299, 29);
            this.txt_user.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "USERNAME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(44, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(384, 36);
            this.label4.TabIndex = 9;
            this.label4.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_HienMau.Properties.Resources.download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_showpass;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_role;
    }
}