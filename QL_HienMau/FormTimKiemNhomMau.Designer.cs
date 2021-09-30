
namespace QL_HienMau
{
    partial class FormTimKiemNhomMau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_rh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_abo = new System.Windows.Forms.ComboBox();
            this.bt_Cancel = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grv_dvm = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_dvm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_rh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_abo);
            this.groupBox1.Controls.Add(this.bt_Cancel);
            this.groupBox1.Controls.Add(this.bt_search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(147, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm:";
            // 
            // cmb_rh
            // 
            this.cmb_rh.FormattingEnabled = true;
            this.cmb_rh.Items.AddRange(new object[] {
            "Rh+",
            "Rh-"});
            this.cmb_rh.Location = new System.Drawing.Point(202, 20);
            this.cmb_rh.Name = "cmb_rh";
            this.cmb_rh.Size = new System.Drawing.Size(82, 21);
            this.cmb_rh.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Rh:";
            // 
            // cmb_abo
            // 
            this.cmb_abo.FormattingEnabled = true;
            this.cmb_abo.Items.AddRange(new object[] {
            "A",
            "B",
            "O",
            "AB"});
            this.cmb_abo.Location = new System.Drawing.Point(54, 20);
            this.cmb_abo.Name = "cmb_abo";
            this.cmb_abo.Size = new System.Drawing.Size(82, 21);
            this.cmb_abo.TabIndex = 23;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ABO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(11, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 406);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grv_dvm);
            this.groupBox4.Location = new System.Drawing.Point(18, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(754, 370);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đơn vị máu";
            // 
            // grv_dvm
            // 
            this.grv_dvm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_dvm.Location = new System.Drawing.Point(6, 17);
            this.grv_dvm.Name = "grv_dvm";
            this.grv_dvm.Size = new System.Drawing.Size(734, 347);
            this.grv_dvm.TabIndex = 1;
            // 
            // FormTimKiemNhomMau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_HienMau.Properties.Resources.anh_nen_dep_mau_hong_040306417;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTimKiemNhomMau";
            this.Text = "Tìm kiếm nhóm máu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_dvm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Cancel;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_abo;
        private System.Windows.Forms.ComboBox cmb_rh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grv_dvm;
    }
}