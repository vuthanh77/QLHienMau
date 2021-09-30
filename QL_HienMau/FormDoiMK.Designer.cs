
namespace QL_HienMau
{
    partial class FormDoiMK
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_updatepass = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(204, 89);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(246, 26);
            this.txt_username.TabIndex = 1;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(204, 145);
            this.txt_oldpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Size = new System.Drawing.Size(246, 26);
            this.txt_oldpass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Old password:";
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(204, 198);
            this.txt_newpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Size = new System.Drawing.Size(246, 26);
            this.txt_newpass.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "New password:";
            // 
            // bt_updatepass
            // 
            this.bt_updatepass.Location = new System.Drawing.Point(123, 275);
            this.bt_updatepass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_updatepass.Name = "bt_updatepass";
            this.bt_updatepass.Size = new System.Drawing.Size(112, 35);
            this.bt_updatepass.TabIndex = 6;
            this.bt_updatepass.Text = "Confirm";
            this.bt_updatepass.UseVisualStyleBackColor = true;
            this.bt_updatepass.Click += new System.EventHandler(this.bt_updatepass_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(279, 275);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(112, 35);
            this.bt_cancel.TabIndex = 7;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role:";
            // 
            // cmb_role
            // 
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.cmb_role.Location = new System.Drawing.Point(204, 37);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(246, 28);
            this.cmb_role.TabIndex = 9;
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 368);
            this.Controls.Add(this.cmb_role);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_updatepass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDoiMK";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_updatepass;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_role;
    }
}