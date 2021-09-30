
namespace QL_HienMau
{
    partial class FormThongKeMauConLai
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
            this.label1 = new System.Windows.Forms.Label();
            this.grv_mauconlai = new System.Windows.Forms.DataGridView();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_mauconlai)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grv_mauconlai);
            this.groupBox1.Controls.Add(this.txt_sum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 409);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết quả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tổng";
            // 
            // grv_mauconlai
            // 
            this.grv_mauconlai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_mauconlai.Location = new System.Drawing.Point(12, 22);
            this.grv_mauconlai.Name = "grv_mauconlai";
            this.grv_mauconlai.Size = new System.Drawing.Size(748, 344);
            this.grv_mauconlai.TabIndex = 0;
            // 
            // txt_sum
            // 
            this.txt_sum.Enabled = false;
            this.txt_sum.Location = new System.Drawing.Point(62, 381);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(75, 20);
            this.txt_sum.TabIndex = 2;
            this.txt_sum.TextChanged += new System.EventHandler(this.txt_sum_TextChanged);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(666, 388);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Thoát";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // FormThongKeMauConLai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QL_HienMau.Properties.Resources.anh_nen_dep_mau_hong_040306417;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThongKeMauConLai";
            this.Text = "FormThongKeMauConLai";
            this.Load += new System.EventHandler(this.FormThongKeMauConLai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_mauconlai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grv_mauconlai;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Label label1;
    }
}