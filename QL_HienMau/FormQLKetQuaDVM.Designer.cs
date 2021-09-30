
namespace QL_HienMau
{
    partial class FormQLKetQuaDVM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLKetQuaDVM));
            this.label8 = new System.Windows.Forms.Label();
            this.grv_kqdvm = new System.Windows.Forms.DataGridView();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_giangmai = new System.Windows.Forms.ComboBox();
            this.cmb_hiv = new System.Windows.Forms.ComboBox();
            this.cmb_antihcv = new System.Windows.Forms.ComboBox();
            this.cmb_hbsag = new System.Windows.Forms.ComboBox();
            this.cmb_ktbt = new System.Windows.Forms.ComboBox();
            this.cmb_mauID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_resultMauID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_kqdvm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã ĐV máu:";
            // 
            // grv_kqdvm
            // 
            this.grv_kqdvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_kqdvm.Location = new System.Drawing.Point(6, 19);
            this.grv_kqdvm.Name = "grv_kqdvm";
            this.grv_kqdvm.Size = new System.Drawing.Size(755, 150);
            this.grv_kqdvm.TabIndex = 0;
            this.grv_kqdvm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_kqdvm_CellContentClick);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(10, 176);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "Thoát";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grv_kqdvm);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_giangmai);
            this.groupBox1.Controls.Add(this.cmb_hiv);
            this.groupBox1.Controls.Add(this.cmb_antihcv);
            this.groupBox1.Controls.Add(this.cmb_hbsag);
            this.groupBox1.Controls.Add(this.cmb_ktbt);
            this.groupBox1.Controls.Add(this.cmb_mauID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_resultMauID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin:";
            // 
            // cmb_giangmai
            // 
            this.cmb_giangmai.FormattingEnabled = true;
            this.cmb_giangmai.Items.AddRange(new object[] {
            "Phản ứng",
            "Không phản ứng"});
            this.cmb_giangmai.Location = new System.Drawing.Point(399, 70);
            this.cmb_giangmai.Name = "cmb_giangmai";
            this.cmb_giangmai.Size = new System.Drawing.Size(231, 21);
            this.cmb_giangmai.TabIndex = 23;
            this.cmb_giangmai.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // cmb_hiv
            // 
            this.cmb_hiv.FormattingEnabled = true;
            this.cmb_hiv.Items.AddRange(new object[] {
            "Phản ứng",
            "Không phản ứng"});
            this.cmb_hiv.Location = new System.Drawing.Point(399, 25);
            this.cmb_hiv.Name = "cmb_hiv";
            this.cmb_hiv.Size = new System.Drawing.Size(231, 21);
            this.cmb_hiv.TabIndex = 22;
            this.cmb_hiv.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // cmb_antihcv
            // 
            this.cmb_antihcv.FormattingEnabled = true;
            this.cmb_antihcv.Items.AddRange(new object[] {
            "Phản ứng",
            "Không phản ứng"});
            this.cmb_antihcv.Location = new System.Drawing.Point(81, 166);
            this.cmb_antihcv.Name = "cmb_antihcv";
            this.cmb_antihcv.Size = new System.Drawing.Size(231, 21);
            this.cmb_antihcv.TabIndex = 21;
            // 
            // cmb_hbsag
            // 
            this.cmb_hbsag.FormattingEnabled = true;
            this.cmb_hbsag.Items.AddRange(new object[] {
            "Phản ứng",
            "Không phản ứng"});
            this.cmb_hbsag.Location = new System.Drawing.Point(81, 117);
            this.cmb_hbsag.Name = "cmb_hbsag";
            this.cmb_hbsag.Size = new System.Drawing.Size(231, 21);
            this.cmb_hbsag.TabIndex = 20;
            // 
            // cmb_ktbt
            // 
            this.cmb_ktbt.FormattingEnabled = true;
            this.cmb_ktbt.Items.AddRange(new object[] {
            "Phản ứng",
            "Không phản ứng"});
            this.cmb_ktbt.Location = new System.Drawing.Point(81, 72);
            this.cmb_ktbt.Name = "cmb_ktbt";
            this.cmb_ktbt.Size = new System.Drawing.Size(231, 21);
            this.cmb_ktbt.TabIndex = 19;
            // 
            // cmb_mauID
            // 
            this.cmb_mauID.FormattingEnabled = true;
            this.cmb_mauID.Location = new System.Drawing.Point(399, 117);
            this.cmb_mauID.Name = "cmb_mauID";
            this.cmb_mauID.Size = new System.Drawing.Size(231, 21);
            this.cmb_mauID.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giang mai:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "HIV Ag/Ab:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Anti-HCV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "HBsAg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "KTBT:";
            // 
            // txt_resultMauID
            // 
            this.txt_resultMauID.Location = new System.Drawing.Point(81, 29);
            this.txt_resultMauID.Name = "txt_resultMauID";
            this.txt_resultMauID.Size = new System.Drawing.Size(231, 20);
            this.txt_resultMauID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KQĐVM:";
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(9, 28);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(75, 23);
            this.bt_insert.TabIndex = 2;
            this.bt_insert.Text = "Thêm";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_cancel);
            this.groupBox3.Controls.Add(this.bt_reset);
            this.groupBox3.Controls.Add(this.bt_delete);
            this.groupBox3.Controls.Add(this.bt_update);
            this.groupBox3.Controls.Add(this.bt_insert);
            this.groupBox3.Location = new System.Drawing.Point(684, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 215);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoạt động: ";
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(10, 139);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 5;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(10, 103);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(10, 66);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 3;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // FormQLKetQuaDVM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 439);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormQLKetQuaDVM";
            this.Text = "Kết quả đơn vị máu";
            this.Load += new System.EventHandler(this.FormQLKetQuaDVM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_kqdvm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView grv_kqdvm;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.ComboBox cmb_giangmai;
        private System.Windows.Forms.ComboBox cmb_hiv;
        private System.Windows.Forms.ComboBox cmb_antihcv;
        private System.Windows.Forms.ComboBox cmb_hbsag;
        private System.Windows.Forms.ComboBox cmb_ktbt;
        private System.Windows.Forms.ComboBox cmb_mauID;
        private System.Windows.Forms.TextBox txt_resultMauID;
    }
}