
namespace QL_HienMau
{
    partial class FormTimKiemNguoiHM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTimKiemNguoiHM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.txt_nameID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.grv_htm = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grv_kqdvm = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grv_dvm = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grv_nhm = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txt_hiennl = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_htm)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_kqdvm)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dvm)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_nhm)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Cancel);
            this.groupBox1.Controls.Add(this.bt_search);
            this.groupBox1.Controls.Add(this.txt_nameID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // bt_Cancel
            // 
            this.bt_Cancel.Location = new System.Drawing.Point(422, 17);
            this.bt_Cancel.Name = "bt_Cancel";
            this.bt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_Cancel.TabIndex = 22;
            this.bt_Cancel.Text = "Thoát";
            this.bt_Cancel.UseVisualStyleBackColor = true;
            this.bt_Cancel.Click += new System.EventHandler(this.bt_Cancel_Click);
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(341, 17);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 21;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // txt_nameID
            // 
            this.txt_nameID.Location = new System.Drawing.Point(79, 19);
            this.txt_nameID.Name = "txt_nameID";
            this.txt_nameID.Size = new System.Drawing.Size(231, 20);
            this.txt_nameID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "CCCD:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(22, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 523);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.grv_htm);
            this.groupBox6.Location = new System.Drawing.Point(19, 400);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(753, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hành trình đơn vị máu:";
            // 
            // grv_htm
            // 
            this.grv_htm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_htm.Location = new System.Drawing.Point(6, 18);
            this.grv_htm.Name = "grv_htm";
            this.grv_htm.Size = new System.Drawing.Size(733, 74);
            this.grv_htm.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grv_kqdvm);
            this.groupBox5.Location = new System.Drawing.Point(18, 281);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(754, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kết quả đơn vị máu:";
            // 
            // grv_kqdvm
            // 
            this.grv_kqdvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_kqdvm.Location = new System.Drawing.Point(6, 18);
            this.grv_kqdvm.Name = "grv_kqdvm";
            this.grv_kqdvm.Size = new System.Drawing.Size(734, 75);
            this.grv_kqdvm.TabIndex = 1;
            this.grv_kqdvm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_kqdvm_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grv_dvm);
            this.groupBox4.Location = new System.Drawing.Point(19, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 112);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đơn vị máu";
            // 
            // grv_dvm
            // 
            this.grv_dvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dvm.Location = new System.Drawing.Point(6, 17);
            this.grv_dvm.Name = "grv_dvm";
            this.grv_dvm.Size = new System.Drawing.Size(734, 87);
            this.grv_dvm.TabIndex = 1;
            this.grv_dvm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_dvm_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grv_nhm);
            this.groupBox3.Location = new System.Drawing.Point(18, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(754, 112);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin người hiến máu:";
            // 
            // grv_nhm
            // 
            this.grv_nhm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_nhm.Location = new System.Drawing.Point(6, 19);
            this.grv_nhm.Name = "grv_nhm";
            this.grv_nhm.Size = new System.Drawing.Size(734, 87);
            this.grv_nhm.TabIndex = 0;
            this.grv_nhm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_nhm_CellContentClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txt_hiennl);
            this.groupBox7.Location = new System.Drawing.Point(574, 13);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(221, 50);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thời gian nhắc lại (ngày): ";
            // 
            // txt_hiennl
            // 
            this.txt_hiennl.Location = new System.Drawing.Point(16, 19);
            this.txt_hiennl.Name = "txt_hiennl";
            this.txt_hiennl.Size = new System.Drawing.Size(190, 20);
            this.txt_hiennl.TabIndex = 0;
            this.txt_hiennl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormTimKiemNguoiHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 619);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimKiemNguoiHM";
            this.Text = "Tìm kiếm thông tin người hiến máu";
            this.Load += new System.EventHandler(this.FormTimKiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_htm)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_kqdvm)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_dvm)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_nhm)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_nameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grv_nhm;
        private System.Windows.Forms.DataGridView grv_htm;
        private System.Windows.Forms.DataGridView grv_kqdvm;
        private System.Windows.Forms.DataGridView grv_dvm;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txt_hiennl;
    }
}