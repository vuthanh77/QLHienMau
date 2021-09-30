
namespace QL_HienMau
{
    partial class FormThongKeSoLanHM
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
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nameid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grv_slhm = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_slhm)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_tk
            // 
            this.bt_tk.Location = new System.Drawing.Point(434, 25);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(75, 23);
            this.bt_tk.TabIndex = 1;
            this.bt_tk.Text = "Thống kê";
            this.bt_tk.UseVisualStyleBackColor = true;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(515, 25);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 2;
            this.bt_cancel.Text = "Thoát";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CCCD:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nameid
            // 
            this.txt_nameid.Location = new System.Drawing.Point(219, 28);
            this.txt_nameid.Name = "txt_nameid";
            this.txt_nameid.Size = new System.Drawing.Size(177, 20);
            this.txt_nameid.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grv_slhm);
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 356);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả:";
            // 
            // grv_slhm
            // 
            this.grv_slhm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_slhm.Location = new System.Drawing.Point(10, 22);
            this.grv_slhm.Name = "grv_slhm";
            this.grv_slhm.Size = new System.Drawing.Size(760, 328);
            this.grv_slhm.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tổng";
            // 
            // txt_sum
            // 
            this.txt_sum.Enabled = false;
            this.txt_sum.Location = new System.Drawing.Point(672, 26);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(75, 20);
            this.txt_sum.TabIndex = 7;
            // 
            // FormThongKeSoLanHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_HienMau.Properties.Resources.anh_nen_dep_mau_hong_040306417;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_nameid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_tk);
            this.Name = "FormThongKeSoLanHM";
            this.Text = "Thống kê số lần hiến máu";
            this.Load += new System.EventHandler(this.FormThongKeSoLanHM_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grv_slhm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nameid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grv_slhm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sum;
    }
}