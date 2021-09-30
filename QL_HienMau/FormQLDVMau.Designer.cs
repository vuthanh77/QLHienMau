
namespace QL_HienMau
{
    partial class FormQLDVMau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLDVMau));
            this.cmb_thetich = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grv_dvm = new System.Windows.Forms.DataGridView();
            this.txt_mauID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_insert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_rh = new System.Windows.Forms.ComboBox();
            this.cmb_abo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_ngayhm = new System.Windows.Forms.DateTimePicker();
            this.txt_ddhm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dvm)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_thetich
            // 
            this.cmb_thetich.FormattingEnabled = true;
            this.cmb_thetich.Items.AddRange(new object[] {
            "250ml",
            "350ml",
            "450ml"});
            this.cmb_thetich.Location = new System.Drawing.Point(90, 66);
            this.cmb_thetich.Name = "cmb_thetich";
            this.cmb_thetich.Size = new System.Drawing.Size(220, 21);
            this.cmb_thetich.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thể tích:";
            // 
            // grv_dvm
            // 
            this.grv_dvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dvm.Location = new System.Drawing.Point(6, 19);
            this.grv_dvm.Name = "grv_dvm";
            this.grv_dvm.Size = new System.Drawing.Size(490, 150);
            this.grv_dvm.TabIndex = 0;
            this.grv_dvm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_dvm_CellContentClick);
            // 
            // txt_mauID
            // 
            this.txt_mauID.Location = new System.Drawing.Point(90, 29);
            this.txt_mauID.Name = "txt_mauID";
            this.txt_mauID.Size = new System.Drawing.Size(220, 20);
            this.txt_mauID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ĐV Máu:";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(24, 176);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "Thoát";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(24, 139);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(75, 23);
            this.bt_reset.TabIndex = 5;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(24, 103);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 4;
            this.bt_delete.Text = "Xóa";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(24, 66);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 3;
            this.bt_update.Text = "Sửa";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_cancel);
            this.groupBox3.Controls.Add(this.bt_reset);
            this.groupBox3.Controls.Add(this.bt_delete);
            this.groupBox3.Controls.Add(this.bt_update);
            this.groupBox3.Controls.Add(this.bt_insert);
            this.groupBox3.Location = new System.Drawing.Point(398, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 215);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoạt động: ";
            // 
            // bt_insert
            // 
            this.bt_insert.Location = new System.Drawing.Point(23, 28);
            this.bt_insert.Name = "bt_insert";
            this.bt_insert.Size = new System.Drawing.Size(75, 23);
            this.bt_insert.TabIndex = 2;
            this.bt_insert.Text = "Thêm";
            this.bt_insert.UseVisualStyleBackColor = true;
            this.bt_insert.Click += new System.EventHandler(this.bt_insert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grv_dvm);
            this.groupBox2.Location = new System.Drawing.Point(17, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 179);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày HM:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_rh);
            this.groupBox1.Controls.Add(this.cmb_abo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dt_ngayhm);
            this.groupBox1.Controls.Add(this.cmb_thetich);
            this.groupBox1.Controls.Add(this.txt_ddhm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_mauID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin:";
            // 
            // cmb_rh
            // 
            this.cmb_rh.FormattingEnabled = true;
            this.cmb_rh.Items.AddRange(new object[] {
            "Rh+",
            "Rh-"});
            this.cmb_rh.Location = new System.Drawing.Point(240, 174);
            this.cmb_rh.Name = "cmb_rh";
            this.cmb_rh.Size = new System.Drawing.Size(70, 21);
            this.cmb_rh.TabIndex = 24;
            // 
            // cmb_abo
            // 
            this.cmb_abo.FormattingEnabled = true;
            this.cmb_abo.Items.AddRange(new object[] {
            "O",
            "A",
            "B",
            "AB"});
            this.cmb_abo.Location = new System.Drawing.Point(90, 176);
            this.cmb_abo.Name = "cmb_abo";
            this.cmb_abo.Size = new System.Drawing.Size(70, 21);
            this.cmb_abo.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "RH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "ABO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dt_ngayhm
            // 
            this.dt_ngayhm.Location = new System.Drawing.Point(90, 103);
            this.dt_ngayhm.Name = "dt_ngayhm";
            this.dt_ngayhm.Size = new System.Drawing.Size(220, 20);
            this.dt_ngayhm.TabIndex = 20;
            // 
            // txt_ddhm
            // 
            this.txt_ddhm.Location = new System.Drawing.Point(90, 139);
            this.txt_ddhm.Name = "txt_ddhm";
            this.txt_ddhm.Size = new System.Drawing.Size(220, 20);
            this.txt_ddhm.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa điểm HM:";
            // 
            // FormQLDVMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormQLDVMau";
            this.Text = "Quản lý đơn vị máu";
            this.Load += new System.EventHandler(this.FormQLDVMau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_dvm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_thetich;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grv_dvm;
        private System.Windows.Forms.TextBox txt_mauID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_ngayhm;
        private System.Windows.Forms.TextBox txt_ddhm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_rh;
        private System.Windows.Forms.ComboBox cmb_abo;
        private System.Windows.Forms.Label label6;
    }
}