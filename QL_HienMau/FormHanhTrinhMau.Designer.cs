
namespace QL_HienMau
{
    partial class FormHanhTrinhMau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHanhTrinhMau));
            this.grv_htdvm = new System.Windows.Forms.DataGridView();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.dt_lt = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_diadiemsd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_diadiemlt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_mauID = new System.Windows.Forms.ComboBox();
            this.dt_timesd = new System.Windows.Forms.DateTimePicker();
            this.txt_htID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_insert = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grv_htdvm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grv_htdvm
            // 
            this.grv_htdvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_htdvm.Location = new System.Drawing.Point(6, 19);
            this.grv_htdvm.Name = "grv_htdvm";
            this.grv_htdvm.Size = new System.Drawing.Size(744, 185);
            this.grv_htdvm.TabIndex = 0;
            this.grv_htdvm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_htdvm_CellContentClick);
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
            // dt_lt
            // 
            this.dt_lt.Location = new System.Drawing.Point(81, 120);
            this.dt_lt.Name = "dt_lt";
            this.dt_lt.Size = new System.Drawing.Size(231, 20);
            this.dt_lt.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã ĐV Máu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(330, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Thời gian SD:";
            // 
            // txt_diadiemsd
            // 
            this.txt_diadiemsd.Location = new System.Drawing.Point(401, 34);
            this.txt_diadiemsd.Name = "txt_diadiemsd";
            this.txt_diadiemsd.Size = new System.Drawing.Size(231, 20);
            this.txt_diadiemsd.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa điểm SD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian LT:";
            // 
            // txt_diadiemlt
            // 
            this.txt_diadiemlt.Location = new System.Drawing.Point(81, 80);
            this.txt_diadiemlt.Name = "txt_diadiemlt";
            this.txt_diadiemlt.Size = new System.Drawing.Size(231, 20);
            this.txt_diadiemlt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa điểm LT:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_mauID);
            this.groupBox1.Controls.Add(this.dt_timesd);
            this.groupBox1.Controls.Add(this.dt_lt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_diadiemsd);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_diadiemlt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_htID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 215);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin:";
            // 
            // cmb_mauID
            // 
            this.cmb_mauID.FormattingEnabled = true;
            this.cmb_mauID.Location = new System.Drawing.Point(401, 116);
            this.cmb_mauID.Name = "cmb_mauID";
            this.cmb_mauID.Size = new System.Drawing.Size(231, 21);
            this.cmb_mauID.TabIndex = 20;
            // 
            // dt_timesd
            // 
            this.dt_timesd.Location = new System.Drawing.Point(401, 78);
            this.dt_timesd.Name = "dt_timesd";
            this.dt_timesd.Size = new System.Drawing.Size(231, 20);
            this.dt_timesd.TabIndex = 19;
            // 
            // txt_htID
            // 
            this.txt_htID.Location = new System.Drawing.Point(81, 37);
            this.txt_htID.Name = "txt_htID";
            this.txt_htID.Size = new System.Drawing.Size(231, 20);
            this.txt_htID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HT:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grv_htdvm);
            this.groupBox2.Location = new System.Drawing.Point(17, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách: ";
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
            this.groupBox3.Location = new System.Drawing.Point(689, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 215);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hoạt động: ";
            // 
            // FormHanhTrinhMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormHanhTrinhMau";
            this.Text = "Hành trình đơn vị máu";
            this.Load += new System.EventHandler(this.FormHanhTrinhMau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_htdvm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grv_htdvm;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.DateTimePicker dt_lt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_diadiemsd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_diadiemlt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_htID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_insert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmb_mauID;
        private System.Windows.Forms.DateTimePicker dt_timesd;
    }
}