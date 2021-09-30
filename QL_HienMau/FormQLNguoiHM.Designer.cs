
namespace QL_HienMau
{
    partial class FormQLNguoiHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNguoiHM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_resultID = new System.Windows.Forms.ComboBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.cmb_htID = new System.Windows.Forms.ComboBox();
            this.cmb_mauID = new System.Windows.Forms.ComboBox();
            this.cmb_gt = new System.Windows.Forms.ComboBox();
            this.dtp_ns = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_dc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nameID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grv_nhm = new System.Windows.Forms.DataGridView();
            this.bt_insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_nhm)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_resultID);
            this.groupBox1.Controls.Add(this.txt_weight);
            this.groupBox1.Controls.Add(this.cmb_htID);
            this.groupBox1.Controls.Add(this.cmb_mauID);
            this.groupBox1.Controls.Add(this.cmb_gt);
            this.groupBox1.Controls.Add(this.dtp_ns);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_dc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nameID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin:";
            // 
            // cmb_resultID
            // 
            this.cmb_resultID.FormattingEnabled = true;
            this.cmb_resultID.Location = new System.Drawing.Point(399, 101);
            this.cmb_resultID.Name = "cmb_resultID";
            this.cmb_resultID.Size = new System.Drawing.Size(231, 21);
            this.cmb_resultID.TabIndex = 24;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(399, 27);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(231, 20);
            this.txt_weight.TabIndex = 23;
            // 
            // cmb_htID
            // 
            this.cmb_htID.FormattingEnabled = true;
            this.cmb_htID.Location = new System.Drawing.Point(399, 134);
            this.cmb_htID.Name = "cmb_htID";
            this.cmb_htID.Size = new System.Drawing.Size(231, 21);
            this.cmb_htID.TabIndex = 22;
            // 
            // cmb_mauID
            // 
            this.cmb_mauID.FormattingEnabled = true;
            this.cmb_mauID.Location = new System.Drawing.Point(399, 61);
            this.cmb_mauID.Name = "cmb_mauID";
            this.cmb_mauID.Size = new System.Drawing.Size(231, 21);
            this.cmb_mauID.TabIndex = 20;
            // 
            // cmb_gt
            // 
            this.cmb_gt.FormattingEnabled = true;
            this.cmb_gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmb_gt.Location = new System.Drawing.Point(81, 137);
            this.cmb_gt.Name = "cmb_gt";
            this.cmb_gt.Size = new System.Drawing.Size(231, 21);
            this.cmb_gt.TabIndex = 19;
            this.cmb_gt.SelectedIndexChanged += new System.EventHandler(this.cmb_gt_SelectedIndexChanged);
            // 
            // dtp_ns
            // 
            this.dtp_ns.Location = new System.Drawing.Point(81, 102);
            this.dtp_ns.Name = "dtp_ns";
            this.dtp_ns.Size = new System.Drawing.Size(231, 20);
            this.dtp_ns.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(336, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Mã HT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã KQĐVM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã ĐV máu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cân nặng:";
            // 
            // txt_dc
            // 
            this.txt_dc.Location = new System.Drawing.Point(81, 174);
            this.txt_dc.Name = "txt_dc";
            this.txt_dc.Size = new System.Drawing.Size(231, 20);
            this.txt_dc.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(81, 65);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(231, 20);
            this.txt_hoten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // txt_nameID
            // 
            this.txt_nameID.Location = new System.Drawing.Point(81, 29);
            this.txt_nameID.Name = "txt_nameID";
            this.txt_nameID.Size = new System.Drawing.Size(231, 20);
            this.txt_nameID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCCD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grv_nhm);
            this.groupBox2.Location = new System.Drawing.Point(21, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách: ";
            // 
            // grv_nhm
            // 
            this.grv_nhm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_nhm.Location = new System.Drawing.Point(6, 19);
            this.grv_nhm.Name = "grv_nhm";
            this.grv_nhm.Size = new System.Drawing.Size(729, 237);
            this.grv_nhm.TabIndex = 0;
            this.grv_nhm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_nhm_CellContentClick);
            // 
            // bt_insert
            // 
            this.bt_insert.BackgroundImage = global::QL_HienMau.Properties.Resources.add_user;
            this.bt_insert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_insert.Location = new System.Drawing.Point(20, 21);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(43, 41);
            this.bt_insert.TabIndex = 2;
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_reset);
            this.groupBox3.Controls.Add(this.bt_delete);
            this.groupBox3.Controls.Add(this.bt_update);
            this.groupBox3.Controls.Add(this.bt_insert);
            this.groupBox3.Location = new System.Drawing.Point(693, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(84, 215);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoạt động: ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // bt_reset
            // 
            this.bt_reset.BackgroundImage = global::QL_HienMau.Properties.Resources.reset;
            this.bt_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_reset.Location = new System.Drawing.Point(20, 166);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(43, 40);
            this.bt_reset.TabIndex = 5;
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.BackgroundImage = global::QL_HienMau.Properties.Resources.delete_user;
            this.bt_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_delete.Location = new System.Drawing.Point(20, 117);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(43, 40);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.BackgroundImage = global::QL_HienMau.Properties.Resources.edit_user;
            this.bt_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_update.Location = new System.Drawing.Point(20, 68);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(43, 41);
            this.bt_update.TabIndex = 3;
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // FormQLNguoiHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLNguoiHM";
            this.Text = "Quản lý người hiến máu";
            this.Load += new System.EventHandler(this.FormQLNguoiHM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_nhm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.TextBox txt_dc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grv_nhm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_gt;
        private System.Windows.Forms.DateTimePicker dtp_ns;
        private System.Windows.Forms.ComboBox cmb_htID;
        private System.Windows.Forms.ComboBox cmb_mauID;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.ComboBox cmb_resultID;
    }
}