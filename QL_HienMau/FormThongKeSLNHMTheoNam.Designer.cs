
namespace QL_HienMau
{
    partial class FormThongKeSLNHMTheoNam
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
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grv_slnhm = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_slnhm)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(122, 24);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(123, 20);
            this.txt_nam.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập năm:";
            // 
            // bt_tk
            // 
            this.bt_tk.Location = new System.Drawing.Point(311, 24);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(75, 23);
            this.bt_tk.TabIndex = 2;
            this.bt_tk.Text = "Thống kê";
            this.bt_tk.UseVisualStyleBackColor = true;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(407, 24);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "Thoát";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tổng";
            // 
            // txt_sum
            // 
            this.txt_sum.Enabled = false;
            this.txt_sum.Location = new System.Drawing.Point(584, 28);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(75, 20);
            this.txt_sum.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grv_slnhm);
            this.groupBox1.Location = new System.Drawing.Point(12, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 365);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả";
            // 
            // grv_slnhm
            // 
            this.grv_slnhm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_slnhm.Location = new System.Drawing.Point(6, 22);
            this.grv_slnhm.Name = "grv_slnhm";
            this.grv_slnhm.Size = new System.Drawing.Size(764, 336);
            this.grv_slnhm.TabIndex = 0;
            // 
            // FormThongKeSLNHMTheoNam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_HienMau.Properties.Resources.anh_nen_dep_mau_hong_040306417;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_tk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nam);
            this.Name = "FormThongKeSLNHMTheoNam";
            this.Text = "Thống kê số lượng người hiến máu theo năm";
            this.Load += new System.EventHandler(this.FormThongKeSLNHMTheoNam_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_slnhm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grv_slnhm;
    }
}